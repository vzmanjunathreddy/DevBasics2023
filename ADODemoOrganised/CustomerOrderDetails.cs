using ADODemoOrganised.Interfaces;
using ADODemoOrganised.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoOrganised
{
    internal class CustomerOrderDetails: ICustomerOrders
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        DataTable dt = null;
        public CustomerOrderDetails(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand();
        }

        public IEnumerable<CustomersOrderDTO> GetCustomersOrdes(int CustomerId)
        {
            List<CustomersOrderDTO> customerOrdersDTOCollection = null;

            try
            {
                if(sqlConnection.State==ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                sqlCommand.CommandText = "[dbo].[sp_GetCustomerDetailsandOrdersPlacedbyId]";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("@CustomerId", CustomerId);
                sqlCommand.Parameters.Add(sqlParameter);

                var result = sqlCommand.ExecuteReader();

                dt = new DataTable();
                dt.Load(result);

                customerOrdersDTOCollection = new List<CustomersOrderDTO>();

                foreach (DataRow row in dt.Rows)
                {
                    CustomersOrderDTO customersOrderDTO = new CustomersOrderDTO()
                    {
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Email = row["Email"].ToString(),
                        CustomerType = row["CustomerType"].ToString(),
                        OrderDate = Convert.ToDateTime(row["OrderDate"].ToString())

                    };
                    customerOrdersDTOCollection.Add(customersOrderDTO);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception has occured and exception is {ex.ToString()}");
            }
            finally
            {
                if(sqlConnection!=null)
                {
                    sqlConnection.Close();
                }
            }
            return customerOrdersDTOCollection;
        }


    }
}
