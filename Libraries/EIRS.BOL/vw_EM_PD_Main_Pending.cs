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
    
    public partial class vw_EM_PD_Main_Pending
    {
        public Nullable<int> TaxMonth { get; set; }
        public Nullable<int> TaxYear { get; set; }
        public string PaymentRefNumber { get; set; }
        public string PaymentDateTime { get; set; }
        public string RIN { get; set; }
        public string CustomerName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Bank { get; set; }
        public string TaxPayerType { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public long PDMPID { get; set; }
    }
}
