#pragma checksum "C:\Users\User\source\repos\Juan\WebUI\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "727d4a00a818d2bf31b8564689c04f31551e3651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Juan\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Juan\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Juan\WebUI\Views\_ViewImports.cshtml"
using WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727d4a00a818d2bf31b8564689c04f31551e3651", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231c60bbb11350c0039b3c2910ccf343635ac2f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("flag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/logo/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Brand Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- Start Header Area -->
<header class=""header-area"">
    <!-- main header start -->
    <div class=""main-header d-none d-lg-block"">
        <!-- header top start -->
        <div class=""header-top theme-bg"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-6"">
                        <div class=""welcome-message"">
                            <p>Welcome to Juan online store</p>
                        </div>
                    </div>
                    <div class=""col-lg-6 text-right"">
                        <div class=""header-top-settings"">
                            <ul class=""nav align-items-center justify-content-end"">
                                <li class=""curreny-wrap"">
                                    $ Dollar (US)
                                    <i class=""fa fa-angle-down""></i>
                                    <ul class=""dropdown-list curreny-list"">
                                ");
            WriteLiteral(@"        <li><a href=""#"">$ usd</a></li>
                                        <li><a href=""#""> ??? EURO</a></li>
                                    </ul>
                                </li>
                                <li class=""language"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727d4a00a818d2bf31b8564689c04f31551e36517127", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1356, "~/assets/img/icon/", 1356, 18, true);
#nullable restore
#line 27 "C:\Users\User\source\repos\Juan\WebUI\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 1374, Model["language_icon"], 1374, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" English
                                    <i class=""fa fa-angle-down""></i>
                                    <ul class=""dropdown-list"">
                                        <li>
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727d4a00a818d2bf31b8564689c04f31551e36519014", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1718, "~/assets/img/icon/", 1718, 18, true);
#nullable restore
#line 32 "C:\Users\User\source\repos\Juan\WebUI\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 1736, Model["english_icon"], 1736, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                english
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727d4a00a818d2bf31b8564689c04f31551e365110908", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2091, "~/assets/img/icon/", 2091, 18, true);
#nullable restore
#line 38 "C:\Users\User\source\repos\Juan\WebUI\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 2109, Model["french_icon"], 2109, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                french
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- header top end -->
        <!-- header middle area start -->
        <div class=""header-main-area sticky"">
            <div class=""container"">
                <div class=""row align-items-center position-relative"">
                    <!-- start logo area -->
                    <div class=""col-lg-2"">
                        <div class=""logo"">
                            <a href=""index.html"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727d4a00a818d2bf31b8564689c04f31551e365113345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2996, "~/assets/img/logo/", 2996, 18, true);
#nullable restore
#line 59 "C:\Users\User\source\repos\Juan\WebUI\Views\Shared\Components\Header\Default.cshtml"
AddHtmlAttributeValue("", 3014, Model["logo"], 3014, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                    </div>
                    <!-- start logo area -->
                    <!-- main menu area start -->
                    <div class=""col-lg-8 position-static"">
                        <div class=""main-menu-area"">
                            <div class=""main-menu"">
                                <!-- main menu navbar start -->
                                <nav class=""desktop-menu"">
                                    <ul>
                                        <li class=""active"">
                                            <a href=""index.html"">
                                                Home <i class=""fa fa-angle-down""></i>
                                            </a>
                                            <ul class=""dropdown"">
                                                <li><a href=""index.html"">Home version 01</a></li>
                                                <li><a href=""index");
            WriteLiteral(@"-2.html"">Home version 02</a></li>
                                            </ul>
                                        </li>
                                        <li class=""static"">
                                            <a href=""#"">pages <i class=""fa fa-angle-down""></i></a>
                                            <ul class=""megamenu dropdown"">
                                                <li class=""mega-title"">
                                                    <a href=""#"">column 01</a>
                                                    <ul>
                                                        <li>
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727d4a00a818d2bf31b8564689c04f31551e365116712", async() => {
                WriteLiteral("shop grid left sidebar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </li>
                                                        <li>
                                                            <a href=""shop-grid-right-sidebar.html"">shop grid right sidebar</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-list-left-sidebar.html"">shop list left sidebar</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-list-right-sidebar.html"">shop list right sidebar</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                                <li class=""mega-title"">
               ");
            WriteLiteral("                                     <a href=\"#\">column 02</a>\r\n                                                    <ul>\r\n                                                        <li>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727d4a00a818d2bf31b8564689c04f31551e365119402", async() => {
                WriteLiteral("product details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </li>
                                                        <li>
                                                            <a href=""product-details-affiliate.html"">product details affiliate</a>
                                                        </li>
                                                        <li>
                                                            <a href=""product-details-variable.html"">product details variable</a>
                                                        </li>
                                                        <li>
                                                            <a href=""product-details-group.html"">product details group</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                                <li class=""mega-title"">
           ");
            WriteLiteral(@"                                         <a href=""#"">column 03</a>
                                                    <ul>
                                                        <li><a href=""cart.html"">cart</a></li>
                                                        <li><a href=""checkout.html"">checkout</a></li>
                                                        <li><a href=""compare.html"">compare</a></li>
                                                        <li><a href=""wishlist.html"">wishlist</a></li>
                                                    </ul>
                                                </li>
                                                <li class=""mega-title"">
                                                    <a href=""#"">column 04</a>
                                                    <ul>
                                                        <li>
                                                            <a href=""my-account.html"">my-account</a>
        ");
            WriteLiteral(@"                                                </li>
                                                        <li>
                                                            <a href=""login-register.html"">login-register</a>
                                                        </li>
                                                        <li>
                                                            <a href=""contact-us.html"">contact us</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href=""shop.html"">
                                                shop <i class=""fa fa-angle-down""></i>
                                            </a>
                                            <u");
            WriteLiteral(@"l class=""dropdown"">
                                                <li>
                                                    <a href=""#"">
                                                        shop grid layout
                                                        <i class=""fa fa-angle-right""></i>
                                                    </a>
                                                    <ul class=""dropdown"">
                                                        <li>
                                                            <a href=""shop.html"">shop grid left sidebar</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-grid-right-sidebar.html"">shop grid right sidebar</a>
                                                        </li>
                                                        <li>
                                     ");
            WriteLiteral(@"                       <a href=""shop-grid-full-3-col.html"">shop grid full 3 col</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-grid-full-4-col.html"">shop grid full 4 col</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        shop list layout
                                                        <i class=""fa fa-angle-right""></i>
                                                    </a>
                                                    <ul class=""dropdown"">
                                                        <li>
                                   ");
            WriteLiteral(@"                         <a href=""shop-list-left-sidebar.html"">shop list left sidebar</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-list-right-sidebar.html"">shop list right sidebar</a>
                                                        </li>
                                                        <li>
                                                            <a href=""shop-list-full-width.html"">shop list full width</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                                <li>
                                                    <a href=""#"">
                                                        products details
                                                        <i cla");
            WriteLiteral(@"ss=""fa fa-angle-right""></i>
                                                    </a>
                                                    <ul class=""dropdown"">
                                                        <li>
                                                            <a href=""product-details.html"">product details</a>
                                                        </li>
                                                        <li>
                                                            <a href=""product-details-affiliate.html"">product details affiliate</a>
                                                        </li>
                                                        <li>
                                                            <a href=""product-details-variable.html"">product details variable</a>
                                                        </li>
                                                        <li>
                                                   ");
            WriteLiteral(@"         <a href=""product-details-group.html"">product details group</a>
                                                        </li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href=""blog-left-sidebar.html"">
                                                Blog <i class=""fa fa-angle-down""></i>
                                            </a>
                                            <ul class=""dropdown"">
                                                <li>
                                                    <a href=""blog-left-sidebar.html"">blog left sidebar</a>
                                                </li>
                                                <li>
                                                    <a href=""blog-right-side");
            WriteLiteral(@"bar.html"">blog right sidebar</a>
                                                </li>
                                                <li>
                                                    <a href=""blog-grid-full-width.html"">blog grid no sidebar</a>
                                                </li>
                                                <li>
                                                    <a href=""blog-details.html"">blog details</a>
                                                </li>
                                                <li>
                                                    <a href=""blog-details-audio.html"">blog details audio</a>
                                                </li>
                                                <li>
                                                    <a href=""blog-details-video.html"">blog details video</a>
                                                </li>
                                                <li>
             ");
            WriteLiteral(@"                                       <a href=""blog-details-left-sidebar.html"">blog details left sidebar</a>
                                                </li>
                                            </ul>
                                        </li>
                                        <li><a href=""contact-us.html"">Contact us</a></li>
                                    </ul>
                                </nav>
                                <!-- main menu navbar end -->
                            </div>
                        </div>
                    </div>
                    <!-- main menu area end -->
                    <!-- mini cart area start -->
                    <div class=""col-lg-2"">
                        <div class=""header-configure-wrapper"">
                            <div class=""header-configure-area"">
                                <ul class=""nav justify-content-end"">
                                    <li>
                                        <a");
            WriteLiteral(@" href=""#"" class=""offcanvas-btn"">
                                            <i class=""ion-ios-search-strong""></i>
                                        </a>
                                    </li>
                                    <li class=""user-hover"">
                                        <a href=""#"">
                                            <i class=""ion-ios-gear-outline""></i>
                                        </a>
                                        <ul class=""dropdown-list"">
                                            <li><a href=""login-register.html"">login</a></li>
                                            <li><a href=""login-register.html"">register</a></li>
                                            <li><a href=""my-account.html"">my account</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""minicart-btn"">
              ");
            WriteLiteral(@"                              <i class=""ion-bag""></i>
                                            <div class=""notification"">2</div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!-- mini cart area end -->
                </div>
            </div>
        </div>
        <!-- header middle area end -->
    </div>
    <!-- main header start -->
    <!-- mobile header start -->
    <div class=""mobile-header d-lg-none d-md-block sticky"">
        <!--mobile header top start -->
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-12"">
                    <div class=""mobile-main-header"">
                        <div class=""mobile-logo"">
                            <a href=""index.html"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727d4a00a818d2bf31b8564689c04f31551e365133529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </a>
                        </div>
                        <div class=""mobile-menu-toggler"">
                            <div class=""mini-cart-wrap"">
                                <a href=""cart.html"">
                                    <i class=""ion-bag""></i>
                                </a>
                            </div>
                            <div class=""mobile-menu-btn"">
                                <div class=""off-canvas-btn"">
                                    <i class=""ion-navicon""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- mobile header top start -->
    </div>
    <!-- mobile header end -->
</header>
<!-- end Header Area -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
