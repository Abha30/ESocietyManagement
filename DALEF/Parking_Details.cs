//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parking_Details
    {
        public int Parking_ID { get; set; }
        public string Vechile_Number { get; set; }
        public Nullable<int> Visitor_ID { get; set; }
        public string Slot_Id { get; set; }
    
        public virtual Guard_Duty Guard_Duty { get; set; }
    }
}
