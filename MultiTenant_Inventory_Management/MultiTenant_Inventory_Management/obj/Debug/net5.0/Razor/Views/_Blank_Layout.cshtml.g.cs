#pragma checksum "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb7490d482448975a5b43a5fe412cdc02efbacf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Blank_Layout), @"mvc.1.0.view", @"/Views/_Blank_Layout.cshtml")]
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
#nullable restore
#line 1 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_ViewImports.cshtml"
using MultiTenant_Inventory_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_ViewImports.cshtml"
using MultiTenant_Inventory_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb7490d482448975a5b43a5fe412cdc02efbacf", @"/Views/_Blank_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712451c4eb3000fa1db05f459c7693ee8504bb44", @"/Views/_ViewImports.cshtml")]
    public class Views__Blank_Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sidebar", new global::Microsoft.AspNetCore.Html.HtmlString("dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb7490d482448975a5b43a5fe412cdc02efbacf3875", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_title_meta.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
Write(RenderSection("styles", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/_head_css.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb7490d482448975a5b43a5fe412cdc02efbacf5850", async() => {
                WriteLiteral(@"
    <!-- Begin Page -->
    <div id=""layout-wrapper"">


        <!-- ============================================================== -->
        <!-- Start right Content here -->
        <!-- ============================================================== -->

        ");
#nullable restore
#line 17 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_page_title.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 18 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/_footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 23 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
Write(RenderSection("externalhtml", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    <!-- END layout-wrapper -->\r\n");
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 30 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\_Blank_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
