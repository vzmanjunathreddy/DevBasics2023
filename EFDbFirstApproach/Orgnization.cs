//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDbFirstApproach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orgnization
    {

        public Orgnization()
        {
            this.Customers = new HashSet<Customer>();
            this.SupportEmployees = new HashSet<SupportEmployee>();
        }
    
        public int OrgId { get; set; }
        public string Name { get; set; }
        public System.DateTime EstablishmentYear { get; set; }
        public string TANNumber { get; set; }
        public string ContactNumber { get; set; }

        //Navigation Properties 
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SupportEmployee> SupportEmployees { get; set; }
    }
}
