#pragma checksum "D:\Project Code\HiverTNHERP\3. FontEnd\Hiver.ClientProduction\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5c005a690d6bb4bbbb9641e8dd27fe86bff7d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c005a690d6bb4bbbb9641e8dd27fe86bff7d75", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7588759bbf82770a1700d3d698115b402fd837bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Start::Mobile header-->\r\n<div class=\"ul-mobile-top-header bg-slate\">\r\n    <img class=\"ul-brand-mobile\" src=\"../Arctic/assets/images/arctic-admin-circle.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 161, "\"", 167, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <div class=""flex-grow-1""></div>
    <button class=""sidebar-full-toggle btn btn-icon btn-primary rounded-circle text-white""><i class=""material-icons"">menu</i></button>
    <button class=""btn btn-icon ul-header-menu-toggle btn-icon btn-primary rounded-circle text-white""><i class=""material-icons"">more_vert</i></button><i class=""material-icons text-white ul-mobile-header-toggle"">more_horiz</i>
</div>
<!-- End::Mobile header  -->
<!-- Start::Main header  -->
<header class=""main-header bg-card d-flex flex-row justify-content-between align-items-center px-lg"">
    <!-- Start::Header menu-->
    <div>
        <div class=""ul-header-menu-wrap"">
            <i class=""material-icons ul-header-menu-toggle"">close</i>
            <div class=""ul-header-menu"">
                <ul class=""ul-header-nav"">
                    <li class=""ul-menu-item""><a class=""ul-menu-link"" href=""#"">BẢNG ĐIỀU KHIỂN</a></li>
                    <li class=""ul-menu-item""><a class=""ul-menu-link"" href=""#"">CRM</a></li>
         ");
            WriteLiteral(@"           <li class=""ul-menu-item""><a class=""ul-menu-link"" href=""#"">TÀI CHÍNH</a></li>
                    <li class=""ul-menu-item ul-menu-item--active""><a class=""ul-menu-link"" href=""#"">SẢN XUẤT</a></li>
                    <li class=""ul-menu-item""><a class=""ul-menu-link"" href=""#"">HR</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- End::Header menu-->
    <div class=""ul-header-topbar"">
        <div class=""flex-grow-1""></div>
        <button class=""btn btn-opacity-default rounded-circle btn-icon btn-badge"" data-sidebar-panel=""asideNotification"">
            <span class=""badge badge-danger"">3</span>
            <i class=""material-icons"">notifications</i>
        </button>
      
        <div class=""dropdown profile-dropdown ml-xs"">
            <div class=""header-btn-group"">
                <button class=""btn d-flex py-1 pl-2 pr-0 rounded"" id=""dropdownTopUserProfile"" type=""button"" data-sidebar-panel=""asideProfile"">
                    <span class=""m-0 mr-2 f");
            WriteLiteral(@"ont-weight-normal"">Hi, Nguyễn Hoài Nam Nam</span>
                    <img class=""avatar-sm rounded-circle mr-1"" src=""../Arctic/assets/images/faces/1.jpg"" />
                </button>

            </div>
        </div>
    </div>
</header>
<!-- End::Main header-->");
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
