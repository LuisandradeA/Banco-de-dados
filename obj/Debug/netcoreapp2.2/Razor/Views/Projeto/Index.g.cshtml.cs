#pragma checksum "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f7880d273a712c0bb9bbf3813146d571fc2747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projeto_Index), @"mvc.1.0.view", @"/Views/Projeto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projeto/Index.cshtml", typeof(AspNetCore.Views_Projeto_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f7880d273a712c0bb9bbf3813146d571fc2747", @"/Views/Projeto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a10f80921a1b4b4c87d091eaec916228c11d9cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Projeto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
  
    ViewData["Title"] = "Departamentos";
    

#line default
#line hidden
            BeginContext(75, 288, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Departamentos</h1>
</div>


<div>
  <table class=""table"">
        <tr>
          
          <th>Descrição</th>
          <th>Codigo</th>
          <th>Local</th>
          <th>Departamento</th>
          
        </tr>
");
            EndContext();
#line 21 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(412, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(451, 14, false);
#line 24 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(465, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(494, 11, false);
#line 25 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
               Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(505, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(534, 10, false);
#line 26 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
               Write(item.Local);

#line default
#line hidden
            EndContext();
            BeginContext(544, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(573, 17, false);
#line 27 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
               Write(item.Departamento);

#line default
#line hidden
            EndContext();
            BeginContext(590, 27, true);
            WriteLiteral(" </td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "/Users/defaut/Documents/Banco de dados/Trabalho Empresa/Banco-de-dados/Views/Projeto/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(628, 36, true);
            WriteLiteral("        \r\n  \r\n  </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
