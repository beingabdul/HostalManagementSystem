﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HostalManagementDB01Entities : DbContext
    {
        public HostalManagementDB01Entities()
            : base("name=HostalManagementDB01Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillAudit> BillAudits { get; set; }
        public virtual DbSet<Catagory> Catagories { get; set; }
        public virtual DbSet<FoodList> FoodLists { get; set; }
        public virtual DbSet<MealType> MealTypes { get; set; }
        public virtual DbSet<Messing> Messings { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Weekday> Weekdays { get; set; }
    
        public virtual ObjectResult<getMonthyReportOrderByStudent_Result> getMonthyReportOrderByStudent(Nullable<int> rid, Nullable<int> mid)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var midParameter = mid.HasValue ?
                new ObjectParameter("mid", mid) :
                new ObjectParameter("mid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getMonthyReportOrderByStudent_Result>("getMonthyReportOrderByStudent", ridParameter, midParameter);
        }
    
        public virtual ObjectResult<getMonthyReportOrderByStudent01_Result> getMonthyReportOrderByStudent01(Nullable<int> rid, Nullable<int> mid)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var midParameter = mid.HasValue ?
                new ObjectParameter("mid", mid) :
                new ObjectParameter("mid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getMonthyReportOrderByStudent01_Result>("getMonthyReportOrderByStudent01", ridParameter, midParameter);
        }
    
        public virtual ObjectResult<getMonthyReportOrderByStudent02_Result> getMonthyReportOrderByStudent02(Nullable<int> bid)
        {
            var bidParameter = bid.HasValue ?
                new ObjectParameter("bid", bid) :
                new ObjectParameter("bid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getMonthyReportOrderByStudent02_Result>("getMonthyReportOrderByStudent02", bidParameter);
        }
    
        public virtual ObjectResult<getMonthyReportOrderByStudentSingle_Result> getMonthyReportOrderByStudentSingle(Nullable<int> rid, Nullable<int> mid)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var midParameter = mid.HasValue ?
                new ObjectParameter("mid", mid) :
                new ObjectParameter("mid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getMonthyReportOrderByStudentSingle_Result>("getMonthyReportOrderByStudentSingle", ridParameter, midParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getMonthyTotal(Nullable<int> rid, Nullable<int> mid)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            var midParameter = mid.HasValue ?
                new ObjectParameter("mid", mid) :
                new ObjectParameter("mid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getMonthyTotal", ridParameter, midParameter);
        }
    
        public virtual int getReadytoCook(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getReadytoCook", idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getTotal(Nullable<int> rid)
        {
            var ridParameter = rid.HasValue ?
                new ObjectParameter("rid", rid) :
                new ObjectParameter("rid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getTotal", ridParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getTotal01(Nullable<int> bID)
        {
            var bIDParameter = bID.HasValue ?
                new ObjectParameter("BID", bID) :
                new ObjectParameter("BID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getTotal01", bIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getTotal02(Nullable<int> bID)
        {
            var bIDParameter = bID.HasValue ?
                new ObjectParameter("BID", bID) :
                new ObjectParameter("BID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getTotal02", bIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> getTotal03(Nullable<int> bID)
        {
            var bIDParameter = bID.HasValue ?
                new ObjectParameter("BID", bID) :
                new ObjectParameter("BID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getTotal03", bIDParameter);
        }
    }
}