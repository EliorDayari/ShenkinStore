#pragma checksum "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d880cc7b355045cf36fe479285a4b0abd059ffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GroupBy), @"mvc.1.0.view", @"/Views/Products/GroupBy.cshtml")]
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
#line 1 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d880cc7b355045cf36fe479285a4b0abd059ffd", @"/Views/Products/GroupBy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GroupBy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShenkinStore.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
  
    ViewData["Title"] = "GroupBy";
   // var query = Model.ToList().GroupBy(product=>product.productType, product => product.ProductName);



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 34 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
     foreach (var
TypeGroup in ViewBag.Query)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <thead>\r\n\r\n\r\n            <tr>\r\n");
            WriteLiteral("                <th>\r\n                   Product Type: ");
#nullable restore
#line 44 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
                            Write(TypeGroup.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </th>
                <th>
                    Product Name
                </th>

                <th>
                    Price
                </th>

                <th>
                    Image
                </th>

            </tr>
        </thead>
");
            WriteLiteral("        <tbody>\r\n");
#nullable restore
#line 62 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
             foreach (var item in TypeGroup)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                      ");
#nullable restore
#line 72 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                    <td>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1473, "\"", 1506, 1);
#nullable restore
#line 76 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
WriteAttributeValue("", 1479, Url.Content(item.ImageUrl), 1479, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cant display\" width=\"180px\" height=\"180px\" />\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
#nullable restore
#line 82 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Products\GroupBy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
