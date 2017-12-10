﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warden_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class wardenEntities : DbContext
    {
        public wardenEntities()
            : base("name=wardenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<active_beacons> active_beacons { get; set; }
        public DbSet<all_beacons> all_beacons { get; set; }
        public DbSet<commands> commands { get; set; }
        public DbSet<history> history { get; set; }
        public DbSet<login> login { get; set; }
        public DbSet<new_beacons> new_beacons { get; set; }
        public DbSet<notifications> notifications { get; set; }
    
        public virtual ObjectResult<idb_by_Result> idb_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<idb_by_Result>("idb_by", conParameter);
        }
    
        public virtual ObjectResult<idn_by_Result> idn_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<idn_by_Result>("idn_by", conParameter);
        }
    
        public virtual ObjectResult<ninfo_by_Result> ninfo_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ninfo_by_Result>("ninfo_by", conParameter);
        }
    
        public virtual ObjectResult<status_by_Result> status_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<status_by_Result>("status_by", conParameter);
        }
    
        public virtual ObjectResult<timeUpdated_by_Result> timeUpdated_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<timeUpdated_by_Result>("timeUpdated_by", conParameter);
        }
    
        public virtual ObjectResult<time_by_Result> time_by(string con)
        {
            var conParameter = con != null ?
                new ObjectParameter("con", con) :
                new ObjectParameter("con", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<time_by_Result>("time_by", conParameter);
        }
    }
}
