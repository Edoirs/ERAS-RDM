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
    
    public partial class vw_MDAServices
    {
        public int MDAServiceID { get; set; }
        public Nullable<int> TaxYear { get; set; }
        public string MDAServiceName { get; set; }
        public string RuleRunName { get; set; }
        public string PaymentFrequencyName { get; set; }
        public Nullable<decimal> ServiceAmount { get; set; }
    }
}
