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
    
    public partial class Owner_Registration
    {
        public Owner_Registration()
        {
            this.Function_Details = new HashSet<Function_Details>();
        }
    
        public int Owner_ID { get; set; }
        public string Owner_UserName { get; set; }
        public string Owner_Password { get; set; }
        public string Owener_Email { get; set; }
        public string House_ID { get; set; }
        public string Society_ID { get; set; }
        public string Owner_FirstName { get; set; }
        public string Owner_Lastname { get; set; }
        public string Owner_IDPROOF { get; set; }
        public long Owner_Contact { get; set; }
        public string Owner_Occupation { get; set; }
        public Nullable<int> Owner_NumberOfFamily { get; set; }
    
        public virtual ICollection<Function_Details> Function_Details { get; set; }
        public virtual House_Details House_Details { get; set; }
        public virtual Society_Details Society_Details { get; set; }
    }
}
