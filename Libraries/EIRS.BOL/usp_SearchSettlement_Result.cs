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
    
    public partial class usp_SearchSettlement_Result
    {
        public int SettlementID { get; set; }
        public string SettlementRefNo { get; set; }
        public Nullable<long> ASID { get; set; }
        public string ASRefNo { get; set; }
        public Nullable<decimal> ASAmount { get; set; }
        public Nullable<decimal> SettlementAmount { get; set; }
        public Nullable<int> SettlementMethodID { get; set; }
        public string SettlementMethodName { get; set; }
        public Nullable<int> SettlementStatusID { get; set; }
        public string SettlementStatusName { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public string SettlementNotes { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string TaxPayerTypeName { get; set; }
        public Nullable<int> TaxPayerID { get; set; }
        public string TaxPayerName { get; set; }
        public string TaxPayerRIN { get; set; }
        public string TransactionRefNo { get; set; }
    }
}
