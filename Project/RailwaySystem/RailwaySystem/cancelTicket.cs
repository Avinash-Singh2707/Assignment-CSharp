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
    
    public partial class cancelTicket
    {
        public decimal Cancel_Id { get; set; }
        public Nullable<decimal> Book_Id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<decimal> train_no { get; set; }
        public Nullable<int> Refund_Amount { get; set; }
        public Nullable<System.DateTime> Cancelled_date_time { get; set; }
    
        public virtual bookTicket bookTicket { get; set; }
        public virtual train train { get; set; }
        public virtual user_details user_details { get; set; }
    }
}