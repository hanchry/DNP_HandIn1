#pragma checksum "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c835657409607213e6ae96c7add6c600e9acf2e"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
using HandIn1.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "form-group");
                __builder2.AddMarkupContent(4, "<label>User name:</label>\r\n            ");
                __builder2.OpenElement(5, "input");
                __builder2.AddAttribute(6, "type", "text");
                __builder2.AddAttribute(7, "placeholder", "user name");
                __builder2.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
                                                                    username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "password");
                __builder2.AddAttribute(16, "placeholder", "password");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "style", "color:red");
                __builder2.AddContent(22, 
#nullable restore
#line 18 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
                                  PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(27, "\r\n            Login\r\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(28, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "h3");
                __builder2.AddContent(30, 
#nullable restore
#line 25 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "href", "");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(35, "\r\n            Log out\r\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\hanch\OneDrive\Skola\semester3\DNP1\DNP1 programs\Session5\DNP_HandIn1\HandIn1\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
