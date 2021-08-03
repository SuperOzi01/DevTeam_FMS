﻿CREATE PROCEDURE [dbo].[SP_EmployeeResetPassAndActivateAccount]
	@password nchar(40),
	@EmployeeID INT
AS
	UPDATE dbo.CompanyEmployee SET Password = @password, AccountStatus = 1 
	WHERE dbo.CompanyEmployee.EmployeeID = @EmployeeID