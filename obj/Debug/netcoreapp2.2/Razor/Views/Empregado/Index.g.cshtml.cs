#pragma checksum "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bb2f1743818a8fa0495d708bc4ffa71fe4605a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empregado_Index), @"mvc.1.0.view", @"/Views/Empregado/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empregado/Index.cshtml", typeof(AspNetCore.Views_Empregado_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb2f1743818a8fa0495d708bc4ffa71fe4605a0", @"/Views/Empregado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a10f80921a1b4b4c87d091eaec916228c11d9cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Empregado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Empregado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
  
    ViewData["Title"] = "Empregado";
    

#line default
#line hidden
            BeginContext(73, 440, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Empregados</h1>
</div>

<div>
  <table class=""table"">
        <tr>
          <th>Nome</th>
          <th>Nome do Meio</th>
          <th>Sobrenome</th>
          <th>Codigo</th>
          <th>Data de Nascimento</th>
          <th>Endereco</th>
          <th>Sexo</th>
          <th>Salario</th>
          <th>gerente</th>
          <th>Departamento</th>
        </tr>
");
            EndContext();
#line 24 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(562, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(601, 9, false);
#line 27 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(610, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(639, 15, false);
#line 28 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.NomeDoMeio);

#line default
#line hidden
            EndContext();
            BeginContext(654, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(683, 14, false);
#line 29 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.SobreNome);

#line default
#line hidden
            EndContext();
            BeginContext(697, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(726, 11, false);
#line 30 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(737, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(766, 17, false);
#line 31 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Dtnascimento);

#line default
#line hidden
            EndContext();
            BeginContext(783, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(812, 13, false);
#line 32 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Endereco);

#line default
#line hidden
            EndContext();
            BeginContext(825, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(854, 9, false);
#line 33 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Sexo);

#line default
#line hidden
            EndContext();
            BeginContext(863, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(892, 12, false);
#line 34 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Salario);

#line default
#line hidden
            EndContext();
            BeginContext(904, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(933, 12, false);
#line 35 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Gerente);

#line default
#line hidden
            EndContext();
            BeginContext(945, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(974, 17, false);
#line 36 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
               Write(item.Departamento);

#line default
#line hidden
            EndContext();
            BeginContext(991, 27, true);
            WriteLiteral(" </td>\r\n            </tr>\r\n");
            EndContext();
#line 38 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Empregado/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1029, 38, true);
            WriteLiteral("        \r\n  \r\n  </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Empregado>> Html { get; private set; }
    }
}
#pragma warning restore 1591