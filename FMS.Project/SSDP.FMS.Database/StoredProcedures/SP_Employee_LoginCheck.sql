CREATE PROCEDURE [dbo].[SP_Employee_LoginCheck]
	@username varchar (40),
	@pass varchar (40)
AS
	IF EXISTS (SELECT 1 from dbo.CompanyEmployee where dbo.CompanyEmployee.Username = @username AND dbo.CompanyEmployee.Password = @pass) 
		BEGIN
			SELECT 1;
		END
	ELSE
		SELECT 0;
