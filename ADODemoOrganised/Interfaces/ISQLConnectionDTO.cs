using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ADODemoOrganised.Interfaces
{
    internal interface ISQLConnectionDTO
    {
        SqlConnection GetSqlConnection();
    }
}
