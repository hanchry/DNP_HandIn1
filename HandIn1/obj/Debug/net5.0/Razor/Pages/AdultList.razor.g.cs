#pragma checksum "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5c185e49486fb2b95ec45e4c6552b89dff17fa0"
// <auto-generated/>
#pragma warning disable 1591
namespace HandIn1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\_Imports.razor"
using HandIn1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
using HandIn1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
           [Authorize(Policy = "MustBeLoggedIn")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AdultList</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by first name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                                                         (arg) => FindByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
 if (toShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p>no adults found</p>");
#nullable restore
#line 18 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead class=\"table-primary\"><tr><th>Id</th>\r\n            <th>FirstName</th>\r\n            <th>LastName</th>\r\n            <th>Age</th>\r\n            <th>Sex</th>\r\n            <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 34 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
         foreach (var item in toShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 37 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 38 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 39 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 40 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 41 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                                                     () => NavigateToAdultView(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "  |\r\n                ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
                                                    () => DeleteAdult(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\Semester3\DNP31Y\DNP_HandIn1\HandIn1\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReader fileReader { get; set; }
    }
}
#pragma warning restore 1591
