#pragma checksum "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97934a4f84d082353f2346faf8178f0e205b2b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Index), @"mvc.1.0.view", @"/Views/Empresa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empresa/Index.cshtml", typeof(AspNetCore.Views_Empresa_Index))]
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
#line 1 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/_ViewImports.cshtml"
using Banco_de_dados;

#line default
#line hidden
#line 2 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/_ViewImports.cshtml"
using Banco_de_dados.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97934a4f84d082353f2346faf8178f0e205b2b1b", @"/Views/Empresa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a10f80921a1b4b4c87d091eaec916228c11d9cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    

#line default
#line hidden
            BeginContext(51, 89, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<div>\r\n   ");
            EndContext();
            BeginContext(141, 51, false);
#line 11 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
Write(Html.ActionLink("Empregados", "Index", "Empregado"));

#line default
#line hidden
            EndContext();
            BeginContext(192, 10, true);
            WriteLiteral(" <br>\r\n   ");
            EndContext();
            BeginContext(203, 53, false);
#line 12 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
Write(Html.ActionLink("Dependentes", "Index", "Dependente"));

#line default
#line hidden
            EndContext();
            BeginContext(256, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(267, 57, false);
#line 13 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
Write(Html.ActionLink("Departamentos", "Index", "Departamento"));

#line default
#line hidden
            EndContext();
            BeginContext(324, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(335, 47, false);
#line 14 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
Write(Html.ActionLink("Projetos", "Index", "Projeto"));

#line default
#line hidden
            EndContext();
            BeginContext(382, 10, true);
            WriteLiteral("<br>\r\n    ");
            EndContext();
            BeginContext(393, 43, false);
#line 15 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empresa/Index.cshtml"
Write(Html.ActionLink("Locais", "Index", "Local"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 18, true);
            WriteLiteral("<br>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
