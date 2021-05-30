using LLC.Application.Interfaces.Services;
using LLC.Application.Interfaces.Services.Account;
using LLC.Application.Requests.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LLC.Server.Controllers.Identity
{
    [Authorize]
    [Route("api/identity/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ICurrentUserService _currentUser;

        public AccountController(IAccountService accountService, ICurrentUserService currentUser)
        {
            _accountService = accountService;
            _currentUser = currentUser;
        }

        [HttpPut(nameof(UpdateProfile))]
        public async Task<ActionResult> UpdateProfile(UpdateProfileRequest model)
        {
            var response = await _accountService.UpdateProfileAsync(model, _currentUser.UserId);
            return Ok(response);
        }

        [HttpPut(nameof(DeleteUser))]
        public async Task<ActionResult> DeleteUser(string userId)
        {
            var response = await _accountService.DeleteUser( _currentUser.UserId);
            return Ok(response);
        }

        [HttpPut(nameof(ChangePassword))]
        public async Task<ActionResult> ChangePassword(ChangePasswordRequest model)
        {
            var response = await _accountService.ChangePasswordAsync(model, _currentUser.UserId);
            return Ok(response);
        }

        [HttpGet("profile-picture/{userId}")]
        public async Task<IActionResult> GetProfilePictureAsync(string userId)
        {
            return Ok(await _accountService.GetProfilePictureAsync(userId));
        }

        [HttpPost("profile-picture/{userId}")]
        public async Task<IActionResult> UpdateProfilePictureAsync(UpdateProfilePictureRequest request)
        {
            return Ok(await _accountService.UpdateProfilePictureAsync(request, _currentUser.UserId));
        }
    }
}