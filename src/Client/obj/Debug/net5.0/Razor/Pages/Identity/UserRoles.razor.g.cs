#pragma checksum "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f9b8c61801aaeb49b05e9c7fae5b26d962c0b29"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client.Pages.Identity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 4 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
using WarehouseManger.Application.Responses.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Repo\Git Code\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
           [Authorize(Policy = Permissions.Roles.View)]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/identity/user-roles/{Id}")]
    public partial class UserRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WarehouseManger.Client.Shared.Components.HeroTitle>(0);
            __builder.AddAttribute(1, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                   Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Description", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                        Description

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
 if (!_loaded)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressCircular>(3);
            __builder.AddAttribute(4, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Indeterminate", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudTable_0(__builder, 6, 7, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                     true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                      25

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                 UserRolesList

#line default
#line hidden
#nullable disable
            , 10, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                        _dense

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                           _bordered

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                _striped

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                                  new Func<UserRoleModel, bool>(Search)

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 14 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                                                                                         _userRole

#line default
#line hidden
#nullable disable
            , 15, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _userRole = __value, _userRole), 16, (__builder2) => {
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "justify-center mud-text-align-center");
#nullable restore
#line 17 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                 if (_canEditUsers)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudButton>(19);
                __builder2.AddAttribute(20, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                        Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Class", "ml-auto");
                __builder2.AddAttribute(23, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                       SaveAsync

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ButtonType", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                              ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 19 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder3.AddContent(26, _localizer["Update User Roles"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudToolBarSpacer>(28);
                __builder2.CloseComponent();
#nullable restore
#line 23 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
             if (_canSearchRoles)
            {

#line default
#line hidden
#nullable disable
                __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudTextField_1(__builder2, 29, 30, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                , 31, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                     false

#line default
#line hidden
#nullable disable
                , 32, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                         _localizer["Search For User Roles"]

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                                                         Adornment.End

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                                                                                        Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 35, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                                                                                                                                Size.Medium

#line default
#line hidden
#nullable disable
                , 36, "mt-0 mb-3", 37, 
#nullable restore
#line 25 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                           _searchString

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _searchString = __value, _searchString)));
#nullable restore
#line 26 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
            }

#line default
#line hidden
#nullable disable
            }
            , 39, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(40);
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudTableSortLabel_2(__builder3, 42, 43, 
#nullable restore
#line 29 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                              new Func<UserRoleModel, object>(x => x.RoleName)

#line default
#line hidden
#nullable disable
                    , 44, (__builder4) => {
#nullable restore
#line 29 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder4.AddContent(45, _localizer["Role Name"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudTableSortLabel_3(__builder3, 49, 50, 
#nullable restore
#line 30 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                              new Func<UserRoleModel, object>(x => x.RoleDescription)

#line default
#line hidden
#nullable disable
                    , 51, (__builder4) => {
#nullable restore
#line 30 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder4.AddContent(52, _localizer["Description"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTh>(54);
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudTableSortLabel_4(__builder3, 56, 57, 
#nullable restore
#line 31 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                              new Func<UserRoleModel, object>(x => x.Selected)

#line default
#line hidden
#nullable disable
                    , 58, (__builder4) => {
#nullable restore
#line 31 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder4.AddContent(59, _localizer["Status"]);

#line default
#line hidden
#nullable disable
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            , 60, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(61);
                __builder2.AddAttribute(62, "DataLabel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                               _localizer["Role Name"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudHighlighter>(64);
                    __builder3.AddAttribute(65, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                       context.RoleName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "HighlightedText", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                           _searchString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(68);
                __builder2.AddAttribute(69, "DataLabel", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                               _localizer["Description"]

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudHighlighter>(71);
                    __builder3.AddAttribute(72, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                       context.RoleDescription

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "HighlightedText", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                  _searchString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n            ");
                __builder2.OpenComponent<MudBlazor.MudTd>(75);
                __builder2.AddAttribute(76, "DataLabel", "Role");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudCheckBox_5(__builder3, 78, 79, 
#nullable restore
#line 40 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                               !_canEditUsers

#line default
#line hidden
#nullable disable
                    , 80, 
#nullable restore
#line 40 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                                                                       Color.Secondary

#line default
#line hidden
#nullable disable
                    , 81, 
#nullable restore
#line 40 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                                 context.Selected

#line default
#line hidden
#nullable disable
                    , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Selected = __value, context.Selected)));
                }
                ));
                __builder2.CloseComponent();
            }
            , 83, (__builder2) => {
                __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudSwitch_6(__builder2, 84, 85, 
#nullable restore
#line 43 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                      Color.Secondary

#line default
#line hidden
#nullable disable
                , 86, "margin-left: 5px;", 87, 
#nullable restore
#line 43 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                       _dense

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dense = __value, _dense)), 89, (__builder3) => {
#nullable restore
#line 43 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder3.AddContent(90, _localizer["Dense"]);

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(91, "\r\n            ");
                __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudSwitch_7(__builder2, 92, 93, 
#nullable restore
#line 44 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                        Color.Tertiary

#line default
#line hidden
#nullable disable
                , 94, "margin-left: 5px;", 95, 
#nullable restore
#line 44 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                       _striped

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _striped = __value, _striped)), 97, (__builder3) => {
#nullable restore
#line 44 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder3.AddContent(98, _localizer["Striped"]);

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(99, "\r\n            ");
                __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles.TypeInference.CreateMudSwitch_8(__builder2, 100, 101, 
#nullable restore
#line 45 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                                         Color.Warning

#line default
#line hidden
#nullable disable
                , 102, "margin-left: 5px;", 103, 
#nullable restore
#line 45 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
                                       _bordered

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _bordered = __value, _bordered)), 105, (__builder3) => {
#nullable restore
#line 45 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
__builder3.AddContent(106, _localizer["Bordered"]);

#line default
#line hidden
#nullable disable
                }
                );
            }
            , 107, (__builder2) => {
                __builder2.OpenComponent<WarehouseManger.Client.Shared.Components.TablePager>(108);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 51 "D:\Repo\Git Code\src\Client\Pages\Identity\UserRoles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<UserRoles> _localizer { get; set; }
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
namespace __Blazor.WarehouseManger.Client.Pages.Identity.UserRoles
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, global::System.Collections.Generic.IEnumerable<T> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Func<T, global::System.Boolean> __arg6, int __seq7, System.Object __arg7, int __seq8, System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment __arg13)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Hover", __arg0);
        __builder.AddAttribute(__seq1, "Elevation", __arg1);
        __builder.AddAttribute(__seq2, "Items", __arg2);
        __builder.AddAttribute(__seq3, "Dense", __arg3);
        __builder.AddAttribute(__seq4, "Bordered", __arg4);
        __builder.AddAttribute(__seq5, "Striped", __arg5);
        __builder.AddAttribute(__seq6, "Filter", __arg6);
        __builder.AddAttribute(__seq7, "userRole", __arg7);
        __builder.AddAttribute(__seq8, "userRoleChanged", __arg8);
        __builder.AddAttribute(__seq9, "ToolBarContent", __arg9);
        __builder.AddAttribute(__seq10, "HeaderContent", __arg10);
        __builder.AddAttribute(__seq11, "RowTemplate", __arg11);
        __builder.AddAttribute(__seq12, "FooterContent", __arg12);
        __builder.AddAttribute(__seq13, "PagerContent", __arg13);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Adornment __arg3, int __seq4, global::System.String __arg4, int __seq5, global::MudBlazor.Size __arg5, int __seq6, global::System.String __arg6, int __seq7, T __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Immediate", __arg0);
        __builder.AddAttribute(__seq1, "FullWidth", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Adornment", __arg3);
        __builder.AddAttribute(__seq4, "AdornmentIcon", __arg4);
        __builder.AddAttribute(__seq5, "IconSize", __arg5);
        __builder.AddAttribute(__seq6, "Class", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudTableSortLabel_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<T, global::System.Object> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTableSortLabel<T>>(seq);
        __builder.AddAttribute(__seq0, "SortBy", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudCheckBox_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::MudBlazor.Color __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudCheckBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Disabled", __arg0);
        __builder.AddAttribute(__seq1, "Color", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudSwitch_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Color __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudSwitch<T>>(seq);
        __builder.AddAttribute(__seq0, "Color", __arg0);
        __builder.AddAttribute(__seq1, "Style", __arg1);
        __builder.AddAttribute(__seq2, "Checked", __arg2);
        __builder.AddAttribute(__seq3, "CheckedChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
