CREATE PROCEDURE [dbo].[SP_InsertCompanyEmployee]
	@username nchar(40),
	@password nchar(40),
	@SpecializationID INT, 
	@RoleID INT, 
	@LocationID INT, 
	@ManagerID INT

AS
	BEGIN
		INSERT INTO dbo.CompanyEmployee(Username, Password, Specialization_idSpecialization, Role_idRole, Location_idLocation, ManagerID)
		VALUES (@username, @password, @SpecializationID, @RoleID, @LocationID, @ManagerID)
	END