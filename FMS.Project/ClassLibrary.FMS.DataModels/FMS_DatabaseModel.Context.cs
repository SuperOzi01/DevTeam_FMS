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
    
    public partial class FMS_DatabaseModel : DbContext
    {
        public FMS_DatabaseModel()
            : base("name=FMS_DatabaseModel")
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
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<ServiceRequest> ServiceRequests { get; set; }
        public virtual DbSet<View_BuildingAndLocationInfo> View_BuildingAndLocationInfo { get; set; }
    
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
    
        public virtual ObjectResult<Nullable<int>> SP_InsertBeneficiary(string username, string password, string email, Nullable<int> buildingID, Nullable<int> roleID)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var buildingIDParameter = buildingID.HasValue ?
                new ObjectParameter("BuildingID", buildingID) :
                new ObjectParameter("BuildingID", typeof(int));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_InsertBeneficiary", usernameParameter, passwordParameter, emailParameter, buildingIDParameter, roleIDParameter);
        }
    
        public virtual int SP_InsertCompanyEmployee(string username, string password, string email, Nullable<int> specializationID, Nullable<int> roleID, Nullable<int> locationID, Nullable<int> managerID)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCompanyEmployee", usernameParameter, passwordParameter, emailParameter, specializationIDParameter, roleIDParameter, locationIDParameter, managerIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddBuilding(Nullable<int> noFloors, Nullable<int> ownership, Nullable<int> managerID, Nullable<int> locationID)
        {
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddBuilding", noFloorsParameter, ownershipParameter, managerIDParameter, locationIDParameter);
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
    
        public virtual ObjectResult<Nullable<int>> SP_AddBuilding1(Nullable<int> noFloors, Nullable<int> ownership, Nullable<int> managerID, Nullable<int> locationID)
        {
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddBuilding1", noFloorsParameter, ownershipParameter, managerIDParameter, locationIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddLocation1(string cityName)
        {
            var cityNameParameter = cityName != null ?
                new ObjectParameter("CityName", cityName) :
                new ObjectParameter("CityName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddLocation1", cityNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_AddSpecialization1(string specializationName)
        {
            var specializationNameParameter = specializationName != null ?
                new ObjectParameter("SpecializationName", specializationName) :
                new ObjectParameter("SpecializationName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_AddSpecialization1", specializationNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_Employee_LoginCheck1(string username, string pass)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_Employee_LoginCheck1", usernameParameter, passParameter);
        }
    
        public virtual int SP_EmployeeLoginCheck(string username, string pass)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_EmployeeLoginCheck", usernameParameter, passParameter);
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
    
        public virtual ObjectResult<SP_GetAllSpecializations_Result> SP_GetAllSpecializations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllSpecializations_Result>("SP_GetAllSpecializations");
        }
    
        public virtual ObjectResult<Nullable<int>> SP_ActivateBeneficiaryAccount(Nullable<int> beneficiaryID)
        {
            var beneficiaryIDParameter = beneficiaryID.HasValue ?
                new ObjectParameter("BeneficiaryID", beneficiaryID) :
                new ObjectParameter("BeneficiaryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_ActivateBeneficiaryAccount", beneficiaryIDParameter);
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
    
        public virtual ObjectResult<SP_GetAllServiceRequests_Result> SP_GetAllServiceRequests()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllServiceRequests_Result>("SP_GetAllServiceRequests");
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
    
        public virtual ObjectResult<Nullable<int>> SP_InsertNewServiceRequiest(Nullable<int> buildinNo, Nullable<int> specialization, string describtion, Nullable<int> creatorID)
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
    
            var creatorIDParameter = creatorID.HasValue ?
                new ObjectParameter("CreatorID", creatorID) :
                new ObjectParameter("CreatorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_InsertNewServiceRequiest", buildinNoParameter, specializationParameter, describtionParameter, creatorIDParameter);
        }
    }
}
