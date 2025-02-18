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
    
    public partial class usp_SearchAssessmentRulesForRDMLoad_Result
    {
        public int AssessmentRuleID { get; set; }
        public string AssessmentRuleCode { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public string ProfileReferenceNo { get; set; }
        public string AssessmentRuleName { get; set; }
        public Nullable<int> RuleRunID { get; set; }
        public string RuleRunName { get; set; }
        public Nullable<int> PaymentFrequencyID { get; set; }
        public string PaymentFrequencyName { get; set; }
        public Nullable<decimal> AssessmentAmount { get; set; }
        public Nullable<int> TaxYear { get; set; }
        public Nullable<int> PaymentOptionID { get; set; }
        public string PaymentOptionName { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ActiveText { get; set; }
        public string SettlementMethodNames { get; set; }
        public string AssessmentItemNames { get; set; }
        public string ProfileAssetTypeName { get; set; }
    }
}
