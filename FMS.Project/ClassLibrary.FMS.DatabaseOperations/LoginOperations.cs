using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.FMS.DataModels; 
namespace ClassLibrary.FMS.DatabaseOperations
{
    public class LoginOperations
    {
        FMS_DatabaseModel DatabaseEntity = new FMS_DatabaseModel();
        public bool Login(LoginModel login)
        {
            // TODO: Call the Employees DB to check the user to make it the log in the same page {x}
            var beneficiaryLoginCheck = DatabaseEntity.SP_Ben_LoginCheck(login.Username, login.Password);
            var employeesLoginCheck = DatabaseEntity.SP_Employee_LoginCheck(login.Username, login.Password);            
            if (beneficiaryLoginCheck.FirstOrDefault() == 1 || employeesLoginCheck.FirstOrDefault() == 1)
                return true; // Beneficiary is registred 
            else
                return false; // Beneficiary not found 
        }


        public bool BeneficiaryRegistraion(BeneficiaryRegistraionModel BeneficiaryRegistraion)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            var result = DatabaseEntity.SP_InsertBeneficiary(BeneficiaryRegistraion.Username,
                BeneficiaryRegistraion.Password,
                BeneficiaryRegistraion.Email,
                BeneficiaryRegistraion.BuildingID,
                BeneficiaryRegistraion.RoleID);
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
                EmployeeRegistraion.Email,
                EmployeeRegistraion.SpecializationID,
                EmployeeRegistraion.RoleID,
                EmployeeRegistraion.LocationID,
                EmployeeRegistraion.ManagerID);
            DatabaseEntity.SaveChanges();
            if (result == 1)
                return true;
            else
                return false;
        }


    }
}
