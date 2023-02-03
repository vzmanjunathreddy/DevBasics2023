using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExceptionHandling
{
    internal class BasicExceptions : IBase
    {
        SqlConnection con=null;
        public BasicExceptions()
        {
            con = new SqlConnection();
        }
        public void GetData()
        {
            throw new NotImplementedException();
        }

        public void GetBasicDeatials()
        {
            try
            {
                con.Open();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch(OrderNotFoundException ex)
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception occured while opening a SQlConnection");
            }
            finally { 
                con.Close();
            }
        }
    }

    public interface IBase
    {
        void GetData();
    }
}
