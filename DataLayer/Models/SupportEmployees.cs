using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    [Table(name: "SupportEmployees", Schema = "op")]
    public class SupportEmployees
    {
        [Key] // DataAnnotations
        public int EmpId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte Active { get; set; }
        public Nullable<int> ManagerId { get; set; }


        public int OrgId { get; set; }

        [ForeignKey("OrgId")]
        public virtual Orgnization Orgnization { get; set; }
    }
}
