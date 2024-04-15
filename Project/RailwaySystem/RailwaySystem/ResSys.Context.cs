﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RailDBEntities : DbContext
    {
        public RailDBEntities()
            : base("name=RailDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<bookTicket> bookTickets { get; set; }
        public virtual DbSet<cancelTicket> cancelTickets { get; set; }
        public virtual DbSet<train> trains { get; set; }
        public virtual DbSet<user_details> user_details { get; set; }
        public virtual DbSet<class_Avail> class_Avail { get; set; }
        public virtual DbSet<fare> fares { get; set; }
    
        public virtual int UpdateBookedTicket(Nullable<decimal> trainNo, string @class, Nullable<int> seatsBooked)
        {
            var trainNoParameter = trainNo.HasValue ?
                new ObjectParameter("TrainNo", trainNo) :
                new ObjectParameter("TrainNo", typeof(decimal));
    
            var classParameter = @class != null ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(string));
    
            var seatsBookedParameter = seatsBooked.HasValue ?
                new ObjectParameter("SeatsBooked", seatsBooked) :
                new ObjectParameter("SeatsBooked", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBookedTicket", trainNoParameter, classParameter, seatsBookedParameter);
        }
    
        public virtual int UpdateCancelTicket(Nullable<decimal> trainNo, string @class, Nullable<int> seatsBooked)
        {
            var trainNoParameter = trainNo.HasValue ?
                new ObjectParameter("TrainNo", trainNo) :
                new ObjectParameter("TrainNo", typeof(decimal));
    
            var classParameter = @class != null ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(string));
    
            var seatsBookedParameter = seatsBooked.HasValue ?
                new ObjectParameter("SeatsBooked", seatsBooked) :
                new ObjectParameter("SeatsBooked", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCancelTicket", trainNoParameter, classParameter, seatsBookedParameter);
        }
    
        public virtual int AddclassSeats(Nullable<decimal> trainNo, Nullable<int> firstAcSeats, Nullable<int> secAcSeats, Nullable<int> sLSeats)
        {
            var trainNoParameter = trainNo.HasValue ?
                new ObjectParameter("TrainNo", trainNo) :
                new ObjectParameter("TrainNo", typeof(decimal));
    
            var firstAcSeatsParameter = firstAcSeats.HasValue ?
                new ObjectParameter("firstAcSeats", firstAcSeats) :
                new ObjectParameter("firstAcSeats", typeof(int));
    
            var secAcSeatsParameter = secAcSeats.HasValue ?
                new ObjectParameter("SecAcSeats", secAcSeats) :
                new ObjectParameter("SecAcSeats", typeof(int));
    
            var sLSeatsParameter = sLSeats.HasValue ?
                new ObjectParameter("SLSeats", sLSeats) :
                new ObjectParameter("SLSeats", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddclassSeats", trainNoParameter, firstAcSeatsParameter, secAcSeatsParameter, sLSeatsParameter);
        }
    
        public virtual int AddclassFair(Nullable<decimal> trainNo, Nullable<int> firstAcSeatsfare, Nullable<int> secAcSeatsfare, Nullable<int> sLSeatsfare)
        {
            var trainNoParameter = trainNo.HasValue ?
                new ObjectParameter("TrainNo", trainNo) :
                new ObjectParameter("TrainNo", typeof(decimal));
    
            var firstAcSeatsfareParameter = firstAcSeatsfare.HasValue ?
                new ObjectParameter("firstAcSeatsfare", firstAcSeatsfare) :
                new ObjectParameter("firstAcSeatsfare", typeof(int));
    
            var secAcSeatsfareParameter = secAcSeatsfare.HasValue ?
                new ObjectParameter("SecAcSeatsfare", secAcSeatsfare) :
                new ObjectParameter("SecAcSeatsfare", typeof(int));
    
            var sLSeatsfareParameter = sLSeatsfare.HasValue ?
                new ObjectParameter("SLSeatsfare", sLSeatsfare) :
                new ObjectParameter("SLSeatsfare", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddclassFair", trainNoParameter, firstAcSeatsfareParameter, secAcSeatsfareParameter, sLSeatsfareParameter);
        }
    }
}