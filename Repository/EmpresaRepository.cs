

using System.Data;
using Banco_de_dados.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Banco_de_dados.Repository
{
    
    public interface IEmpresaRepository
    {
        void GetAllEmpregados();
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
        public void GetAllEmpregados(){
            using(IDbConnection dbConnection = Connection){
                dbConnection.Open();
                var teste = dbConnection.Query<Empregado>("SELECT * FROM empregado");
            }        
        }
    }
}