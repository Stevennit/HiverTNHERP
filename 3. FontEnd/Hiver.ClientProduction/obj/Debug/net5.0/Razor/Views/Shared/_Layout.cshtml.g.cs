#pragma checksum "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a57c152aa75a8272ee9732c22a351e2d39dde6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\_ViewImports.cshtml"
using Hiver.ClientProduction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\_ViewImports.cshtml"
using Hiver.ClientProduction.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a57c152aa75a8272ee9732c22a351e2d39dde6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7588759bbf82770a1700d3d698115b402fd837bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Custom/fontawesome.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a57c152aa75a8272ee9732c22a351e2d39dde63837", async() => {
                WriteLiteral(@"
    <meta http-equiv=""content-type"" content=""text/html;charset=UTF-8"" />
    <meta charset=""utf-8"" />
    <title>Pages - Admin Dashboard UI Kit - Blank Page</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no, shrink-to-fit=no"" />
    <link rel=""apple-touch-icon"" href=""pages/ico/60.png"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""pages/ico/76.png"">
    <link rel=""apple-touch-icon"" sizes=""120x120"" href=""pages/ico/120.png"">
    <link rel=""apple-touch-icon"" sizes=""152x152"" href=""pages/ico/152.png"">
    <link rel=""icon"" type=""image/x-icon"" href=""favicon.ico"" />
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-touch-fullscreen"" content=""yes"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""default"">
    <meta content=""Meet pages - The simplest and fastest way to build web UI for your dashboard or app."" name=""description"" />
    <meta content=""Ace"" name=""author"" />

    <!--");
                WriteLiteral(" Telerik -->\r\n    <script src=\"../Custom/Telerik/jquery.min.js\"></script>\r\n    <script src=\"../Custom/Telerik/kendo.all.min.js\"></script>\r\n    <script src=\"../Custom/Telerik/kendo.aspnetmvc.min.js\"></script>\r\n\r\n    <!-- Arctic Admin Template -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a57c152aa75a8272ee9732c22a351e2d39dde65478", async() => {
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
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""../Arctic/assets/css/vendors.bundle.min.css"" />
    <link href=""../Arctic/github.min.css"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""../Arctic/assets/css/main.bundle.min.css"" />

    <!-- Hiver Custom -->
    <link href=""../Custom/Hiver.css"" rel=""stylesheet"" />


");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a57c152aa75a8272ee9732c22a351e2d39dde67611", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"app-admin-wrap-layout-1 sidebar-full sidebar-theme-slate\">\r\n        ");
#nullable restore
#line 39 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("_SideBar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"main-content-wrap\">\r\n            ");
#nullable restore
#line 41 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("_Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <!-- Start:: content body-->\r\n            <div class=\"main-content-body\">\r\n                <div class=\"container-fluid pt-2\">\r\n                    ");
#nullable restore
#line 45 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <!-- Start:: content (Your custom content)-->
                <!-- Start:: Footer-->
                <div class=""flex-grow-1""></div>
                <div class=""bg-card px-lg py-md d-flex justify-content-between align-items-center flex-wrap shadow-6dp"">
                    <p class=""text-muted m-0"">TNH ERP System by Steven Version 2021</p>
                </div>
                <!-- End:: Footer-->
            </div>
            <!-- End:: content body-->
        </div>
    </div>
    <!--begin::sidebar-panel-notification-->
    ");
#nullable restore
#line 59 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_Notification.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--end::sidebar-panel-notification-->\r\n    <!--Sidebar panel Profile-->\r\n    ");
#nullable restore
#line 62 "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_Profile.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""ul-sidebar-panel-overlay""></div>

    <!-- BEGIN VENDOR JS -->
    <script src=""../Arctic/assets/js/vendors.bundle.min.js""></script>
    <script src=""../Arctic/assets/js/main.bundle.min.js""></script>
    <script src=""../Arctic/highlight.min.js""></script>
    <script src=""../Arctic/assets/js/pages/doc.script.min.js""></script>
    <!-- END PAGE LEVEL JS -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
