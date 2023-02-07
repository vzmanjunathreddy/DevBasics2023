using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //connection obj
            // to get connection string View--> SQL server Object Explorer--> Add Sql Server
            //Command obj

            #region Connected Mode using Data readaer
            //SqlConnection sqlConnection = null;
            //SqlCommand sqlCommand=null;
            //try
            //{
            //    //sqlConnection = new SqlConnection("Data Source=.;Database=FoodDatabase; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //    sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnectionString"].ToString());

            //    sqlConnection.Open();
            //    sqlCommand = new SqlCommand("Select top 3 * from [op].[Customers]",sqlConnection);
            //    SqlDataReader datareader = sqlCommand.ExecuteReader();

            //    while(datareader.Read())
            //    {
            //        Console.WriteLine($"Customer Id is {datareader["CustomerId"]} and  Name is {datareader["FirstName"] +","+ datareader["LastName"]}");
            //    }


            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            #endregion


            #region Disconnected Mode

            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;
            DataTable dt = null;
            DataSet ds = null;

            try
            {
                string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ToString();

                sqlConnection = new SqlConnection(sqlConnectionString);

                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                
                sqlCommand = new SqlCommand("Select top 3 * from [op].[Customers]",sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                ds= new DataSet();
                dt= new DataTable();

                sqlDataAdapter.Fill(ds);
                sqlDataAdapter.Fill(dt);

                foreach (DataRow datarow in dt.Rows)
                {
                    Console.WriteLine($"Customer Id is {datarow["CustomerId"]} and  Name is {datarow["FirstName"] + "," + datarow["LastName"]}");
                }

                foreach (DataTable datatable in ds.Tables)
                {
                    foreach (DataRow datarow in datatable.Rows)
                    {
                        Console.WriteLine($"Customer Id is {datarow["CustomerId"]} and  Name is {datarow["FirstName"] + "," + datarow["LastName"]}");
                    }
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
            #endregion
        }
    }
}
