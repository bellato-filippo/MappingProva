using Dommel;
using MappingProva.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingProva.Repository
{
    internal class PortoRepository
    {
        protected readonly string connectionString;

        public PortoRepository()
        {
            connectionString = @"Data Source=LAPTOP-NEPDI9HD\MSSQLSERVER01;Initial Catalog=Prova;Integrated Security=True";
        }
        public void Insert(Porto porto)
        {

        }

        public IEnumerable<Porto> GetAll()
        {
            using (var db = new SqlConnection(connectionString))
            {
                return db.GetAll<Porto>();
            }
        }

        public async Task<Porto> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Porto porto)
        {

        }

        public void Delete(Porto porto)
        {

        }
    }
}
