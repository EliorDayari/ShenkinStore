#pragma checksum "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230aa64620669f8148c2408d22036b90cde7a122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Login), @"mvc.1.0.view", @"/Views/Users/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230aa64620669f8148c2408d22036b90cde7a122", @"/Views/Users/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShenkinStore.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset>\r\n    <legend>\r\n\r\n    </legend>\r\n");
#nullable restore
#line 11 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
     using (Html.BeginForm("Login", "Users", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 16 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.LabelFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 19 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.TextBoxFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                </td>\r\n                <td colspan=\"2\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.ValidationMessageFor(model => model.UserName, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.PasswordFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                </td>\r\n                <td colspan=\"2\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.ValidationMessageFor(model => model.Password, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <input type=""submit"" value=""Login"" />
                            </td>
                            <td>
                                <input type=""reset"" value=""Reset"" />
                            </td>
                        </tr>
                    </table>
                </td>

            </tr>
            <tr>
                <td>
                    ");
#nullable restore
#line 61 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
               Write(Html.ValidationMessage("Error", null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 65 "C:\Users\eliordayari\source\repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</fieldset>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShenkinStore.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
