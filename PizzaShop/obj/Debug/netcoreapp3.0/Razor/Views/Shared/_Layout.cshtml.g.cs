#pragma checksum "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0351b60c2fd0217c3281952bd0ae35bb1f38868"
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
#line 1 "N:\PizzaShop\Pizzeria\PizzaShop\Views\_ViewImports.cshtml"
using PizzaShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\PizzaShop\Pizzeria\PizzaShop\Views\_ViewImports.cshtml"
using PizzaShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0351b60c2fd0217c3281952bd0ae35bb1f38868", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7291da6f97a63509141cf1c8a65b5e29c5982e22", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link dropdown-toggle active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f388686636", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""keywords"" content=""HTML5,CSS3,HTML,Template,multi-page,Restant - Takeway & Restaurant HTML Template"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet""");
                BeginWriteAttribute("href", " href=\"", 312, "\"", 365, 1);
#nullable restore
#line 9 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 319, Url.Content("~/assets/css/bootstrap.min.css"), 319, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <!-- Meanmenu CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 422, "\"", 470, 1);
#nullable restore
#line 11 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 429, Url.Content("~/assets/css/meanmenu.css"), 429, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Boxicons CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 529, "\"", 581, 1);
#nullable restore
#line 13 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 536, Url.Content("~/assets/css/boxicons.min.css"), 536, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Owl Carousel -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 640, "\"", 696, 1);
#nullable restore
#line 15 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 647, Url.Content("~/assets/css/owl.carousel.min.css"), 647, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 728, "\"", 789, 1);
#nullable restore
#line 16 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 735, Url.Content("~/assets/css/owl.theme.default.min.css"), 735, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Slick Slider CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 852, "\"", 897, 1);
#nullable restore
#line 18 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 859, Url.Content("~/assets/css/slick.css"), 859, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 929, "\"", 980, 1);
#nullable restore
#line 19 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 936, Url.Content("~/assets/css/slick-theme.css"), 936, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Magnific Popup CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1045, "\"", 1099, 1);
#nullable restore
#line 21 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1052, Url.Content("~/assets/css/magnific-popup.css"), 1052, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Style CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1155, "\"", 1200, 1);
#nullable restore
#line 23 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1162, Url.Content("~/assets/css/style.css"), 1162, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <!-- Responsive CSS -->\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1261, "\"", 1311, 1);
#nullable restore
#line 25 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1268, Url.Content("~/assets/css/responsive.css"), 1268, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <title></title>\r\n\r\n    <link rel=\"icon\" type=\"image/png\"");
                BeginWriteAttribute("href", " href=\"", 1379, "\"", 1426, 1);
#nullable restore
#line 29 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1386, Url.Content("~/assets/img/favicon.png"), 1386, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f3886812736", async() => {
                WriteLiteral(@"
    <!-- Preloader -->
    <div class=""loader"">
        <div class=""d-table"">
            <div class=""d-table-cell"">
                <div class=""spinner""></div>
            </div>
        </div>
    </div>
    <!-- End Preloader -->
    <!-- Start Navbar Area -->
    <div class=""navbar-area fixed-top"">
        <!-- Menu For Mobile Device -->
        <div class=""mobile-nav"">
            <a href=""index.html"" class=""logo"">
                <img");
                BeginWriteAttribute("src", " src=\"", 1909, "\"", 1956, 1);
#nullable restore
#line 47 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1915, Url.Content("~/assets/img/logo-two.png"), 1915, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            </a>
        </div>

        <!-- Menu For Desktop Device -->
        <div class=""main-nav"">
            <div class=""container"">
                <nav class=""navbar navbar-expand-md navbar-light"">
                    <a class=""navbar-brand"" href=""index.html"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 2269, "\"", 2313, 1);
#nullable restore
#line 56 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2275, Url.Content("~/assets/img/logo.png" ), 2275, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </a>
                    <div class=""collapse navbar-collapse mean-menu"" id=""navbarSupportedContent"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f3886814822", async() => {
                    WriteLiteral("Menu <i class=\'bx bx-chevron-down\'></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <ul class=\"dropdown-menu\">\r\n                                    <li class=\"nav-item\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f3886816545", async() => {
                    WriteLiteral("Pizza");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </li>\r\n\r\n                                </ul>\r\n                            </li>\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0351b60c2fd0217c3281952bd0ae35bb1f3886818224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            <li class=\"nav-item\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f3886819492", async() => {
                    WriteLiteral("Contact Us");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"side-nav\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0351b60c2fd0217c3281952bd0ae35bb1f3886821189", async() => {
                    WriteLiteral("\r\n                            <i class=\'bx bxs-cart\'></i>\r\n\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <a class=""nav-tel"" href=""tel:+989164890208"">
                            <i class='bx bxs-phone-call'></i>
                            +98-9164890208
                        </a>
                    </div>
                </nav>
            </div>
        </div>
    </div>
    <!-- End Navbar Area -->
    <!-- Bannner -->
    <div class=""banner-area-three"">

        <div class=""container"">

            <div class=""banner-content"">

                <div>
                    ");
#nullable restore
#line 100 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

            </div>

        </div>
    </div>
    <!-- End Bannner -->
    <!-- Copyright -->
    <div class=""copyright-area"">
        <div class=""container"">
            <div class=""copyright-item"">
                <p> All Rights Reserved ©</a></p>
            </div>
        </div>
    </div>
    <!-- End Copyright -->
    <!-- Essential JS -->
    <script");
                BeginWriteAttribute("src", " src=\"", 4534, "\"", 4587, 1);
#nullable restore
#line 118 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4540, Url.Content("~/assets/js/jquery-3.5.0.min.js"), 4540, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4611, "\"", 4658, 1);
#nullable restore
#line 119 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4617, Url.Content("~/assets/js/popper.min.js"), 4617, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4682, "\"", 4732, 1);
#nullable restore
#line 120 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4688, Url.Content("~/assets/js/bootstrap.min.js"), 4688, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Meanmenu JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4782, "\"", 4834, 1);
#nullable restore
#line 122 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4788, Url.Content("~/assets/js/jquery.meanmenu.js"), 4788, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Owl Carousel JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4888, "\"", 4941, 1);
#nullable restore
#line 124 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4894, Url.Content("~/assets/js/owl.carousel.min.js"), 4894, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Mixitup JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 4990, "\"", 5045, 1);
#nullable restore
#line 126 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4996, Url.Content("~/assets/js/jquery.mixitup.min.js"), 4996, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Slick Slider JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5099, "\"", 5145, 1);
#nullable restore
#line 128 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5105, Url.Content("~/assets/js/slick.min.js"), 5105, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Form Ajaxchimp JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5201, "\"", 5258, 1);
#nullable restore
#line 130 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5207, Url.Content("~/assets/js/jquery.ajaxchimp.min.js"), 5207, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Form Validator JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5314, "\"", 5369, 1);
#nullable restore
#line 132 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5320, Url.Content("~/assets/js/form-validator.min.js"), 5320, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Contact JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5418, "\"", 5474, 1);
#nullable restore
#line 134 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5424, Url.Content("~/assets/js/contact-form-script.js"), 5424, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Magnific Popup JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5530, "\"", 5592, 1);
#nullable restore
#line 136 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5536, Url.Content("~/assets/js/jquery.magnific-popup.min.js"), 5536, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <!-- Custom JS -->\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5640, "\"", 5683, 1);
#nullable restore
#line 138 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5646, Url.Content("~/assets/js/custom.js"), 5646, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n\r\n    ");
#nullable restore
#line 141 "N:\PizzaShop\Pizzeria\PizzaShop\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
