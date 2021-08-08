CREATE PROCEDURE [dbo].[SP_EmployeeResetPassAndActivateAccount]
	@password varchar(40),
	@EmployeeUsername varchar(40)
AS
	UPDATE dbo.CompanyEmployee SET Password = @password, AccountStatus = 1 
	WHERE dbo.CompanyEmployee.Username = @EmployeeUsername