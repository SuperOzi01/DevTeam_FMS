CREATE PROCEDURE [dbo].[SP_GetCompanyEmployeesList]
AS
	SELECT 
	dbo.CompanyEmployee.EmployeeID,
	dbo.CompanyEmployee.FirstName,
	dbo.CompanyEmployee.LastName,
	dbo.CompanyEmployee.Email,
	dbo.Role.RoleName
	FROM dbo.CompanyEmployee Inner JOIN dbo.Role 
	on dbo.CompanyEmployee.Role_idRole = dbo.Role.RoleID