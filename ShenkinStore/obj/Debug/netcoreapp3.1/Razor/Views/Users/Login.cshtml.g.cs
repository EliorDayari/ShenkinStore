#pragma checksum "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a667f9677f067240595a1d55cf98f21584bed92b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a667f9677f067240595a1d55cf98f21584bed92b", @"/Views/Users/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShenkinStore.Models.LoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString(" stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a667f9677f067240595a1d55cf98f21584bed92b4086", async() => {
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
            WriteLiteral("\r\n</header>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
 using (Html.BeginForm("Login", "Users", FormMethod.Post, new { @class = "box" }))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.LabelFor(model => model.UserName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.TextBoxFor(model => model.UserName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.ValidationMessageFor(model => model.UserName, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.PasswordFor(model => model.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.ValidationMessageFor(model => model.Password, null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Login\" />\r\n");
#nullable restore
#line 27 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
Write(Html.ValidationMessage("Error", null, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\yarinmeron\Source\Repos\ShenkinStore\ShenkinStore\Views\Users\Login.cshtml"
                                                                               

}

#line default
#line hidden
#nullable disable
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
