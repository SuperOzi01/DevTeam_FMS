CREATE PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username nchar (40),
	@Password nchar (40), 
	@FirstName nchar (40), 
	@LastName nchar (40), 
	@Email nchar (40), 
	@BuildingID INT
AS
	IF NOT EXISTS (Select Username from dbo.Beneficiary where dbo.Beneficiary.Username = @Username)
		Begin
			INSERT INTO dbo.Beneficiary(Username, Password, FirstName,LastName ,Email, Building_BuildingID, Role_RoleID)
			VALUES (@Username, @Password,@FirstName,@LastName ,@Email,@BuildingID, (Select RoleID from dbo.Role where dbo.Role.RoleName = 'Tenant'))
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0; 
		END
