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
    
    public partial class SP_GetAllServiceRequests_Result
    {
        public int ServiceRequestID { get; set; }
        public string Username { get; set; }
        public string SpecializationName { get; set; }
        public string ServiceDescribtion { get; set; }
        public Nullable<int> BuildingID { get; set; }
        public string City { get; set; }
        public Nullable<int> NoFloors { get; set; }
        public Nullable<int> BuildingManagerID { get; set; }
        public bool RequiestStatus { get; set; }
        public bool RequestHandlingStatus { get; set; }
        public System.DateTime RequestIssueDate { get; set; }
        public Nullable<System.DateTime> RequestCloseDate { get; set; }
    }
}