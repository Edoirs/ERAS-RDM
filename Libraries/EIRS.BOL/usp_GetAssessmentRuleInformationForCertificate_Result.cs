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
    
    public partial class usp_GetAssessmentRuleInformationForCertificate_Result
    {
        public Nullable<int> TaxYear { get; set; }
        public string AssessmentRuleCode { get; set; }
        public string AssessmentRuleName { get; set; }
        public Nullable<int> AssessmentRuleID { get; set; }
        public Nullable<decimal> AssessmentAmount { get; set; }
        public Nullable<decimal> BilledAmount { get; set; }
    }
}
