#pragma checksum "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\newCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed160f9d6c4a6ecfff68e8e4684e18a5f7e0bc43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_newCart), @"mvc.1.0.view", @"/Views/ShoppingCart/newCart.cshtml")]
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
#line 1 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed160f9d6c4a6ecfff68e8e4684e18a5f7e0bc43", @"/Views/ShoppingCart/newCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_newCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cartCss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\newCart.cshtml"
  
    ViewData["Title"] = "newCart";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>newCart</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed160f9d6c4a6ecfff68e8e4684e18a5f7e0bc434268", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed160f9d6c4a6ecfff68e8e4684e18a5f7e0bc434530", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            WriteLiteral(@"
<div class=""container"">
    <div class=""heading"">
        <h1>
            <span class=""shopper"">s</span> Shopping Cart
        </h1>

        <a href=""#"" class=""visibility-cart transition is-open"">X</a>
    </div>

    <div class=""cart transition is-open"">

        <a href=""#"" class=""btn btn-update"">Update cart</a>


        <div class=""table"">

            <div class=""layout-inline row th"">
                <div class=""col col-pro"">Product</div>
                <div class=""col col-price align-center "">
                    Price
                </div>
                <div class=""col col-qty align-center"">QTY</div>
                <div class=""col"">VAT</div>
                <div class=""col"">Total</div>
            </div>

            <div class=""layout-inline row"">

                <div class=""col col-pro layout-inline"">
                    <img src=""http://static.ddmcdn.com/gif/10-kitten-cuteness-1.jpg"" alt=""kitten"" />
                    <p>Happy Little Critter</p>
           ");
            WriteLiteral(@"     </div>

                <div class=""col col-price col-numeric align-center "">
                    <p>£59.99</p>
                </div>

                <div class=""col col-qty layout-inline"">
                    <a href=""#"" class=""qty qty-minus"">-</a>
                    <input type=""numeric"" value=""3"" />
                    <a href=""#"" class=""qty qty-plus"">+</a>
                </div>

                <div class=""col col-vat col-numeric"">
                    <p>£2.95</p>
                </div>
                <div class=""col col-total col-numeric"">
                    <p> £182.95</p>
                </div>
            </div>

            <div class=""layout-inline row row-bg2"">

                <div class=""col col-pro layout-inline"">
                    <img src=""http://lovemeow.com/wp-content/uploads/2012/05/kitten81.jpg"" alt=""kitten"" />
                    <p>Scared Little Kittie</p>
                </div>

                <div class=""col col-price col-numeric align-center "">");
            WriteLiteral(@"
                    <p>£23.99</p>
                </div>

                <div class=""col col-qty  layout-inline"">
                    <a href=""#"" class=""qty qty-minus "">-</a>
                    <input type=""numeric"" value=""1"" />
                    <a href=""#"" class=""qty qty-plus"">+</a>
                </div>

                <div class=""col col-vat col-numeric"">
                    <p>£1.95</p>
                </div>
                <div class=""col col-total col-numeric"">
                    <p>£25.94</p>
                </div>

            </div>

            <div class=""layout-inline row"">

                <div class=""col col-pro layout-inline"">
                    <img src=""http://cdn.cutestpaw.com/wp-content/uploads/2012/04/l-my-first-kitten.jpg"" alt=""kitten"" />
                    <p>Curious Little Begger</p>
                </div>

                <div class=""col col-price col-numeric align-center "">
                    <p>£59.99</p>
                </div>

            ");
            WriteLiteral(@"    <div class=""col col-qty layout-inline"">
                    <a href=""#"" class=""qty qty-minus"">-</a>
                    <input type=""numeric"" value=""3"" />
                    <a href=""#"" class=""qty qty-plus"">+</a>
                </div>

                <div class=""col col-vat col-numeric"">
                    <p>£2.95</p>
                </div>
                <div class=""col col-total col-numeric"">
                    <p>£182.95</p>
                </div>
            </div>

            <div class=""tf"">
                <div class=""row layout-inline"">
                    <div class=""col"">
                        <p>VAT</p>
                    </div>
                    <div class=""col""></div>
                </div>
                <div class=""row layout-inline"">
                    <div class=""col"">
                        <p>Shipping</p>
                    </div>
                    <div class=""col""></div>
                </div>
                <div class=""row layout-inline"">");
            WriteLiteral(@"
                    <div class=""col"">
                        <p>Total</p>
                    </div>
                    <div class=""col""></div>
                </div>
            </div>
        </div>

        <a href=""#"" class=""btn btn-update"">Update cart</a>

    </div>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
