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
    
    public partial class usp_GetAssessmentRuleItemDetails_Result
    {
        public Nullable<long> AAIID { get; set; }
        public Nullable<long> AARID { get; set; }
        public Nullable<int> AssessmentRuleID { get; set; }
        public string AssessmentRuleName { get; set; }
        public string AssessmentItemReferenceNo { get; set; }
        public Nullable<int> AssessmentItemID { get; set; }
        public string AssessmentItemName { get; set; }
        public string ComputationName { get; set; }
        public Nullable<int> PaymentStatusID { get; set; }
        public string PaymentStatusName { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> AdjustmentAmount { get; set; }
        public Nullable<decimal> LateChargeAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> SettlementAmount { get; set; }
        public Nullable<decimal> PendingAmount { get; set; }
    }
}
