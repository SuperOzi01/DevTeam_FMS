CREATE PROCEDURE [dbo].[SP_GetUserRoles]
	@username nchar(40)
AS
	IF EXISTS (Select 1 from dbo.Beneficiary WHERE dbo.Beneficiary.Username = @username)
		BEGIN
			SELECT dbo.Role.RoleName FROM dbo.Role 
			WHERE dbo.Role.RoleID = ( SELECT dbo.Beneficiary.Role_RoleID FROM dbo.Beneficiary
			WHERE dbo.Beneficiary.Username = @username )
		END
	ELSE
		BEGIN
			SELECT dbo.Role.RoleName FROM dbo.Role 
			WHERE dbo.Role.RoleID = ( SELECT dbo.CompanyEmployee.Role_idRole FROM dbo.CompanyEmployee
			WHERE dbo.CompanyEmployee.Username = @username )
		END