#pragma checksum "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a220823a1531c83cb2fa3d797d4eed88766ba192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Join), @"mvc.1.0.view", @"/Views/Users/Join.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a220823a1531c83cb2fa3d797d4eed88766ba192", @"/Views/Users/Join.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Join : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
  
    ViewData["Title"] = "Join";
    var joinData = ViewBag.JoinData;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Join</h1>\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 10 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
     foreach (var item in joinData)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <thead>


            <tr>

                <th>
                    User Name
                </th>
                <th>
                    Transaction Id
                </th>
                <th>
                    Transaction Date
                </th>
                <th>
                    Transaction total price
                </th>


            </tr>
        </thead>
");
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    <a class=\"fonts links\"");
            BeginWriteAttribute("href", " href=\'", 806, "\'", 882, 1);
#nullable restore
#line 41 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
WriteAttributeValue("", 813, Url.Action( "Details", "Transactions", new { id = item.Tran }, null), 813, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
                                                                                                                   Write(item.Tran);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 51 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n\r\n\r\n\r\n    <p>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
         foreach (var item in joinData)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>\r\n                ");
#nullable restore
#line 63 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 63 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
                      Write(item.Tran);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n");
#nullable restore
#line 68 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Join.cshtml"
                            


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
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
