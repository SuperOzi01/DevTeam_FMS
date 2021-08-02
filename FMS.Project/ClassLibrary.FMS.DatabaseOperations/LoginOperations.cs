﻿using System;
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
        public bool Login(LoginModel loginModel)
        {
            // TODO: Call the Employees DB to check the user to make it the log in the same page {x}
            var employeesLoginCheck = DatabaseEntity.SP_Employee_LoginCheck(loginModel.Username, loginModel.Password);
            var beneficiaryLoginCheck = DatabaseEntity.SP_Ben_LoginCheck(loginModel.Username, loginModel.Password);
            if (beneficiaryLoginCheck.FirstOrDefault() == 1 || employeesLoginCheck.FirstOrDefault() == 1)
                return true; // Beneficiary is registred 
            else
                return false; // Beneficiary not found 
        }


        public bool RegisterBeneficiary(string username, string password, string email, int BuildingID, int RoleID)
        {
            // RoleID is  set by the Developers Based on the registration page { System Admin , Beneficary Portal} pages
            // RoleID of 5 is Tenent ... 6 is Outsider Employee Based on the UI 
            var result = DatabaseEntity.SP_InsertBeneficiary(username, password, email, BuildingID, RoleID);
            if (result.FirstOrDefault() == 1)
                return true;
            else
                return false; 
        }

        
    }
}
