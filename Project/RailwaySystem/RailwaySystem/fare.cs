//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwaySystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class fare
    {
        public int SequenceNo { get; set; }
        public Nullable<decimal> train_no { get; set; }
        public Nullable<int> C1_AC_fare { get; set; }
        public Nullable<int> C2_AC_fare { get; set; }
        public Nullable<int> SL_fare { get; set; }
    
        public virtual train train { get; set; }
    }
}
