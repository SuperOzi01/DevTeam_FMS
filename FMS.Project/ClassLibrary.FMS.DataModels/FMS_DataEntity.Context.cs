﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FMS_DatabaseEntities : DbContext
    {
        public FMS_DatabaseEntities()
            : base("name=FMS_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<CompanyEmployee> CompanyEmployees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<RequestStatu> RequestStatus { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiceRequest> ServiceRequests { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<View_BuildingAndLocationInfo> View_BuildingAndLocationInfo { get; set; }
        public virtual DbSet<RequestView> RequestViews { get; set; }
    
        public virtual ObjectResult<Nullable<int>> SP_ActivateBeneficiaryAccount(string beneficiaryUsername)
        {
            var beneficiaryUsernameParameter = beneficiaryUsername != null ?
                new ObjectParameter("BeneficiaryUsername", beneficiaryUsername) :
                new ObjectParameter("BeneficiaryUsername", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_ActivateBeneficiaryAccount", beneficiaryUsernameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddBuilding(Nullable<int> buildingID, Nullable<int> noFloors, Nullable<int> ownership, Nullable<int> managerID, Nullable<int> locationID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            var noFloorsParameter = noFloors.HasValue ?
                new ObjectParameter("NoFloors", noFloors) :
                new ObjectParameter("NoFloors", typeof(int));
    
            var ownershipParameter = ownership.HasValue ?
                new ObjectParameter("Ownership", ownership) :
                new ObjectParameter("Ownership", typeof(int));
    
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddBuilding", buildingIDParameter, noFloorsParameter, ownershipParameter, managerIDParameter, locationIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddLocation(string cityName)
        {
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddLocation", cityNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddSpecialization(string specializationName)
        {
            var specializationNameParameter = specializationName != null ?
                new ObjectParameter("SpecializationName", specializationName) :
                new ObjectParameter("SpecializationName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddSpecialization", specializationNameParameter);
        }
    
        public virtual int SP_AssignWorkerToRequest(Nullable<int> workerID, Nullable<int> requestID)
        {
            var workerIDParameter = workerID.HasValue ?
                new ObjectParameter("WorkerID", workerID) :
                new ObjectParameter("WorkerID", typeof(int));
    
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AssignWorkerToRequest", workerIDParameter, requestIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Ben_LoginCheck(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Ben_LoginCheck", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_ChangeServiceRequestStatus(string employeeUsername, Nullable<int> requestID)
        {
            var employeeUsernameParameter = employeeUsername != null ?
                new ObjectParameter("EmployeeUsername", employeeUsername) :
                new ObjectParameter("EmployeeUsername", typeof(string));
    
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_ChangeServiceRequestStatus", employeeUsernameParameter, requestIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Employee_LoginCheck(string username, string pass)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Employee_LoginCheck", usernameParameter, passParameter);
        }
    
        public virtual int SP_EmployeeResetPassAndActivateAccount(string password, string employeeUsername)
        {
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var employeeUsernameParameter = employeeUsername != null ?
                new ObjectParameter("EmployeeUsername", employeeUsername) :
                new ObjectParameter("EmployeeUsername", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_EmployeeResetPassAndActivateAccount", passwordParameter, employeeUsernameParameter);
        }
    
        public virtual ObjectResult<SP_GetAllBuildings_Result> SP_GetAllBuildings()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllBuildings_Result>("SP_GetAllBuildings");
        }
    
        public virtual ObjectResult<SP_GetAllLocations_Result> SP_GetAllLocations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllLocations_Result>("SP_GetAllLocations");
        }
    
        public virtual ObjectResult<SP_GetAllRoles_Result> SP_GetAllRoles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllRoles_Result>("SP_GetAllRoles");
        }
    
        public virtual ObjectResult<SP_GetAllServiceRequests_Result> SP_GetAllServiceRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllServiceRequests_Result>("SP_GetAllServiceRequests");
        }
    
        public virtual ObjectResult<SP_GetAllSpecializations_Result> SP_GetAllSpecializations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllSpecializations_Result>("SP_GetAllSpecializations");
        }
    
        public virtual ObjectResult<string> SP_GetUserRoles(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_GetUserRoles", usernameParameter);
        }
    
        public virtual int SP_HandleServiceRequestByWorker(Nullable<int> buildingNo, Nullable<int> requestID)
        {
            var buildingNoParameter = buildingNo.HasValue ?
                new ObjectParameter("BuildingNo", buildingNo) :
                new ObjectParameter("BuildingNo", typeof(int));
    
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_HandleServiceRequestByWorker", buildingNoParameter, requestIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_InsertBeneficiary(string username, string password, string firstName, string lastName, string email, Nullable<int> buildingID)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_InsertBeneficiary", usernameParameter, passwordParameter, firstNameParameter, lastNameParameter, emailParameter, buildingIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_InsertCompanyEmployee(string username, string password, string firstName, string lastName, string email, Nullable<int> specializationID, Nullable<int> roleID, Nullable<int> locationID, Nullable<int> managerID)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var specializationIDParameter = specializationID.HasValue ?
                new ObjectParameter("SpecializationID", specializationID) :
                new ObjectParameter("SpecializationID", typeof(int));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_InsertCompanyEmployee", usernameParameter, passwordParameter, firstNameParameter, lastNameParameter, emailParameter, specializationIDParameter, roleIDParameter, locationIDParameter, managerIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_InsertNewServiceRequiest(Nullable<int> buildinNo, Nullable<int> specialization, string describtion, string creatorUsername)
        {
            var buildinNoParameter = buildinNo.HasValue ?
                new ObjectParameter("BuildinNo", buildinNo) :
                new ObjectParameter("BuildinNo", typeof(int));
    
            var specializationParameter = specialization.HasValue ?
                new ObjectParameter("Specialization", specialization) :
                new ObjectParameter("Specialization", typeof(int));
    
            var describtionParameter = describtion != null ?
                new ObjectParameter("Describtion", describtion) :
                new ObjectParameter("Describtion", typeof(string));
    
            var creatorUsernameParameter = creatorUsername != null ?
                new ObjectParameter("CreatorUsername", creatorUsername) :
                new ObjectParameter("CreatorUsername", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_InsertNewServiceRequiest", buildinNoParameter, specializationParameter, describtionParameter, creatorUsernameParameter);
        }
    
        public virtual ObjectResult<SP_GetMMOpenRequests_Result> SP_GetMMOpenRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetMMOpenRequests_Result>("SP_GetMMOpenRequests");
        }
    
        public virtual ObjectResult<SP_GetMMClosedRequests_Result> SP_GetMMClosedRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetMMClosedRequests_Result>("SP_GetMMClosedRequests");
        }
    
        public virtual ObjectResult<SP_CanceledServiceRequests_Result> SP_CanceledServiceRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CanceledServiceRequests_Result>("SP_CanceledServiceRequests");
        }
    
        public virtual ObjectResult<SP_GetSpecificServiceRequestInfo_Result> SP_GetSpecificServiceRequestInfo(Nullable<int> requestID)
        {
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetSpecificServiceRequestInfo_Result>("SP_GetSpecificServiceRequestInfo", requestIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Cancel_OpenedServiceRequest(Nullable<int> requestID)
        {
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Cancel_OpenedServiceRequest", requestIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_CloseServiceRequest(Nullable<int> requestID)
        {
            var requestIDParameter = requestID.HasValue ?
                new ObjectParameter("RequestID", requestID) :
                new ObjectParameter("RequestID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_CloseServiceRequest", requestIDParameter);
        }
    
        public virtual ObjectResult<SP_GetAllCanceledRequests_Result> SP_GetAllCanceledRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllCanceledRequests_Result>("SP_GetAllCanceledRequests");
        }
    
        public virtual ObjectResult<SP_GetMMApprovedRequests_Result> SP_GetMMApprovedRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetMMApprovedRequests_Result>("SP_GetMMApprovedRequests");
        }
    
        public virtual ObjectResult<SP_GetWorkersOfSpecialization_Result> SP_GetWorkersOfSpecialization(string specializationName)
        {
            var specializationNameParameter = specializationName != null ?
                new ObjectParameter("SpecializationName", specializationName) :
                new ObjectParameter("SpecializationName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetWorkersOfSpecialization_Result>("SP_GetWorkersOfSpecialization", specializationNameParameter);
        }
    
        public virtual ObjectResult<SP_GetWorkerOpenRequests_Result> SP_GetWorkerOpenRequests(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetWorkerOpenRequests_Result>("SP_GetWorkerOpenRequests", usernameParameter);
        }
    
        public virtual ObjectResult<SP_BMCanceledRequests_Result> SP_BMCanceledRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMCanceledRequests_Result>("SP_BMCanceledRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMClosedRequests_Result> SP_BMClosedRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMClosedRequests_Result>("SP_BMClosedRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMOpenRequests_Result> SP_BMOpenRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMOpenRequests_Result>("SP_BMOpenRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_GetWorkerClosedRequests_Result> SP_GetWorkerClosedRequests(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetWorkerClosedRequests_Result>("SP_GetWorkerClosedRequests", usernameParameter);
        }
    
        public virtual ObjectResult<SP_GetBeneficiaryCanceledRequests_Result> SP_GetBeneficiaryCanceledRequests(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBeneficiaryCanceledRequests_Result>("SP_GetBeneficiaryCanceledRequests", usernameParameter);
        }
    
        public virtual ObjectResult<SP_GetBeneficiaryCloseedRequest_Result> SP_GetBeneficiaryCloseedRequest(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBeneficiaryCloseedRequest_Result>("SP_GetBeneficiaryCloseedRequest", usernameParameter);
        }
    
        public virtual ObjectResult<SP_GetBeneficiaryOpenRequests_Result> SP_GetBeneficiaryOpenRequests(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBeneficiaryOpenRequests_Result>("SP_GetBeneficiaryOpenRequests", usernameParameter);
        }
    
        public virtual ObjectResult<SP_GetBMOpenedRequests_Result> SP_GetBMOpenedRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBMOpenedRequests_Result>("SP_GetBMOpenedRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_TestDB()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_TestDB");
        }
    
        public virtual ObjectResult<SP_GetBM_MM_ApprovedRequesets_Result> SP_GetBM_MM_ApprovedRequesets(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBM_MM_ApprovedRequesets_Result>("SP_GetBM_MM_ApprovedRequesets", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_GetBMCanceledRequests_Result> SP_GetBMCanceledRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBMCanceledRequests_Result>("SP_GetBMCanceledRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_GetBMClosedRequests_Result> SP_GetBMClosedRequests(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetBMClosedRequests_Result>("SP_GetBMClosedRequests", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMCanceledRequests1_Result> SP_BMCanceledRequests1(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMCanceledRequests1_Result>("SP_BMCanceledRequests1", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMClosedRequests1_Result> SP_BMClosedRequests1(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMClosedRequests1_Result>("SP_BMClosedRequests1", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMOpenRequests1_Result> SP_BMOpenRequests1(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMOpenRequests1_Result>("SP_BMOpenRequests1", buildingIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_GetNumberOfBeneficiaries()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_GetNumberOfBeneficiaries");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_GetNumberOfClosedRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_GetNumberOfClosedRequests");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_GetNumberOfOpenedRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_GetNumberOfOpenedRequests");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_GetWorkersNumber()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_GetWorkersNumber");
        }
    
        public virtual ObjectResult<SP_ListOfNotActiveBeneficiaries_Result> SP_ListOfNotActiveBeneficiaries(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListOfNotActiveBeneficiaries_Result>("SP_ListOfNotActiveBeneficiaries", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_GetCompanyEmployeesList_Result> SP_GetCompanyEmployeesList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCompanyEmployeesList_Result>("SP_GetCompanyEmployeesList");
        }
    
        public virtual ObjectResult<SP_MaintananceManagersList_Result> SP_MaintananceManagersList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_MaintananceManagersList_Result>("SP_MaintananceManagersList");
        }
    
        public virtual ObjectResult<SP_BMCanceledRequests2_Result> SP_BMCanceledRequests2(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMCanceledRequests2_Result>("SP_BMCanceledRequests2", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMClosedRequests2_Result> SP_BMClosedRequests2(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMClosedRequests2_Result>("SP_BMClosedRequests2", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMOpenRequests2_Result> SP_BMOpenRequests2(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMOpenRequests2_Result>("SP_BMOpenRequests2", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMCanceledRequests3_Result> SP_BMCanceledRequests3(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMCanceledRequests3_Result>("SP_BMCanceledRequests3", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMClosedRequests3_Result> SP_BMClosedRequests3(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMClosedRequests3_Result>("SP_BMClosedRequests3", buildingIDParameter);
        }
    
        public virtual ObjectResult<SP_BMOpenRequests3_Result> SP_BMOpenRequests3(Nullable<int> buildingID)
        {
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_BMOpenRequests3_Result>("SP_BMOpenRequests3", buildingIDParameter);
        }
    }
}
