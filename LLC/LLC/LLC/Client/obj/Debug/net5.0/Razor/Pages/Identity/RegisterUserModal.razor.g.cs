#pragma checksum "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845af219c748a8e6bbe026952fd140ad1df8dfb9"
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
#line 2 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Managers.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Application.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
using LLC.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class RegisterUserModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                  registerUserModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                    SubmitAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazored.FluentValidation.FluentValidationValidator>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 2 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                     _fluentValidationValidator = (Blazored.FluentValidation.FluentValidationValidator)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDialog>(7);
                __builder2.AddAttribute(8, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(9);
                    __builder3.AddAttribute(10, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(12);
                        __builder4.AddAttribute(13, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                    Icons.Material.Filled.VerifiedUser

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "Class", "mr-3 mb-n1");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n                    ");
                        __builder4.AddContent(16, 
#nullable restore
#line 8 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                     localizer["Register User"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(17, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_0(__builder3, 18, 19, 
#nullable restore
#line 13 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.UserName

#line default
#line hidden
#nullable disable
                    , 20, 
#nullable restore
#line 13 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                     localizer["User Name"]

#line default
#line hidden
#nullable disable
                    , 21, 
#nullable restore
#line 13 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                 registerUserModel.UserName

#line default
#line hidden
#nullable disable
                    , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.UserName = __value, registerUserModel.UserName)));
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_1(__builder3, 24, 25, 
#nullable restore
#line 14 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.FirstName

#line default
#line hidden
#nullable disable
                    , 26, 
#nullable restore
#line 14 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                       localizer["First Name"]

#line default
#line hidden
#nullable disable
                    , 27, 
#nullable restore
#line 14 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                  registerUserModel.FirstName

#line default
#line hidden
#nullable disable
                    , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.FirstName = __value, registerUserModel.FirstName)));
                    __builder3.AddMarkupContent(29, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_2(__builder3, 30, 31, 
#nullable restore
#line 15 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.LastName

#line default
#line hidden
#nullable disable
                    , 32, 
#nullable restore
#line 15 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                     localizer["Last Name"]

#line default
#line hidden
#nullable disable
                    , 33, 
#nullable restore
#line 15 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                 registerUserModel.LastName

#line default
#line hidden
#nullable disable
                    , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.LastName = __value, registerUserModel.LastName)));
                    __builder3.AddMarkupContent(35, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_3(__builder3, 36, 37, 
#nullable restore
#line 16 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.Email

#line default
#line hidden
#nullable disable
                    , 38, 
#nullable restore
#line 16 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                            InputType.Email

#line default
#line hidden
#nullable disable
                    , 39, 
#nullable restore
#line 16 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                           localizer["Email"]

#line default
#line hidden
#nullable disable
                    , 40, 
#nullable restore
#line 16 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                          registerUserModel.Email

#line default
#line hidden
#nullable disable
                    , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.Email = __value, registerUserModel.Email)));
                    __builder3.AddMarkupContent(42, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_4(__builder3, 43, 44, 
#nullable restore
#line 17 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.PhoneNumber

#line default
#line hidden
#nullable disable
                    , 45, 
#nullable restore
#line 17 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                           localizer["Phone Number"]

#line default
#line hidden
#nullable disable
                    , 46, 
#nullable restore
#line 17 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                    registerUserModel.PhoneNumber

#line default
#line hidden
#nullable disable
                    , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.PhoneNumber = __value, registerUserModel.PhoneNumber)));
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_5(__builder3, 49, 50, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.Password

#line default
#line hidden
#nullable disable
                    , 51, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                PasswordInput

#line default
#line hidden
#nullable disable
                    , 52, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                          Adornment.End

#line default
#line hidden
#nullable disable
                    , 53, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                         PasswordInputIcon

#line default
#line hidden
#nullable disable
                    , 54, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                                                              TogglePasswordVisibility

#line default
#line hidden
#nullable disable
                    ), 55, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                                                                                                                                         localizer["Password"]

#line default
#line hidden
#nullable disable
                    , 56, 
#nullable restore
#line 18 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                                                                                                     registerUserModel.Password

#line default
#line hidden
#nullable disable
                    , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.Password = __value, registerUserModel.Password)));
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudTextField_6(__builder3, 59, 60, 
#nullable restore
#line 19 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                 () => registerUserModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                    , 61, 
#nullable restore
#line 19 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                      InputType.Password

#line default
#line hidden
#nullable disable
                    , 62, 
#nullable restore
#line 19 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                                                  localizer["Confirm Password"]

#line default
#line hidden
#nullable disable
                    , 63, 
#nullable restore
#line 19 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                       registerUserModel.ConfirmPassword

#line default
#line hidden
#nullable disable
                    , 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.ConfirmPassword = __value, registerUserModel.ConfirmPassword)));
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudCheckBox_7(__builder3, 66, 67, 
#nullable restore
#line 20 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                 localizer["Activate User?"]

#line default
#line hidden
#nullable disable
                    , 68, 
#nullable restore
#line 20 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                     Color.Primary

#line default
#line hidden
#nullable disable
                    , 69, 
#nullable restore
#line 20 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                         registerUserModel.ActivateUser

#line default
#line hidden
#nullable disable
                    , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.ActivateUser = __value, registerUserModel.ActivateUser)));
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __Blazor.LLC.Client.Pages.Identity.RegisterUserModal.TypeInference.CreateMudCheckBox_8(__builder3, 72, 73, 
#nullable restore
#line 21 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                     localizer["Auto Confirm Email?"]

#line default
#line hidden
#nullable disable
                    , 74, 
#nullable restore
#line 21 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                              Color.Primary

#line default
#line hidden
#nullable disable
                    , 75, 
#nullable restore
#line 21 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                         registerUserModel.AutoConfirmEmail

#line default
#line hidden
#nullable disable
                    , 76, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => registerUserModel.AutoConfirmEmail = __value, registerUserModel.AutoConfirmEmail)));
                }
                ));
                __builder2.AddAttribute(77, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(78);
                    __builder3.AddAttribute(79, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 24 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                         Cancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(82, 
#nullable restore
#line 24 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                  localizer["Cancel"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.OpenComponent<MudBlazor.MudButton>(83);
                    __builder3.AddAttribute(84, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                               !validated

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(87, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                   Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(89, 
#nullable restore
#line 26 "C:\Users\silco\Documents\LLC\LLC\LLC\Client\Pages\Identity\RegisterUserModal.razor"
                                                                                                                                   localizer["Register"]

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
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
namespace __Blazor.LLC.Client.Pages.Identity.RegisterUserModal
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::MudBlazor.InputType __arg1, int __seq2, global::System.String __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::MudBlazor.InputType __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs> __arg4, int __seq5, global::System.String __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentIcon", __arg3);
        __builder.AddAttribute(__seq4, "OnAdornmentClick", __arg4);
        __builder.AddAttribute(__seq5, "Label", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::MudBlazor.InputType __arg1, int __seq2, global::System.String __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "InputType", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudCheckBox_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Color __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Color", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudCheckBox_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Color __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Color", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591