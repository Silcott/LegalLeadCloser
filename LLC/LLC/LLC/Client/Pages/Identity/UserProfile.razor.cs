using LLC.Application.Interfaces.Services.Identity;
using LLC.Application.Requests.Identity;
using LLC.Client.Infrastructure.Managers.Identity.Users;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LLC.Client.Pages.Identity
{
    public partial class UserProfile
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        public bool Active { get; set; }
        private char FirstLetterOfName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Color AvatarButtonColor { get; set; } = Color.Error;
        public IEnumerable<string> Errors { get; set; }

        private async Task ToggleUserStatus()
        {
            var request = new ToggleUserStatusRequest { ActivateUser = Active, UserId = Id };
            var result = await _userManager.ToggleUserStatusAsync(request);
            if (result.Succeeded)
            {
                _snackBar.Add(localizer["Updated User Status."], Severity.Success);
                _navigationManager.NavigateTo("/identity/users");
            }
            else
            {
                foreach (var error in result.Messages)
                {
                    _snackBar.Add(localizer[error], Severity.Error);
                }
            }
        }
        private TokenRequest tokenModel = new TokenRequest();
        private async Task DeleteUser()
        {
            bool? result = await mbox.Show();
                    state = result == null ? "Cancelled" : "Deleted!";
                    StateHasChanged();
            if (state.Equals("Deleted!"))
            {
            var request = new ToggleUserStatusRequest { UserId = Id };
                if (Id == null)
                {
                _snackBar.Add(localizer["Id is null"], Severity.Success);

                }
                //TODO setup admin account email that no one else can create
                else if (tokenModel.Email == "silcott.jb@outlook.com")
                {
                    _snackBar.Add(localizer["Can't delete Admin"], Severity.Success);
                }
                else
                {
                    await _userManager.DeleteUserAsync(request);
                    _navigationManager.NavigateTo("/identity/");
                }
            }
        }

        [Parameter]
        public string ImageDataUrl { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var userId = Id;
            var result = await _userManager.GetAsync(userId);
            if (result.Succeeded)
            {
                var user = result.Data;
                if (user != null)
                {
                    FirstName = user.FirstName;
                    LastName = user.LastName;
                    Email = user.Email;
                    PhoneNumber = user.PhoneNumber;
                    Active = user.IsActive;
                    var data = await _accountManager.GetProfilePictureAsync(userId);
                    if (data.Succeeded)
                    {
                        ImageDataUrl = data.Data;
                    }
                }
                Title = $"{FirstName} {LastName}'s {localizer["Profile"]}";
                Description = Email;
                if (FirstName.Length > 0)
                {
                    FirstLetterOfName = FirstName[0];
                }
            }
        }
    }
}