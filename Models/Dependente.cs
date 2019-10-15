using System;

namespace Banco_de_dados.Models
{
    public class Dependente
    {
         public string Empregado {get; set;}
        public string Nome {get; set;}
        public char Sexo {get; set;}
        public string Parentesco {get; set;}
        
        public DateTime DataNascimento {get; set;}
        
    }
}