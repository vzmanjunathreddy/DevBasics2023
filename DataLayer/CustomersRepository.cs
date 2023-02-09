using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class CustomersRepository : ICustomersRepository
    {
        FoodDbConextCodeFirst dbContext = null;
        public CustomersRepository()
        {
            dbContext = new FoodDbConextCodeFirst();
        }
        public async Task<bool> AddCustomer(Customers customer)
        {
            bool isCustomerAdded = false;
            try
            {
                dbContext.Customers.Add(customer);
                await dbContext.SaveChangesAsync();
                isCustomerAdded = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return isCustomerAdded;
        }

        public bool DeleteCustomer(Customers customer)
        {
            bool isCustomerdeleted = false;
            try
            {
                dbContext.Customers.Remove(customer);
                dbContext.SaveChangesAsync();
                isCustomerdeleted = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return isCustomerdeleted;
        }

        public Customers GetCustomer(int Id)
        {
            Customers customer = null;
            try
            {
                customer = dbContext.Customers.Find(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return customer;
        }

        public async Task<IEnumerable<Customers>> GetCustomersList()
        {
            IEnumerable<Customers> customers = null;
            try
            {
                customers =await dbContext.Customers.Include(x => x.Orders).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return customers;
        }
    }
}
