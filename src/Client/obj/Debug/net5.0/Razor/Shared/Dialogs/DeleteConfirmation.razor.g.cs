#pragma checksum "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3269262e897e86fabba6cb2cd61a8ee0b755c058"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client.Shared.Dialogs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\Repo\Git Code\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repo\Git Code\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Repo\Git Code\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Repo\Git Code\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Repo\Git Code\src\Client\_Imports.razor"
using WarehouseManger.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Repo\Git Code\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class DeleteConfirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "TitleContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(2);
                __builder2.AddAttribute(3, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 5 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIcon>(5);
                    __builder3.AddAttribute(6, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                            Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "Class", "mr-3 mb-n1");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(8, "\r\n            ");
#nullable restore
#line 7 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(9, localizer["Delete Confirmation"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 11 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(13, ContentText);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(14, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(15);
                __builder2.AddAttribute(16, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(18, localizer["Cancel"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(20);
                __builder2.AddAttribute(21, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                          Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 15 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                                                Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
                                                                         Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 15 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
__builder3.AddContent(25, localizer["Confirm"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Repo\Git Code\src\Client\Shared\Dialogs\DeleteConfirmation.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    [Parameter] public string ContentText { get; set; }

    void Submit()
    {
        MudDialog.Close(DialogResult.Ok(true));
    }
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<DeleteConfirmation> localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
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
