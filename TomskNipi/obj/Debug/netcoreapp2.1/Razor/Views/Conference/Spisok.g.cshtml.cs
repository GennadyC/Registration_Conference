#pragma checksum "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1719d1a907f8b0f88022245c3f21cfb7dc77f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conference_Spisok), @"mvc.1.0.view", @"/Views/Conference/Spisok.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conference/Spisok.cshtml", typeof(AspNetCore.Views_Conference_Spisok))]
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
#line 1 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\_ViewImports.cshtml"
using TomskNipi;

#line default
#line hidden
#line 2 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\_ViewImports.cshtml"
using TomskNipi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1719d1a907f8b0f88022245c3f21cfb7dc77f0d", @"/Views/Conference/Spisok.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778abfeed256473fb4907818b6c6111c9717ebe9", @"/Views/_ViewImports.cshtml")]
    public class Views_Conference_Spisok : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomskNipi.Models.Sections>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
  
    ViewBag.Title = "Все секции";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(131, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(135, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e55ae450c8c4f77903408182dcee47b", async() => {
                BeginContext(158, 15, true);
                WriteLiteral("Добавить секцию");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 93, true);
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <tr><td>Название</td><td>Город</td><td>Улица</td></tr>\r\n");
            EndContext();
#line 11 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(319, 20, true);
            WriteLiteral("            <tr><td>");
            EndContext();
            BeginContext(340, 9, false);
#line 13 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(349, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(359, 9, false);
#line 13 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
                                  Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(368, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(378, 13, false);
#line 13 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
                                                     Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(391, 12, true);
            WriteLiteral("</td></tr>\r\n");
            EndContext();
#line 14 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
        }

#line default
#line hidden
            BeginContext(414, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 16 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(440, 59, true);
            WriteLiteral("    <a>Просмотр не доступен без авторизации</a><br />\r\n    ");
            EndContext();
            BeginContext(499, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b76423241aa24d7e94379ff1a87adae3", async() => {
                BeginContext(546, 4, true);
                WriteLiteral("Вход");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(554, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(560, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3187032db38e4b468f77be403906d36b", async() => {
                BeginContext(610, 11, true);
                WriteLiteral("Регистрация");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(625, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "C:\Users\Геннадий\source\repos\TomskNipi\TomskNipi\Views\Conference\Spisok.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TomskNipi.Models.Sections>> Html { get; private set; }
    }
}
#pragma warning restore 1591