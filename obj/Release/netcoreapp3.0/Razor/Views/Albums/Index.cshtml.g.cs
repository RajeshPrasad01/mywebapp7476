#pragma checksum "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306348955dfb8e2c8dc3f24914618fbfd116c004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306348955dfb8e2c8dc3f24914618fbfd116c004", @"/Views/Albums/Index.cshtml")]
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<myWebApp7475.Models.Album>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br/>\r\n");
#nullable restore
#line 4 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
  
    ViewData["Title"] = "My Sql Page";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>MySql Page</h2>\r\n\r\n<br/>\r\n\r\n<table class=\"table table-hover table-responsive\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.emp_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.first_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.hire_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dept_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dept_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.emp_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.first_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.hire_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.dept_no));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.dept_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 78 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Albums\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<myWebApp7475.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
