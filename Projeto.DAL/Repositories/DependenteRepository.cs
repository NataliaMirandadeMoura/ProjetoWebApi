using Dapper;
using Projeto.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {

        private readonly string connectionString;

        public DependenteRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["projeto"].ConnectionString;
        }
        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Execute("SpExcluirDependente", new { IdDependente = id },
               commandType: CommandType.StoredProcedure);
            }
            
        }

        public void Insert(Dependente obj)
        {
           using(var con = new SqlConnection(connectionString))
            {
                con.Execute("SpCadastrarDependentes", obj, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Dependente> SelectAll()
        {
            using(var con = new SqlConnection(connectionString))
            {
                return con.Query<Dependente>("SpConsultarDependentes", commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public Dependente SelectById(int id)
        {
            using (var con = new SqlConnection(connectionString))
            {
                return con.Query<Dependente>("SpConsultarDependentePorId",
                    new { IdDependente = id },
                    commandType: CommandType.StoredProcedure)
                    .SingleOrDefault();
            }
        }

        public void Update(Dependente obj)
        {
            using(var con = new SqlConnection(connectionString))
            {
                con.Execute("SpAtualizarDependente", obj, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
