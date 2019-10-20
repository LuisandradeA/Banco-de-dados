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
    public class EmpregadoController : Controller
    {
        private EmpresaRepository _empresaRepository;
        
        public EmpregadoController(IConfiguration configuration){
            _empresaRepository = new EmpresaRepository(configuration);
        }
        
        public IActionResult Index()
        {
            var listaTodosEmpregados = _empresaRepository.GetAllEmpregados();
            
            return View(listaTodosEmpregados);
        }
        public IActionResult AdicionarEmpregado(){
            
            return View();
        } 
        [HttpPost]
        public IActionResult AdicionarEmpregadoAction(Empregado empregado){
            
            var teste = _empresaRepository.InserirEmpregado(empregado);
            return View("AdicionarEmpregado");
        } 
        public IActionResult GetEmpregadoProjeto(string empregadoCodigo){
            
            var teste = _empresaRepository.InserirEmpregado(empregado);
            return View("AdicionarEmpregado");
        } 
    }
}
