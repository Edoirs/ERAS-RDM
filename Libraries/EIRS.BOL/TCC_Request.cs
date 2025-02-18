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
    
    public partial class TCC_Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TCC_Request()
        {
            this.MAP_TCCRequest_Generate = new HashSet<MAP_TCCRequest_Generate>();
            this.MAP_TCCRequest_GenerateTCCDetail = new HashSet<MAP_TCCRequest_GenerateTCCDetail>();
            this.MAP_TCCRequest_Issue = new HashSet<MAP_TCCRequest_Issue>();
            this.MAP_TCCRequest_PrepareTCCDraft = new HashSet<MAP_TCCRequest_PrepareTCCDraft>();
            this.MAP_TCCRequest_Seal = new HashSet<MAP_TCCRequest_Seal>();
            this.MAP_TCCRequest_SignDigital = new HashSet<MAP_TCCRequest_SignDigital>();
            this.MAP_TCCRequest_Validate = new HashSet<MAP_TCCRequest_Validate>();
            this.MAP_TCCRequest_ValidateTaxPayerIncome = new HashSet<MAP_TCCRequest_ValidateTaxPayerIncome>();
            this.MAP_TCCRequest_ValidateTaxPayerInformation = new HashSet<MAP_TCCRequest_ValidateTaxPayerInformation>();
            this.MAP_TCCRequest_Revoke = new HashSet<MAP_TCCRequest_Revoke>();
        }
    
        public long TCCRequestID { get; set; }
        public string RequestRefNo { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<long> ServiceBillID { get; set; }
        public Nullable<int> TaxPayerID { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public Nullable<int> TaxYear { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> VisibleSignStatusID { get; set; }
        public Nullable<int> PDFTemplateID { get; set; }
        public string GeneratedPath { get; set; }
        public string ValidatedPath { get; set; }
        public string SignedVisiblePath { get; set; }
        public string SignedDigitalPath { get; set; }
        public string SealedPath { get; set; }
        public Nullable<int> SEDE_DocumentID { get; set; }
        public Nullable<long> SEDE_OrderID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string GeneratePathForPrint { get; set; }
        public Nullable<bool> IsDownloaded { get; set; }
        public Nullable<int> TaxOfficeId { get; set; }
        public string ApproverTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_Generate> MAP_TCCRequest_Generate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_GenerateTCCDetail> MAP_TCCRequest_GenerateTCCDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_Issue> MAP_TCCRequest_Issue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_PrepareTCCDraft> MAP_TCCRequest_PrepareTCCDraft { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_Seal> MAP_TCCRequest_Seal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_SignDigital> MAP_TCCRequest_SignDigital { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_Validate> MAP_TCCRequest_Validate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_ValidateTaxPayerIncome> MAP_TCCRequest_ValidateTaxPayerIncome { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_ValidateTaxPayerInformation> MAP_TCCRequest_ValidateTaxPayerInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TCCRequest_Revoke> MAP_TCCRequest_Revoke { get; set; }
        public virtual TCC_Request TCC_Request1 { get; set; }
        public virtual TCC_Request TCC_Request2 { get; set; }
        public virtual TCC_Request TCC_Request11 { get; set; }
        public virtual TCC_Request TCC_Request3 { get; set; }
    }
}
