#pragma checksum "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db7f610e42a99cb3ded9d1776f2a0319ed0e411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Delete), @"mvc.1.0.view", @"/Views/Vendors/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db7f610e42a99cb3ded9d1776f2a0319ed0e411", @"/Views/Vendors/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712451c4eb3000fa1db05f459c7693ee8504bb44", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultiTenant_Inventory_Management.Models.Inventory.Vendor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-rounded waves-effect waves-light mb-2 mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    ViewBag.pTitle = "Delete";
    ViewBag.pageTitle = "Vendor";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row mb-2"">
                    <h3>Are you sure you want to delete this?</h3>
                    <div class=""col-sm-8"">
                        <div class=""text-sm-left"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db7f610e42a99cb3ded9d1776f2a0319ed0e4115828", async() => {
                WriteLiteral("<i class=\"mdi mdi-keyboard-return mr-1\"></i>Vendors");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <dl class=\"row\">\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 23 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.VendorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 26 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.VendorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 29 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 32 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Company));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 35 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 38 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 41 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.WorkPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 44 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.WorkPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 47 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Payables));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 50 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Payables));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                    </dl>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5db7f610e42a99cb3ded9d1776f2a0319ed0e41111910", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5db7f610e42a99cb3ded9d1776f2a0319ed0e41112193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 56 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\Storages\Desktop\Term Project\Web-II_Inventory_Management\MultiTenant_Inventory_Management\MultiTenant_Inventory_Management\Views\Vendors\Delete.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultiTenant_Inventory_Management.Models.Inventory.Vendor> Html { get; private set; }
    }
}
#pragma warning restore 1591