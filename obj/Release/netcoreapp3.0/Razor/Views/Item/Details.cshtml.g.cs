#pragma checksum "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00173c3aa5408b4632ec29e319935f979b18dd09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Details), @"mvc.1.0.view", @"/Views/Item/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00173c3aa5408b4632ec29e319935f979b18dd09", @"/Views/Item/Details.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<myWebApp7475.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
  
    ViewBag.Title = "List of To-Do Items";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p></p>\r\n<p></p>\r\n<p></p>\r\n\r\n<h2>View To-Do Item Details</h2>\r\n\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 19 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 31 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 35 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 39 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
       Write(Html.DisplayFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 45 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 46 "F:\Exam\A301\3 - Practice\Generic\webApps\myWebApp7475\Views\Item\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<myWebApp7475.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
