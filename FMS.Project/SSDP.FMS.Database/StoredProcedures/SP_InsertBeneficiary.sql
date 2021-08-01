CREATE PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username nchar (40),
	@Password nchar (40), 
	@BuildingID INT,
	@RoleID INT
AS
	BEGIN
		INSERT INTO dbo.Beneficiary(Username, Password, Building_BuildingID, Role_RoleID)
		VALUES (@Username, @Password, @BuildingID, @RoleID)
	END
