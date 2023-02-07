using ADODemoOrganised.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised.Models
{
    internal class SQLConnectionDTO: ISQLConnectionDTO
    {
        private string sqlConnectionString;
        public SQLConnectionDTO(string sqlConnectionString)
        {
            this.sqlConnectionString = sqlConnectionString; 
        }

        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection= new SqlConnection(this.sqlConnectionString);

            return sqlConnection;
        }
    }
}
