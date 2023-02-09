using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    [Table(name: "Orgnization", Schema = "org")]
    public class Orgnization
    {
        public Orgnization()
        {
            this.Customers = new HashSet<Customers>();
            this.SupportEmployees = new HashSet<SupportEmployees>();
        }

        [Key]
        public int OrgId { get; set; }
        public string Name { get; set; }
        public System.DateTime EstablishmentYear { get; set; }
        public string TANNumber { get; set; }
        public string ContactNumber { get; set; }

        //Navigation Properties 
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<SupportEmployees> SupportEmployees { get; set; }
    }
}
