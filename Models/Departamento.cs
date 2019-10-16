using System;

namespace Banco_de_dados.Models
{
    public class Departamento
    {
          public string Nome {get; set;}
        public int Codigo {get; set;}
        public char Sexo {get; set;}
        public string Gerente {get; set;}
        
        public DateTime Iniciogerente {get; set;}
    }
}