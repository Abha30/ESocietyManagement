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
    
    public partial class Function_Category
    {
        public Function_Category()
        {
            this.Function_Details = new HashSet<Function_Details>();
        }
    
        public int Function_Category_ID { get; set; }
        public string Function_Category1 { get; set; }
    
        public virtual ICollection<Function_Details> Function_Details { get; set; }
    }
}
