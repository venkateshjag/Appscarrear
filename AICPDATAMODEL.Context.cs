﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AICPDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class aicpdataEntities : DbContext
    {
        public aicpdataEntities()
            : base("name=aicpdataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<degree> degrees { get; set; }
        public virtual DbSet<job_type> job_type { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<jobseekerprofile> jobseekerprofiles { get; set; }
        public virtual DbSet<resumeguideline> resumeguidelines { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<sampleresumeformat> sampleresumeformats { get; set; }
        public virtual DbSet<securityquestion> securityquestions { get; set; }
        public virtual DbSet<subcategory> subcategories { get; set; }
        public virtual DbSet<userdetail> userdetails { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<users_applied_job> users_applied_job { get; set; }
    
        public virtual ObjectResult<GetAppliedJob_Result> GetAppliedJob(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAppliedJob_Result>("GetAppliedJob", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<GetJobReportData_Result> GetJobReportData(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetJobReportData_Result>("GetJobReportData", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<GetResumeFormat_Result> GetResumeFormat(Nullable<int> catId, Nullable<int> subCatId)
        {
            var catIdParameter = catId.HasValue ?
                new ObjectParameter("catId", catId) :
                new ObjectParameter("catId", typeof(int));
    
            var subCatIdParameter = subCatId.HasValue ?
                new ObjectParameter("subCatId", subCatId) :
                new ObjectParameter("subCatId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetResumeFormat_Result>("GetResumeFormat", catIdParameter, subCatIdParameter);
        }
    }
}