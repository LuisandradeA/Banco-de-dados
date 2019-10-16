

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
                var teste = dbConnection.Query<Empregado>("SELECT * FROM empregado");
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
    
    }
}
