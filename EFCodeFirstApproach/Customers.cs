using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach
{
    [Table(name: "Customers", Schema = "op")]
    public class Customers
    {
        public Customers()
        {
            this.Orders = new HashSet<Orders>();
        }

        //scalar properties 
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int OrgId { get; set; }

        [ForeignKey("OrgId")]
        public virtual Orgnization Orgnization { get; set; }

        //Navigation properties 
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
