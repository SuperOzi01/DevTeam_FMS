CREATE PROCEDURE [dbo].[SP_MaintananceManagersList]
AS
	Select dbo.CompanyEmployee.EmployeeID, dbo.CompanyEmployee.FirstName, dbo.CompanyEmployee.LastName
	FROM dbo.CompanyEmployee Where dbo.CompanyEmployee.Role_idRole = (SELECT dbo.Role.RoleID FROM dbo.Role WHERE dbo.Role.RoleName like '%Maintenance Manager%')