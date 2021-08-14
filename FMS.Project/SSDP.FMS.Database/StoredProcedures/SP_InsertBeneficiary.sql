CREATE PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username varchar (40),
	@Password varchar (40), 
	@FirstName varchar (40), 
	@LastName varchar (40), 
	@Email varchar (40), 
	@BuildingID INT
AS
	IF NOT EXISTS (Select Username from dbo.Beneficiary where dbo.Beneficiary.Username = @Username OR dbo.Beneficiary.Email like @Email)
		Begin
			INSERT INTO dbo.Beneficiary(Username, Password, FirstName,LastName ,Email, Building_BuildingID, Role_RoleID)
			VALUES (@Username, @Password,@FirstName,@LastName ,@Email,@BuildingID, (Select RoleID from dbo.Role where dbo.Role.RoleName like '%Beneficiary%'))
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0; 
		END
