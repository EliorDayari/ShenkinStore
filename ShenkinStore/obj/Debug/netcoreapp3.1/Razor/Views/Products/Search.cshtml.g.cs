#pragma checksum "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a01e3ab94b3c687a15243cc7921e2ecc4a8e2760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Search), @"mvc.1.0.view", @"/Views/Products/Search.cshtml")]
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
#nullable restore
#line 1 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a01e3ab94b3c687a15243cc7921e2ecc4a8e2760", @"/Views/Products/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShenkinStore.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 12 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 15 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 18 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Colorr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 21 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.productType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 24 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.productBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 27 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 30 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Metrial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1342, "\"", 1375, 1);
#nullable restore
#line 39 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
WriteAttributeValue("", 1348, Url.Content(item.ImageUrl), 1348, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cant display\" width=\"180px\" height=\"180px\" />\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Products\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        }\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShenkinStore.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591