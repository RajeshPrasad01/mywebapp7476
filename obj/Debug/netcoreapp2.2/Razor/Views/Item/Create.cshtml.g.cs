#pragma checksum "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d52eda14a3b9ed96971e081c731c1975520f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Create), @"mvc.1.0.view", @"/Views/Item/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Create.cshtml", typeof(AspNetCore.Views_Item_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91d52eda14a3b9ed96971e081c731c1975520f40", @"/Views/Item/Create.cshtml")]
    public class Views_Item_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<myWebApp7475.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundles/jqueryval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(120, 67, true);
            WriteLiteral("\r\n<p></p>\r\n<p></p>\r\n<p></p>\r\n<h2>Create a new To-Do Item</h2>\r\n\r\n\r\n");
            EndContext();
#line 14 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(222, 23, false);
#line 16 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(249, 59, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(309, 64, false);
#line 20 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(373, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(422, 93, false);
#line 22 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(515, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(571, 93, false);
#line 24 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(664, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(683, 82, false);
#line 25 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(765, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(852, 100, false);
#line 30 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
       Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(952, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1008, 100, false);
#line 32 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
           Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1127, 89, false);
#line 33 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1303, 98, false);
#line 38 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
       Write(Html.LabelFor(model => model.Completed, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 99, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <div class=\"checkbox\">\r\n                    ");
            EndContext();
            BeginContext(1501, 40, false);
#line 41 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
               Write(Html.EditorFor(model => model.Completed));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1564, 87, false);
#line 42 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Completed, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1651, 279, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 53 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1933, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1947, 40, false);
#line 56 "F:\Exam\A301\3 - Practice\WebApp\myWebApp7475\Views\Item\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(1997, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91d52eda14a3b9ed96971e081c731c1975520f409339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
