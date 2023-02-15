using Newtonsoft.Json;
using RESTAPIDemo.Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Http;

namespace RESTAPIDemo.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersMockController : ApiController
    {
        private StudentsDTO students = null;
        private CustomerOrderProcessingService customerOrderProcessingService = null;
        public CustomersMockController()
        {
            students= new StudentsDTO();
            customerOrderProcessingService = new CustomerOrderProcessingService();
        }

        [HttpGet]
        [Route("getallcustomers")]
        public IEnumerable<StudentsDTO> GetListofCustomers()
        {
            return students.GetListOfStudents();
        }

        [HttpGet]
        [Route("getcustomerById")]
        public StudentsDTO GetListofCustomersBy(int id, string name)
        {
            var student= students.GetListOfStudents().Where(x=>x.StudentId==id && x.Name.ToLower()==name.ToLower()).FirstOrDefault();
            return student;
        }

        [HttpPost]
        [Route("addcustomer")]
        public IEnumerable<StudentsDTO> Post([FromBody] StudentsDTO studentsDTO)
        {
            List<StudentsDTO> newStudentsCollection = new List<StudentsDTO>();

            var studentsCollection = students.GetListOfStudents();

            newStudentsCollection.AddRange(studentsCollection);

            newStudentsCollection.Add(studentsDTO);

            return newStudentsCollection;

        }

        [HttpPut]
        [Route("updatecustomer")]
        public StudentsDTO UpdateStudent([FromBody] StudentsDTO student)
        {
            var oldstudent = students.GetListOfStudents().Where(x=>x.StudentId==student.StudentId).First();

            oldstudent.Name = student.Name;


            var updatedStudent = oldstudent;




            return updatedStudent;
        }

        [HttpGet]
        [Route("getexternaldata")]
        public async Task<ExternalData> GetExternalData()
        {
            ExternalData externalData = null;
            HttpClient httpClient = new HttpClient();

            var result =await httpClient.GetAsync("https://reqres.in/api/users?page=2");

            if(result.IsSuccessStatusCode)
            {
               var content= await result.Content.ReadAsStringAsync();
               
                externalData=JsonConvert.DeserializeObject<ExternalData>(content);


            }

            return externalData;
        }

        [HttpGet]
        [Route("getcustomersfromdb")]
        public async Task<IEnumerable<CustomersDTO>> GetcustomersusingEF()
        {
            var result =await customerOrderProcessingService.GetCustomers();


            return result;
        }



        // DELETE: api/CustomersMock/5
        public void Delete(int id)
        {
        }
    }
}
