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
    
    public partial class MAP_CentralMenu_Screen
    {
        public long CMSID { get; set; }
        public Nullable<int> CentralMenuID { get; set; }
        public Nullable<int> ScreenID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> isMainScreen { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual MST_CentralMenu MST_CentralMenu { get; set; }
        public virtual MST_Screen MST_Screen { get; set; }
    }
}
