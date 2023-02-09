using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CustomerOrderProcessingService
    {
        private CustomersRepository _customersRepository;
        public CustomerOrderProcessingService()
        {
            _customersRepository = new CustomersRepository();
        }
        public async Task<bool> AddCustomer(Customers customers)
        {
            bool isCustomerAdded = false;
            try
            {
                isCustomerAdded = await _customersRepository.AddCustomer(customers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return isCustomerAdded;
        }

        public async Task<IEnumerable<CustomersDTO>> GetCustomers()
        {
            List<CustomersDTO> customersDTOsCollection = null;

            try
            {
                customersDTOsCollection = new List<CustomersDTO>();

                var customers = await _customersRepository.GetCustomersList();

                //Automapper to be used for best practice

                foreach (var customer in customers)
                {
                    customersDTOsCollection.Add(new CustomersDTO()
                    {
                        Email = customer.Email,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return customersDTOsCollection.ToList();
        }

        public async Task<bool> RemoveCustomer(int Id)
        {
            // Nlog 
            // SiriLog
            //Azure blob storage
            // Azure Applications Insights
            bool isDeleted = false;
            try
            {
                var customer =  _customersRepository.GetCustomer(Id);

                if (customer != null)
                {
                    isDeleted= _customersRepository.DeleteCustomer(customer);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return isDeleted;
        }

    }


}

