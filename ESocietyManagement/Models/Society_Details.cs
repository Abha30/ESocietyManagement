//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESocietyManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Society_Details
    {
        public Society_Details()
        {
            this.Owner_Registration = new HashSet<Owner_Registration>();
        }
    
        public string Society_ID { get; set; }
        public string Society_Name { get; set; }
        public string Society_City { get; set; }
        public long Society_Pincode { get; set; }
        public int Society_NoOffHouse { get; set; }
    
        public virtual ICollection<Owner_Registration> Owner_Registration { get; set; }
    }
}