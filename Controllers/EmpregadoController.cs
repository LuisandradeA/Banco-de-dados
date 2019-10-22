using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Banco_de_dados.Models;
using Banco_de_dados.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            
            var query = _empresaRepository.GetEmpregadoProjeto(empregadoCodigo);
            
            return View("EmpregadoProjetoRelatorio", query);
        } 

        public IActionResult EditarEmpregado(string empregadoCodigo){
            
            var empregado = _empresaRepository.GetEmpregadoPorCodigo(empregadoCodigo);

            return View("EditarEmpregado", empregado);
        }
        public IActionResult EditarEmpregadoAction(Empregado empregado){
            
            _empresaRepository.EditarEmpregado(empregado);
            var listaTodosEmpregados = _empresaRepository.GetAllEmpregados();
            return View("Index", listaTodosEmpregados);
        }
        public IActionResult DeletarEmpregadoAction(string empregadoCodigo){
            
            _empresaRepository.DeletarEmpregado(empregadoCodigo);
            var listaTodosEmpregados = _empresaRepository.GetAllEmpregados();
            return View("Index", listaTodosEmpregados);
        }    
        public IActionResult AssociarEmpregadoProjeto(string empregadoCodigo){
            
            var projetos = _empresaRepository.GetAllProjetos();
            var selectList = projetos.Select(x => new SelectListItem(){Text=x.Descricao,Value = x.Codigo.ToString()}).ToList();
            
            ViewBag.ProjetosList = selectList;
            ViewBag.empregadoCodigo = empregadoCodigo;
            return View();
        }
        public IActionResult AssociarEmpregadoProjetoAction(){
            
            var projetos = _empresaRepository.GetAllProjetos();
            var selectList = projetos.Select(x => new SelectListItem(){Text=x.Descricao,Value = x.Codigo.ToString()}).ToList();
            
            ViewBag.ProjetosList = selectList;
            
            return View();
        }
        public IActionResult GetDependentesByEmpregadoCodigo(string empregadoCodigo){
            
            var dependentes = _empresaRepository.GetDependentesByEmpregadoCodigo(empregadoCodigo);
            
            return View(dependentes);
        }
    }
}
