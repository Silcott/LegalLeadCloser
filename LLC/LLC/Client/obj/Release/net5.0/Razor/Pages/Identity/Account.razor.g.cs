#pragma checksum "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba69bafddebcf918ad9d0b0df1f36074c391cb86"
// <auto-generated/>
#pragma warning disable 1591
namespace LLC.Client.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LLC.Client.Shared.Components.HeroTitle>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                   localizer["Account"]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Description", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                                                       localizer["Manage your account"]

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudTabs>(4);
            __builder.AddAttribute(5, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                    25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 5 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                               Color.Transparent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "PanelClass", "mt-6");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(10);
                __builder2.AddAttribute(11, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                        localizer["Profile"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<LLC.Client.Pages.Identity.Profile>(13);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(15);
                __builder2.AddAttribute(16, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\Client\Pages\Identity\Account.razor"
                        localizer["Security"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<LLC.Client.Pages.Identity.Security>(18);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<Account> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDocumentManager _documentManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuditManager _auditManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IChatManager _chatManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDashboardManager _dashboardManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBrandManager _brandManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductManager _productManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRoleManager _roleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
