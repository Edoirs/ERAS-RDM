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
    
    public partial class usp_GetScratchCardDealerList_Result
    {
        public Nullable<int> ScratchCardDealerID { get; set; }
        public string ScratchCardDealerName { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> DealerTypeID { get; set; }
        public string DealerTypeName { get; set; }
        public Nullable<decimal> AgreedCommissionPercentage { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ActiveText { get; set; }
    }
}
