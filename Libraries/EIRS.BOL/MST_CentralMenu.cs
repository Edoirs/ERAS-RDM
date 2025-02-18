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
    
    public partial class MST_CentralMenu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MST_CentralMenu()
        {
            this.MAP_CentralMenu_Screen = new HashSet<MAP_CentralMenu_Screen>();
            this.MST_CentralMenu1 = new HashSet<MST_CentralMenu>();
        }
    
        public int CentralMenuID { get; set; }
        public string CentralMenuName { get; set; }
        public Nullable<int> ParentCentralMenuID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<decimal> SortOrder { get; set; }
        public Nullable<int> MenuType { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_CentralMenu_Screen> MAP_CentralMenu_Screen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MST_CentralMenu> MST_CentralMenu1 { get; set; }
        public virtual MST_CentralMenu MST_CentralMenu2 { get; set; }
    }
}
