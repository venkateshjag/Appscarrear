//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class job
    {
        public int jobid { get; set; }
        public string jobname { get; set; }
        public string company { get; set; }
        public string Location { get; set; }
        public Nullable<int> noofpositions { get; set; }
        public string jobnumber { get; set; }
        public Nullable<int> experience { get; set; }
        public Nullable<int> jobtypeid { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> SubCategoryId { get; set; }
        public Nullable<int> SalaryLimit { get; set; }
        public Nullable<int> Qualification { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> posteddate { get; set; }
    }
}