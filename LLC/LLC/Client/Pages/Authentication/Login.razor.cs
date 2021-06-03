﻿using LLC.Application.Requests.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;

namespace LLC.Client.Pages.Authentication
{
    public partial class Login
    {
        [Inject] private Microsoft.Extensions.Localization.IStringLocalizer<Login> localizer { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });

        private TokenRequest tokenModel = new TokenRequest();

        protected override async Task OnInitializedAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            if (state != new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())))
            {
                _navigationManager.NavigateTo("/");
            }
        }

        private async Task SubmitAsync()
        {
            var result = await _authenticationManager.Login(tokenModel);
            if (result.Succeeded)
            {
                _snackBar.Add($"{localizer["Welcome"]} {tokenModel.Email}.", Severity.Success);
                _navigationManager.NavigateTo("/", true);
            }
            else
            {
                foreach (var message in result.Messages)
                {
                    _snackBar.Add(localizer[message], Severity.Error);
                }
            }
        }

        private bool PasswordVisibility;
        private InputType PasswordInput = InputType.Password;
        private string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;

        void TogglePasswordVisibility()
        {
            if(PasswordVisibility)
            {
                PasswordVisibility = false;
                PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
                PasswordInput = InputType.Password;
            }
            else
            {
                PasswordVisibility = true;
                PasswordInputIcon = Icons.Material.Filled.Visibility;
                PasswordInput = InputType.Text;
            }
        }

        private void FillAdministratorCredentials()
        {
            tokenModel.Email = "admin@gmail.com";
            tokenModel.Password = "123Pa$$word!";
        }

        private void FillBasicUserCredentials()
        {
            tokenModel.Email = "lawyer@gmail.com";
            tokenModel.Password = "123Pa$$word!";
        }

        private void FillClientCredentials()
        {
            tokenModel.Email = "client@gmail.com";
            tokenModel.Password = "123Pa$$word!";
        }
    }
}