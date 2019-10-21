

using System.Collections.Generic;
using System.Data;
using Banco_de_dados.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using Banco_de_dados.Models.Relatorios;
using System.Linq;

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
        void EditarEmpregado(Empregado empregado);

        IEnumerable<EmpregadoProjetoRelatorio> GetEmpregadoProjeto(string empregadoCodigo);
    
        Empregado GetEmpregadoPorCodigo(string empregadoCodigo);
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

        public IEnumerable<EmpregadoProjetoRelatorio> GetEmpregadoProjeto(string empregadoCodigo){
            using(IDbConnection dbConnection = Connection){
              


                 dbConnection.Open();
                var query = dbConnection.Query<EmpregadoProjetoRelatorio>("select e.nome AS EmpregadoNome,e.codigo AS EmpregadoCodigo ,p.descricao AS ProjetoDescricao, te.horas AS TrabalhaEmHoras, d.nome AS DepartamentoNome from empregado as e "+
                                                                            " inner join trabalhaem te on te.empregado = e.codigo"+
                                                                            " inner join projeto p on p.codigo = te.projeto" +
                                                                            " inner join departamento d on p.departamento = d.codigo" +
                                                                            " where e.codigo =  @EmpregadoCodigo" , new { EmpregadoCodigo = empregadoCodigo});
                return query;
            }
        }

        public Empregado GetEmpregadoPorCodigo(string empregadoCodigo){
            using(IDbConnection dbConnection = Connection){
              


                 dbConnection.Open();
                var query = dbConnection.Query<Empregado>("select * from empregado as e"+
                                                          " where e.codigo =  @EmpregadoCodigo" , new { EmpregadoCodigo = empregadoCodigo});
                return query.AsList().FirstOrDefault();
            }
        }
        public void EditarEmpregado(Empregado empregado){
            using(IDbConnection dbConnection = Connection){
              
                dbConnection.Open();
                var query = "UPDATE empregado set nome = @Nome, nomedomeio = @NomeDoMeio, sobrenome = @SobreNome, codigo = @Codigo, endereco = @Endereco,  salario = @Salario, departamento = @Departamento, sexo = @Sexo, gerente = @Gerente, dtnascimento = @DtNascimento" + 
                            " WHERE codigo = '" + empregado.Codigo + "'";
            
                var count = dbConnection.Execute(query, empregado);
            
            }
        }
    
    }
}
