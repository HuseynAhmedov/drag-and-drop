#pragma checksum "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ed8928f4805cd0cceb227bdfd9107ca8dfa96c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TabMenu), @"mvc.1.0.view", @"/Views/Shared/_TabMenu.cshtml")]
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
#line 1 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\_ViewImports.cshtml"
using Pustok.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93ed8928f4805cd0cceb227bdfd9107ca8dfa96c", @"/Views/Shared/_TabMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7a7f344ca8ae7e50a71c974cb2607daf4defa6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TabMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""product-slider multiple-row  slider-border-multiple-row  sb-slick-slider""
     data-slick-setting='{
                                        ""autoplay"": true,
                                        ""autoplaySpeed"": 8000,
                                        ""slidesToShow"": 5,
                                        ""rows"":1,
                                        ""dots"":true
                                    }' data-slick-responsive='[
                                        {""breakpoint"":1200, ""settings"": {""slidesToShow"": 3} },
                                        {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                                        {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                                        {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
                                    ]'>

");
#nullable restore
#line 17 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
     foreach (Product item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"single-slide\">\r\n            <div class=\"product-card\">\r\n                <div class=\"product-header\">\r\n                    <a href=\"#\" class=\"author\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                   Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h3>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ed8928f4805cd0cceb227bdfd9107ca8dfa96c5680", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 27 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </h3>\r\n                </div>\r\n                <div class=\"product-card--body\">\r\n                    <div class=\"card-image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1564, "\"", 1650, 2);
            WriteAttributeValue("", 1570, "image/products/", 1570, 15, true);
#nullable restore
#line 33 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
WriteAttributeValue("", 1585, item.ProductImages.FirstOrDefault(x=>x.MainImage == true).Source, 1585, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1651, "\"", 1657, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"hover-contents\">\r\n                            <a href=\"product-details.html\" class=\"hover-image\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1832, "\"", 1919, 2);
            WriteAttributeValue("", 1838, "image/products/", 1838, 15, true);
#nullable restore
#line 36 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
WriteAttributeValue("", 1853, item.ProductImages.FirstOrDefault(x=>x.HoverImage == true).Source, 1853, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1920, "\"", 1926, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                            <div class=\"hover-btns\">\r\n                                <a href=\"#\" class=\"single-btn add-to-cart-btn\" data-id=\"");
#nullable restore
#line 39 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <i class=""fas fa-shopping-basket""></i>
                                </a>
                                <a href=""#"" class=""single-btn"">
                                    <i class=""fas fa-heart""></i>
                                </a>
                                <a href=""#"" class=""single-btn"">
                                    <i class=""fas fa-random""></i>
                                </a>
                                <a href=""#"" data-toggle=""modal"" data-id=""");
#nullable restore
#line 48 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   class=""single-btn single-eye-btn"">
                                    <i class=""fas fa-eye""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""price-block"">
                        <span class=""price"">£");
#nullable restore
#line 56 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                         if (item.PriceDiscount > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <del class=\"price-old\">£");
#nullable restore
#line 59 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                               Write(item.PriceOld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                            <span class=\"price-discount\">");
#nullable restore
#line 60 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                                                    Write(item.PriceDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 61 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 66 "C:\Users\Huseyn\source\repos\Pustok\Pustok\Views\Shared\_TabMenu.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
