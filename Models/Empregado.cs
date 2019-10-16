using System;
using System.ComponentModel.DataAnnotations;
namespace Banco_de_dados.Models
{
    public class Empregado
    {
        public string Nome {get; set;}
        public string NomeDoMeio {get; set;}
        public string SobreNome {get; set;}
        [Key]
        public string Codigo {get; set;}
        
        public DateTime Dtnascimento {get; set;}
        public string Endereco {get; set;}
        public char Sexo {get; set;}
        public decimal Salario {get; set;}
        public string Gerente {get; set;}
        public string Departamento {get; set;}

    
    }
}