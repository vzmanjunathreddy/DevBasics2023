using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTAPIDemo.Models
{
    public class StudentsDTO
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public IEnumerable<StudentsDTO> GetListOfStudents()
        {

            List<StudentsDTO> studentsDTOs = new List<StudentsDTO>();

            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 1,
                Name = "John",
                Age = 25,
                City = "Melbournne"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 2,
                Name = "Abraham",
                Age = 35,
                City = "Sydney"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 3,
                Name = "Yuvi",
                Age = 36,
                City = "Jalandar"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 4,
                Name = "ABC",
                Age = 52,
                City = "California"
            });
            studentsDTOs.Add(new StudentsDTO()
            {
                StudentId = 5,
                Name = "BBC",
                Age = 25,
                City = "London"
            });
            return studentsDTOs;
        }
    }
}