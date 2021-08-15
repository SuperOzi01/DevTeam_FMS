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
            EncryptionModel encryptionModel = new EncryptionModel();
            string EncryptedPassword = encryptionModel.EncryptPassword(login.Password);

            var employeesLoginCheck = DatabaseEntity.SP_Employee_LoginCheck(login.Username, EncryptedPassword);            
            if (employeesLoginCheck.FirstOrDefault() == 1)
                return true; // Employee is registred 
            else
                return false; // Employee not found 
        }

        public bool LoginPortal(LoginModel login)
        {
            // TODO: Call the Employees DB to check the user to make it the log in the same page {x}
            EncryptionModel encryptionModel = new EncryptionModel();
            string EncryptedPassword = encryptionModel.EncryptPassword(login.Password);

            var beneficiaryLoginCheck = DatabaseEntity.SP_Ben_LoginCheck(login.Username, EncryptedPassword);
            if (beneficiaryLoginCheck.FirstOrDefault() == 1)
                return true; // beneficiary is registred 
            else
                return false; // beneficiary not found 
        }

        public int TestDB()
        {
            var result = DatabaseEntity.SP_TestDB().FirstOrDefault().ToString();
            int num;
            Int32.TryParse(result, out num);
            return num;
        }

        public bool BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            EncryptionModel encryptionModel = new EncryptionModel();
            string EncryptedPassword = encryptionModel.EncryptPassword(BeneficiaryRegistraion.Password);
            var result = DatabaseEntity.SP_InsertBeneficiary(BeneficiaryRegistraion.Username,
                EncryptedPassword,
                BeneficiaryRegistraion.FirstName,
                BeneficiaryRegistraion.LastName,
                BeneficiaryRegistraion.Email,
                BeneficiaryRegistraion.BuildingID);
            if (result.FirstOrDefault() == 1)
                return true;
            else
                return false; 
        }

        public bool EmployeeRegistraion (EmployeeRegistraionModel EmployeeRegistraion)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            EncryptionModel encryptionModel = new EncryptionModel();
            string EncryptedPassword = encryptionModel.EncryptPassword(EmployeeRegistraion.Password);


            var result = DatabaseEntity.SP_InsertCompanyEmployee(EmployeeRegistraion.Username,
                EncryptedPassword,
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

        public List<SP_GetAllBuildings_Result> GetBuildingList()
        {
            
            List<SP_GetAllBuildings_Result> BuildingList = DatabaseEntity.SP_GetAllBuildings().ToList();
            return BuildingList;
        }

        public List<SP_GetAllSpecializations_Result> GetSpecializationList()
        {
            var SpecializationList = DatabaseEntity.SP_GetAllSpecializations().ToList();
            return SpecializationList;
        }

        public List<SP_MaintananceManagersList_Result> GetManagerList()
        {
            var ManagerList = DatabaseEntity.SP_MaintananceManagersList().ToList();
            return ManagerList;
        }

        public List<SP_GetAllLocations_Result> GetLocationList()
        {
            var LocationList = DatabaseEntity.SP_GetAllLocations().ToList();
            return LocationList;
        }

        public List<SP_GetAllRoles_Result> GetRoleList()
        {
            var RoleList = DatabaseEntity.SP_GetAllRoles().ToList();
            return RoleList;
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

        


    }
}
