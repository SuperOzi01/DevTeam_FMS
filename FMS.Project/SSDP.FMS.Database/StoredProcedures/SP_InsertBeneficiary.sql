CREATE PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username nchar (40),
	@Password nchar (40), 
	@Email nchar (40), 
	@BuildingID INT,
	@RoleID INT
AS
	IF NOT EXISTS (Select Username from dbo.Beneficiary where dbo.Beneficiary.Username = @Username)
		Begin
			INSERT INTO dbo.Beneficiary(Username, Password, Email, Building_BuildingID, Role_RoleID)
			VALUES (@Username, @Password, @Email,@BuildingID, @RoleID)
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0; 
		END
