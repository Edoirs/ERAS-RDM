//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIRS.BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAP_Certificate_Stages
    {
        public long CSID { get; set; }
        public Nullable<long> CertificateID { get; set; }
        public Nullable<long> StageID { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
    
        public virtual Certificate Certificate { get; set; }
    }
}
