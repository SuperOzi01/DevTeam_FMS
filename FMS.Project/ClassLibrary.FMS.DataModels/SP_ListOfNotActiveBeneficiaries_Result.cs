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
    
    public partial class SP_ListOfNotActiveBeneficiaries_Result
    {
        public int BeneficiaryID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Building_BuildingID { get; set; }
        public int Role_RoleID { get; set; }
        public bool AccountStatus { get; set; }
    }
}