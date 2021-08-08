using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.FMS.DataModels;
using ClassLibrary.FMS.DataModels.Models;

namespace ClassLibrary.FMS.DatabaseOperations
{
    public class LoginOperations
    {
        FMS_DatabaseEntities DatabaseEntity = new FMS_DatabaseEntities();
        public bool LoginBackOffice(LoginModel login)
        {
            // TODO: Call the Employees DB to check the user to make it the log in the same page {x}
            var employeesLoginCheck = DatabaseEntity.SP_Employee_LoginCheck(login.Username, login.Password);            
            if (employeesLoginCheck.FirstOrDefault() == 1)
                return true; // Employee is registred 
            else
                return false; // Employee not found 
        }

        public bool LoginPortal(LoginModel login)
        {
            // TODO: Call the Employees DB to check the user to make it the log in the same page {x}
            var beneficiaryLoginCheck = DatabaseEntity.SP_Ben_LoginCheck(login.Username, login.Password);
            if (beneficiaryLoginCheck.FirstOrDefault() == 1)
                return true; // beneficiary is registred 
            else
                return false; // beneficiary not found 
        }



        public bool BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            var result = DatabaseEntity.SP_InsertBeneficiary(BeneficiaryRegistraion.Username,
                BeneficiaryRegistraion.Password,
                BeneficiaryRegistraion.FirstName,
                BeneficiaryRegistraion.LastName,
                BeneficiaryRegistraion.Email,
                BeneficiaryRegistraion.BuildingID);
            DatabaseEntity.SaveChanges();
            if (result.FirstOrDefault() == 1)
                return true;
            else
                return false; 
        }

        public bool EmployeeRegistraion (EmployeeRegistraionModel EmployeeRegistraion)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            var result = DatabaseEntity.SP_InsertCompanyEmployee(EmployeeRegistraion.Username,
                EmployeeRegistraion.Password,
                EmployeeRegistraion.FirstName,
                EmployeeRegistraion.LastName,
                EmployeeRegistraion.Email,
                EmployeeRegistraion.SpecializationID,
                EmployeeRegistraion.RoleID,
                EmployeeRegistraion.LocationID,
                EmployeeRegistraion.ManagerID);
            if (result.FirstOrDefault() == 1)
                return true;
            else
                return false;
        }

        public List<Building> GetBuildingList()
        {
            
            var BuildingList = DatabaseEntity.Buildings.Select(a => a);
            return BuildingList.ToList();
        }

        public List<Specialization> GetSpecializationList()
        {
            var SpecializationList = DatabaseEntity.Specializations.Select(a => a);
            return SpecializationList.ToList();
        }
        public List<CompanyEmployee> GetManagerList()
        {
            var ManagerList = DatabaseEntity.CompanyEmployees.Select(a => a);
            return ManagerList.ToList();
        }
        public List<Location> GetLocationList()
        {
            var LocationList = DatabaseEntity.Locations.Select(a => a);
            return LocationList.ToList();
        }
        public List<Role> GetRoleList()
        {
            var RoleList = DatabaseEntity.Roles.Select(a => a);
            return RoleList.ToList();
        }

        public string GetUserRole(LoginModel loginModel)
        {
            var Role = DatabaseEntity.SP_GetUserRoles(loginModel.Username).FirstOrDefault().ToString();
            return Role;
        }
        public bool GetBeneficiaryAccountStatus(LoginModel loginModel)
        {
            bool status = DatabaseEntity.Beneficiaries.Where( x => x.Username == loginModel.Username).Select(a => a.AccountStatus).FirstOrDefault();
            return status;
        }

        public bool GetCompanyEmployeeAccountStatus(LoginModel loginModel)
        {
            bool status = DatabaseEntity.CompanyEmployees.Where(x => x.Username == loginModel.Username).Select(a => a.AccountStatus).FirstOrDefault();
            return status;
        }

        public bool UpdateBackOfficeAccountPasswordAndStatus(UpdatePasswordModel updateModel)
        {
            int result = DatabaseEntity.SP_EmployeeResetPassAndActivateAccount(updateModel.Password, updateModel.Username);
            if (result == 1)
                return true;
            return false; 
        }

        public bool PortalActivateBeneficiaryAccount(LoginModel login)
        {
            DatabaseEntity.SP_ActivateBeneficiaryAccount(login.Username);
            return true;
        }


    }
}
