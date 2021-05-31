﻿using AutoMapper;
using LLC.Application.Exceptions;
using LLC.Application.Interfaces.Services;
using LLC.Application.Interfaces.Services.Identity;
using LLC.Application.Models.Identity;
using LLC.Application.Requests.Identity;
using LLC.Application.Requests.Mail;
using LLC.Application.Responses.Identity;
using LLC.Shared.Constants.Role;
using LLC.Shared.Wrapper;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;


namespace LLC.Infrastructure.Services.Identity
{
    public class UserService : IUserService
    {
        private readonly UserManager<LLCUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMailService _mailService;
        private readonly IStringLocalizer<UserService> _localizer;
        private readonly IMapper _mapper;

        public UserService(
            UserManager<LLCUser> userManager,
            IMapper mapper,
            RoleManager<IdentityRole> roleManager,
            IMailService mailService,
            IStringLocalizer<UserService> localizer)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _mailService = mailService;
            _localizer = localizer;
        }

        public async Task<Result<List<UserResponse>>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var result = _mapper.Map<List<UserResponse>>(users);
            return await Result<List<UserResponse>>.SuccessAsync(result);
        }

        public async Task<IResult> RegisterAsync(RegisterRequest request, string origin)
        {
            var userWithSameUserName = await _userManager.FindByNameAsync(request.UserName);
            if (userWithSameUserName != null)
            {
                return await Result.FailAsync($"{_localizer["Username"]} '{request.UserName}' {_localizer["is already taken."]}");
            }
            var user = new LLCUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                IsActive = request.ActivateUser,
                EmailConfirmed = request.AutoConfirmEmail
            };
            var userWithSameEmail = await _userManager.FindByEmailAsync(request.Email);
            if (userWithSameEmail == null)
            {
                var result = await _userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, RoleConstants.BasicRole);
                    if (!request.AutoConfirmEmail)
                    {
                        var verificationUri = await SendVerificationEmail(user, origin);
                        var mailRequest = new MailRequest
                        {
                            From = "ascent.legal.us.noreply@gmail.com",
                            To = user.Email,
                            Body = $"{_localizer["Please confirm your account by"]} <a href='{verificationUri}'>{_localizer["clicking here"]}</a>.",
                            Subject = _localizer["Confirm Registration"]
                        };
                        BackgroundJob.Enqueue(() => _mailService.SendAsync(mailRequest));
                        return await Result<string>.SuccessAsync(user.Id, message: _localizer[$"User Registered. Please check your Mailbox to verify!"]);
                    }
                    return await Result<string>.SuccessAsync(user.Id, message: _localizer[$"User Registered"]);
                }
                else
                {
                    return await Result.FailAsync(result.Errors.Select(a => a.Description).ToList());
                }
            }
            else
            {
                return await Result.FailAsync($"{_localizer["Email"]} {request.Email } {_localizer["is already registered."]}");
            }
        }

        private async Task<string> SendVerificationEmail(LLCUser user, string origin)
        {
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "api/identity/user/confirm-email/";
            var endpointUri = new Uri(string.Concat($"{origin}/", route));
            var verificationUri = QueryHelpers.AddQueryString(endpointUri.ToString(), "userId", user.Id);
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
            return verificationUri;
        }

        public async Task<IResult<UserResponse>> GetAsync(string userId)
        {
            var user = await _userManager.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
            var result = _mapper.Map<UserResponse>(user);
            return await Result<UserResponse>.SuccessAsync(result);
        }

        public async Task<IResult> ToggleUserStatusAsync(ToggleUserStatusRequest request)
        {
            var user = await _userManager.Users.Where(u => u.Id == request.UserId).FirstOrDefaultAsync();
            var isAdmin = await _userManager.IsInRoleAsync(user, RoleConstants.AdministratorRole);
            if (isAdmin)
            {
                return await Result.FailAsync(_localizer["Administrators Profile's Status cannot be toggled"]);
            }
            if (user != null)
            {
                user.IsActive = request.ActivateUser;
                var identityResult = await _userManager.UpdateAsync(user);
            }
            return await Result.SuccessAsync();
        }
        //TODO clean
        public async Task<IResult>DeleteUserAsync(ToggleUserStatusRequest request)
        {
            var user = await _userManager.Users.Where(u => u.Id == request.UserId).FirstOrDefaultAsync();

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
                return await Result.SuccessAsync(_localizer["User Deleted"]);

            }
            return await Result.SuccessAsync(_localizer["User Not Deleted"]);
        }
        public async Task<IResult<UserRolesResponse>> GetRolesAsync(string userId)
        {
            var viewModel = new List<UserRoleModel>();
            var user = await _userManager.FindByIdAsync(userId);
            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new UserRoleModel
                {
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.Selected = true;
                }
                else
                {
                    userRolesViewModel.Selected = false;
                }
                viewModel.Add(userRolesViewModel);
            }
            var result = new UserRolesResponse { UserRoles = viewModel };
            return await Result<UserRolesResponse>.SuccessAsync(result);
        }

        //TODO check if this is email reason for authenitcation
        public async Task<IResult> UpdateRolesAsync(UpdateUserRolesRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.UserId);
            if (user.Email == "ascent.legal.us@gmail.com") return await Result.FailAsync(_localizer["Not Allowed."]);
            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);
            result = await _userManager.AddToRolesAsync(user, request.UserRoles.Where(x => x.Selected).Select(y => y.RoleName));
            return await Result.SuccessAsync(_localizer["Roles Updated"]);
        }

        public async Task<IResult<string>> ConfirmEmailAsync(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return await Result<string>.SuccessAsync(user.Id, message: $"{_localizer["Account Confirmed for"]} {user.Email}. {_localizer["You can now use the /api/identity/token endpoint to generate JWT."]}");
            }
            else
            {
                throw new ApiException($"{_localizer["An error occured while confirming"]} {user.Email}.");
            }
        }

        public async Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // Don't reveal that the user does not exist or is not confirmed
                return await Result.FailAsync(_localizer["An Error has occured!"]);
            }
            // For more information on how to enable account confirmation and password reset please
            // visit https://go.microsoft.com/fwlink/?LinkID=532713
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "account/reset-password";
            var endpointUri = new Uri(string.Concat($"{origin}/", route));
            var passwordResetURL = QueryHelpers.AddQueryString(endpointUri.ToString(), "Token", code);
            var mailRequest = new MailRequest()
            {
                Body = $"{_localizer["Please reset your password by"]} <a href='{HtmlEncoder.Default.Encode(passwordResetURL)}'>{_localizer["clicking here"]}</a>.",
                Subject = _localizer["Reset Password"],
                To = request.Email
            };
            BackgroundJob.Enqueue(() => _mailService.SendAsync(mailRequest));
            return await Result.SuccessAsync(_localizer["Password Reset Mail has been sent to your authorized EmailId."]);
        }

        public async Task<IResult> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return await Result.FailAsync(_localizer["An Error has occured!"]);
            }

            var result = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);
            if (result.Succeeded)
            {
                return await Result.SuccessAsync(_localizer["Password Reset Successful!"]);
            }
            else
            {
                return await Result.FailAsync(_localizer["An Error has occured!"]);
            }
        }

        public async Task<int> GetCountAsync()
        {
            var count = await _userManager.Users.CountAsync();
            return count;
        }
    }
}