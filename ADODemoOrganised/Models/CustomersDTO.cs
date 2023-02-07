using ADODemoOrganised.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace ADODemoOrganised.Models
{
    internal class CustomersDTO : ICustomers
    {
        public CustomersDTO()
        {

        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int OrgId { get; set; }

        public IEnumerable<CustomersDTO> GetCustomers()
        {
            SqlCommand sqlCommand = null;
            DataTable dt = null;
            List<CustomersDTO> customersCollection = null;
            CustomersDTO customersDTO = null;

            try
            {
                string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ToString();

                SQLConnectionDTO sQLConnectionDTO = new SQLConnectionDTO(sqlConnectionString);

                SqlConnection sqlConnection = sQLConnectionDTO.GetSqlConnection();


                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                sqlCommand = new SqlCommand("Select top 3 * from [op].[Customers]", sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                dt = new DataTable();

                sqlDataAdapter.Fill(dt);

                customersCollection = new List<CustomersDTO>();

                foreach (DataRow datarow in dt.Rows)
                {
                    customersDTO = new CustomersDTO
                    {
                        CustomerId = Convert.ToInt32(datarow["CustomerId"]),
                        Email = datarow["Email"].ToString(),
                        FirstName = datarow["FirstName"].ToString(),
                        LastName = datarow["LastName"].ToString()
                    };
                    customersCollection.Add(customersDTO);
                    //Console.WriteLine($"Customer Id is {datarow["CustomerId"]} and  Name is {datarow["FirstName"] + "," + datarow["LastName"]}");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
            finally
            {

            }
            return customersCollection;

        }
    }
}
