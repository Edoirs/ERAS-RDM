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
    
    public partial class usp_SearchSpecialForRDMLoad_Result
    {
        public int SpecialID { get; set; }
        public string SpecialRIN { get; set; }
        public string SpecialTaxPayerName { get; set; }
        public string TIN { get; set; }
        public Nullable<int> TaxOfficeID { get; set; }
        public string TaxOfficeName { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string TaxPayerTypeName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public string ContactName { get; set; }
        public string Description { get; set; }
        public Nullable<int> NotificationMethodID { get; set; }
        public string NotificationMethodName { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ActiveText { get; set; }
    }
}
