#pragma checksum "D:\Repo\Git Code\src\Client\Shared\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308f8f6c3801f6f42a03bb306b650825a0d757e6"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client.Shared
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
#line 1 "D:\Repo\Git Code\src\Client\Shared\Error.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Repo\Git Code\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.WarehouseManger.Client.Shared.Error.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 4 "D:\Repo\Git Code\src\Client\Shared\Error.razor"
                      this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
#nullable restore
#line 5 "D:\Repo\Git Code\src\Client\Shared\Error.razor"
__builder2.AddContent(3, ChildContent);

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Repo\Git Code\src\Client\Shared\Error.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public void ProcessError(Exception ex)
    {
        Logger.LogError("Error:ProcessError - Type: {Type} Message: {Message}",
            ex.GetType(), ex.Message);
        //StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Error> Logger { get; set; }
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
namespace __Blazor.WarehouseManger.Client.Shared.Error
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591