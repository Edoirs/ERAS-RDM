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
    
    public partial class usp_SearchCertificate_Result
    {
        public Nullable<long> CertificateID { get; set; }
        public string CertificateNumber { get; set; }
        public string CertificateTypeName { get; set; }
        public Nullable<int> TaxYear { get; set; }
        public string TaxPayerTypeName { get; set; }
        public Nullable<int> TaxPayerID { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string TaxPayerName { get; set; }
        public string TaxPayerRIN { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string CertificateStatusName { get; set; }
        public Nullable<System.DateTime> CertificateDate { get; set; }
    }
}
