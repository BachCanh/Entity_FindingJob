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
    
    public partial class JobAlert
    {
        public string id { get; set; }
        public string senderID { get; set; }
        public string recipientID { get; set; }
        public string Subject { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> DateReply { get; set; }
        public string jobID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
