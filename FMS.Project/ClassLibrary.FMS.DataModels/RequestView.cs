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
    
    public partial class RequestView
    {
        public int ServiceRequestID { get; set; }
        public int BuildingID { get; set; }
        public string Specialization_Type { get; set; }
        public string Assigned_Worker { get; set; }
        public int RequiestStatus { get; set; }
        public System.DateTime RequestIssueDate { get; set; }
        public Nullable<System.DateTime> RequestCloseDate { get; set; }
        public string ServiceDescribtion { get; set; }
        public string Request_Creator { get; set; }
    }
}
