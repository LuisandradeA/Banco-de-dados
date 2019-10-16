using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Banco_de_dados.Models;
using Banco_de_dados.Repository;
using Microsoft.Extensions.Configuration;

namespace Banco_de_dados.Controllers
{
    public class DepartamentoController : Controller
    {
        private EmpresaRepository _empresaRepository;
        
        public DepartamentoController(IConfiguration configuration){
            _empresaRepository = new EmpresaRepository(configuration);
        }
        
        public IActionResult Index()
        {
            var listaTodosDepartamentos = _empresaRepository.GetAllDepartamentos();
            
            return View(listaTodosDepartamentos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
