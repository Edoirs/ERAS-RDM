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
    
    public partial class MAP_TaxPayer_Message
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAP_TaxPayer_Message()
        {
            this.MAP_TaxPayer_Message_Document = new HashSet<MAP_TaxPayer_Message_Document>();
        }
    
        public long TPMID { get; set; }
        public Nullable<int> Sender_TaxPayerTypeID { get; set; }
        public Nullable<int> Sender_TaxPayerID { get; set; }
        public Nullable<int> Sender_StaffID { get; set; }
        public Nullable<int> Receiver_TaxPayerTypeID { get; set; }
        public Nullable<int> Receiver_TaxPayerID { get; set; }
        public Nullable<int> Receiver_StaffID { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> MessageDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TaxPayer_Message_Document> MAP_TaxPayer_Message_Document { get; set; }
    }
}
