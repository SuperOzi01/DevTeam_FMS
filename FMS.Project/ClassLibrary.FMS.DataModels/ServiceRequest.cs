//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary.FMS.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceRequest()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public int ServiceRequestID { get; set; }
        public int BuildingID { get; set; }
        public int SpecializationID { get; set; }
        public Nullable<int> AssignedWorkerID { get; set; }
        public int RequiestStatus { get; set; }
        public System.DateTime RequestIssueDate { get; set; }
        public Nullable<System.DateTime> RequestCloseDate { get; set; }
        public string ServiceDescribtion { get; set; }
        public int RequestCreatorID { get; set; }
    
        public virtual Beneficiary Beneficiary { get; set; }
        public virtual Building Building { get; set; }
        public virtual CompanyEmployee CompanyEmployee { get; set; }
        public virtual Specialization Specialization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
