//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanySendOffer
    {

        public CompanySendOffer()
        {

        }
        public CompanySendOffer(string companyid, string jobseekerid)
        {
            this.CompanyID = companyid;
            this.JobSeekerID = jobseekerid;
        }

        public string CompanyID { get; set; }
        public string JobSeekerID { get; set; }
        public string Status { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
