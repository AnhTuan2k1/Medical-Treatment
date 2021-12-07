//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SpecialistExamination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialistExamination()
        {
            this.ExaminationInvoiceDetails = new HashSet<ExaminationInvoiceDetail>();
            this.SpecialistExaminationRequests = new HashSet<SpecialistExaminationRequest>();
            this.SpecialistExaminationResults = new HashSet<SpecialistExaminationResult>();
        }
    
        public int SpecialExaminationID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExaminationInvoiceDetail> ExaminationInvoiceDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialistExaminationRequest> SpecialistExaminationRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialistExaminationResult> SpecialistExaminationResults { get; set; }
    }
}