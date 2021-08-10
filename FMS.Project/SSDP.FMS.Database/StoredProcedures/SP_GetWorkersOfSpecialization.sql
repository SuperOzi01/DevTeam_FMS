CREATE PROCEDURE [dbo].[SP_GetWorkersOfSpecialization]
	@SpecializationName varchar(40)
AS	
	Select [EmployeeID], [FirstName], [LastName] From dbo.CompanyEmployee 
	Where dbo.CompanyEmployee.AccountStatus = 1 AND dbo.CompanyEmployee.Specialization_idSpecialization = ( SELECt dbo.Specialization.SpecializationID From Dbo.Specialization Where dbo.Specialization.SpecializationName like @SpecializationName)
	AND dbo.CompanyEmployee.Role_idRole = ( Select dbo.Role.RoleID From Dbo.Role Where dbo.Role.RoleName like '%Maintenance Worker%')
