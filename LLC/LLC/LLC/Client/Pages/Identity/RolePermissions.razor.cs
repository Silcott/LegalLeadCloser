using System;
using AutoMapper;
using LLC.Application.Requests.Identity;
using LLC.Application.Responses.Identity;
using LLC.Client.Extensions;
using LLC.Client.Infrastructure.Mappings;
using LLC.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Threading.Tasks;

namespace LLC.Client.Pages.Identity
{
    public partial class RolePermissions
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        public PermissionResponse model { get; set; }
        private IMapper _mapper;
        private RoleClaimsResponse roleClaims = new();
        private string searchString = "";
        private bool _dense = true;
        private bool _striped = true;
        private bool _bordered = false;

        protected override async Task OnInitializedAsync()
        {
            _mapper = new MapperConfiguration(c => { c.AddProfile<RoleProfile>(); }).CreateMapper();
            var roleId = Id;
            var result = await _roleManager.GetPermissionsAsync(roleId);
            if (result.Succeeded)
            {
                model = result.Data;
                if (model != null)
                {
                    Description = $"{localizer["Manage"]} {model.RoleId} {model.RoleName}'s {localizer["Permissions"]}";
                }
            }
            hubConnection = hubConnection.TryInitialize(_navigationManager);
            if (hubConnection.State == HubConnectionState.Disconnected)
            {
                await hubConnection.StartAsync();
            }
        }

        [CascadingParameter] public HubConnection hubConnection { get; set; }

        private async Task SaveAsync()
        {
            var request = _mapper.Map<PermissionResponse, PermissionRequest>(model);
            var result = await _roleManager.UpdatePermissionsAsync(request);
            if (result.Succeeded)
            {
                _snackBar.Add(localizer[result.Messages[0]], Severity.Success);
                await hubConnection.SendAsync(ApplicationConstants.SignalR.SendRegenerateTokens);
                _navigationManager.NavigateTo("/identity/roles");
            }
            else
            {
                foreach (var error in result.Messages)
                {
                    _snackBar.Add(localizer[error], Severity.Error);
                }
            }
        }

        private bool Search(RoleClaimsResponse roleClaims)
        {
            if (string.IsNullOrWhiteSpace(searchString)) return true;
            if (roleClaims.Value?.Contains(searchString, StringComparison.OrdinalIgnoreCase) == true)
            {
                return true;
            }
            return false;
        }
    }
}