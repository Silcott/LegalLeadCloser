#pragma checksum "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1a54fdcc3d1f44b5560fb75d6196ca4db0b6b0f"
// <auto-generated/>
#pragma warning disable 1591
namespace LLC.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LLC.Client.Shared.Components.UserCard>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDivider>(2);
            __builder.AddAttribute(3, "Class", "mb-4");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudNavMenu>(5);
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(7);
                __builder2.AddAttribute(8, "Href", "/");
                __builder2.AddAttribute(9, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                         Icons.Material.Outlined.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(12, 
#nullable restore
#line 8 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                                                        localizer["Home"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(14);
                __builder2.AddAttribute(15, "Href", "https://github.com/Silcott/LegalLeadCloser");
                __builder2.AddAttribute(16, "Target", "_blank");
                __builder2.AddAttribute(17, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                                                         Icons.Material.Outlined.ReadMore

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(19, 
#nullable restore
#line 10 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         localizer["Quick Start Guide"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(21);
                __builder2.AddAttribute(22, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, 
#nullable restore
#line 12 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                          localizer["Personal"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(26);
                __builder2.AddAttribute(27, "Href", "/account");
                __builder2.AddAttribute(28, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                       Icons.Material.Outlined.SupervisorAccount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(30, 
#nullable restore
#line 14 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         localizer["Account"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(32);
                __builder2.AddAttribute(33, "Href", "/audit-trails");
                __builder2.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                            Icons.Material.Outlined.Security

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(36, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         localizer["Audit Trails"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
     if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Roles.View).Result.Succeeded || _authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Users.View).Result.Succeeded)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(37);
                __builder2.AddAttribute(38, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(40, 
#nullable restore
#line 23 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
             localizer["Administrator"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 25 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Users.View).Result.Succeeded)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(41);
                __builder2.AddAttribute(42, "Href", "/identity/users");
                __builder2.AddAttribute(43, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, 
#nullable restore
#line 28 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Users"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(47);
                __builder2.AddAttribute(48, "Href", "/dashboard");
                __builder2.AddAttribute(49, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                 Icons.Material.Outlined.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(51, 
#nullable restore
#line 31 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Dashboard"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(53);
                __builder2.AddAttribute(54, "Href", "/jobs");
                __builder2.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                            Icons.Material.Outlined.Work

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, 
#nullable restore
#line 34 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Hangfire"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(59);
                __builder2.AddAttribute(60, "Href", "/swagger/index.html");
                __builder2.AddAttribute(61, "Target", "_blank");
                __builder2.AddAttribute(62, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                                          Icons.Material.Outlined.LiveHelp

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(64, 
#nullable restore
#line 37 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Swagger"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 39 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Roles.View).Result.Succeeded)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(65);
                __builder2.AddAttribute(66, "Href", "/identity/roles");
                __builder2.AddAttribute(67, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, 
#nullable restore
#line 43 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                                                       localizer["Roles"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 44 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(70);
                __builder2.AddAttribute(71, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(73, 
#nullable restore
#line 47 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                          localizer["Communication"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(75);
                __builder2.AddAttribute(76, "Href", "/chat");
                __builder2.AddAttribute(77, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                    Icons.Material.Outlined.Chat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(79, 
#nullable restore
#line 49 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         localizer["Chat"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 51 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
     if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Products.View).Result.Succeeded || _authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Brands.View).Result.Succeeded)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(80);
                __builder2.AddAttribute(81, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, 
#nullable restore
#line 53 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                              localizer["Client Management"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 54 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Products.View).Result.Succeeded)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(84);
                __builder2.AddAttribute(85, "Href", "/catalog/products");
                __builder2.AddAttribute(86, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                        Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(88, 
#nullable restore
#line 57 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Closer Script"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 59 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         if (_authorizationService.AuthorizeAsync(AuthenticationStateProviderUser, Permissions.Brands.View).Result.Succeeded)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudNavLink>(89);
                __builder2.AddAttribute(90, "Href", "/catalog/brands");
                __builder2.AddAttribute(91, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(93, 
#nullable restore
#line 63 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Clients"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(95);
                __builder2.AddAttribute(96, "Href", "/document-store");
                __builder2.AddAttribute(97, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.AttachFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(99, 
#nullable restore
#line 66 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
                 localizer["Documents"]

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 68 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
         

    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\silco\Documents\LegalLeadCloser\LLC\LLC\LLC\Client\Shared\NavMenu.razor"
       
    private ClaimsPrincipal AuthenticationStateProviderUser { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        AuthenticationStateProviderUser = await _stateProvider.GetAuthenticationStateProviderUserAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<NavMenu> localizer { get; set; }
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
    }
}
#pragma warning restore 1591
