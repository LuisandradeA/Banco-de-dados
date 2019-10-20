

using System.Collections.Generic;
using System.Data;
using Banco_de_dados.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Banco_de_dados.Repository
{
    
    public interface IEmpresaRepository
    {
        IEnumerable<Empregado> GetAllEmpregados();
        IEnumerable<Dependente> GetAllDependentes();
        IEnumerable<Departamento> GetAllDepartamentos();

        IEnumerable<Projeto> GetAllProjetos();
        IEnumerable<Local> GetAllLocais();
        IEnumerable<TrabalhaEm> GetAllTrabalhaEm();

        Empregado InserirEmpregado(Empregado empregado);
    }
    
    public class EmpresaRepository : IEmpresaRepository
    {
        private string connectionString;
        public EmpresaRepository(IConfiguration configuration){
            connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
        }
        
        internal IDbConnection Connection{
            get{
                return new NpgsqlConnection(connectionString);
            }
        }
        public IEnumerable<Empregado> GetAllEmpregados(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Empregado>("SELECT * FROM empregado ORDER BY nome ASC");
                return teste;
            }        
        }
        public IEnumerable<Dependente> GetAllDependentes(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Dependente>("SELECT * FROM dependente");
                return teste;
            }        
        }
        public IEnumerable<Departamento> GetAllDepartamentos(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Departamento>("SELECT * FROM departamento");
                return teste;
            }        
        }
        public IEnumerable<Projeto> GetAllProjetos(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Projeto>("SELECT * FROM projeto");
                return teste;
            }        
        }
        public IEnumerable<Local> GetAllLocais(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Local>("SELECT * FROM local");
                return teste;
            }        
        }
       public IEnumerable<TrabalhaEm> GetAllTrabalhaEm(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<TrabalhaEm>("SELECT * FROM trabalhaem");
                return teste;
            }        
        }
        public Empregado InserirEmpregado(Empregado empregado){
            using(IDbConnection dbConnection = Connection){
              
                dbConnection.Open();
                var query = "INSERT INTO empregado (nome, nomedomeio, sobrenome, codigo, endereco,  salario, departamento, sexo, gerente, Dtnascimento)" +
                            "VALUES (@Nome, @NomeDoMeio, @SobreNome, @Codigo, @Endereco, @Salario,  @Departamento, @Sexo, @Gerente, @Dtnascimento)";
            
                var count = dbConnection.Execute(query, empregado);
            
                return empregado;
            }
        }

    
    
    
    
    }
}
