#pragma checksum "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830ae66f9dea3aa4f9417f5c4526f3ab866e7f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogAuditoria_Index), @"mvc.1.0.view", @"/Views/LogAuditoria/Index.cshtml")]
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
#line 1 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\_ViewImports.cshtml"
using ChallengerKenner1._0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\_ViewImports.cshtml"
using ChallengerKenner1._0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"830ae66f9dea3aa4f9417f5c4526f3ab866e7f45", @"/Views/LogAuditoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59ef50c7d31748ee4d34be0cd370b6e630af829e", @"/Views/_ViewImports.cshtml")]
    public class Views_LogAuditoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ChallengerKenner1._0.Models.LogAuditoriaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Relatório Geral</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DetalhesAuditoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmailUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DetalhesAuditoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmailUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Kelvin\Desktop\Challenger\ChallengerKenner1.0\ChallengerKenner1.0\Views\LogAuditoria\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ChallengerKenner1._0.Models.LogAuditoriaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
