using DataLayer.Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class CustomerController : Controller
    {
        CustomerOrderProcessingService _customersOrder = null;
        public CustomerController()
        {
            _customersOrder = new CustomerOrderProcessingService();
        }
        // GET: Customer
        public async Task<ActionResult> Index(string searchString)
        {
            IEnumerable<CustomersDTO> customers = null;

            if (!string.IsNullOrEmpty(searchString))
            {
                customers = await _customersOrder.GetCustomers();

                //  customers=customers.Where(x=>x.FirstName==searchString || x.LastName==searchString || x.Email==searchString).ToList();

                 customers=customers.Where(x=>x.FirstName.Contains(searchString) || x.LastName.Contains(searchString) || x.Email.Contains(searchString)).ToList();
                return View(customers);
            }
            else
            {
                customers = await _customersOrder.GetCustomers();
                return View(customers);
            }

        }

        // GET: Customer/Details/5
        public async Task<ActionResult> Details(int id)
        {
            //var customers = await _customersOrder.GetCustomers();

            //var customer = customers.Where(x => x.CustomerID == id).FirstOrDefault();


            var customer =  _customersOrder.GetCustomerById(id);

            return View(customer);
        }

        // GET: Customer/Create
        public async Task<ActionResult> Create()
        {
     
            var customers = await _customersOrder.GetCustomers();

            var OrgId = customers.Select(x => x.OrgId).Distinct().ToList();

            ViewBag.OrgIds = new SelectList(OrgId);

            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public async Task<ActionResult> Create(CustomersDTO customersDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Customers customers = new Customers()
                    {
                        Email = customersDTO.Email,
                        FirstName = customersDTO.FirstName,
                        LastName = customersDTO.LastName,
                        OrgId = customersDTO.OrgId
                    };
                    var cus = await _customersOrder.AddCustomer(customers);
                }
 
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");

        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
