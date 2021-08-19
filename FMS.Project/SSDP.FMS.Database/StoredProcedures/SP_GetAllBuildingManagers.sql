CREATE PROCEDURE [dbo].[SP_GetAllBuildingManagers]
AS
	SELECT [EmployeeID], [FirstName], [LastName] FROM dbo.CompanyEmployee 
	WHERE dbo.CompanyEmployee.Role_idRole = (Select dbo.Role.RoleID from dbo.Role Where dbo.Role.RoleName like '%Building Manager%')
