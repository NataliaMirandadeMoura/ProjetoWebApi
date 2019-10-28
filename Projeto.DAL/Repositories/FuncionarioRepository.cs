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
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private readonly string connectionString;

        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["projeto"].ConnectionString;
        }

        public void Delete(int id)
        {
            using( var con = new SqlConnection(connectionString))
            {
                con.Execute("SpExcluirFuncionario", new { IdFuncionario = id },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void Insert(Funcionario obj)
        {
            using ( var con = new SqlConnection(connectionString))
            {
                con.Execute("SpCadastrarFuncionario", obj,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public List<Funcionario> SelectAll()
        {
            using(var con = new SqlConnection(connectionString))
            {
                return con.Query<Funcionario>("SpConsultarFuncionarios",
                    commandType: CommandType.StoredProcedure)
                    .ToList();
                    
            }
        }

        public Funcionario SelectById(int id)
        {
            using (var con = new SqlConnection(connectionString))
            {
                return con.Query<Funcionario>("SpConsultarFuncionarioPorId",
                    new { IdFuncionario = id },
                    commandType: CommandType.StoredProcedure)
                    .SingleOrDefault();
            }
        }

        public void Update(Funcionario obj)
        {
            using(var con = new SqlConnection(connectionString))
            {
                con.Execute("SpAtualizarFuncionario", obj, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
