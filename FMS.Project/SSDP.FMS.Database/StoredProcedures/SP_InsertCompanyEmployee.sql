CREATE PROCEDURE [dbo].[SP_InsertCompanyEmployee]
	@username nchar(40),
	@password nchar(40),
	@Email nchar(40),
	@SpecializationID INT, 
	@RoleID INT, 
	@LocationID INT, 
	@ManagerID INT

AS
    IF NOT EXISTS (Select Username from dbo.CompanyEmployee where dbo.CompanyEmployee.Username = @username)
	    BEGIN
			INSERT INTO dbo.CompanyEmployee(Username, Password, Email, Specialization_idSpecialization, Role_idRole, Location_idLocation, ManagerID)
			VALUES (@username, @password, @Email, @SpecializationID, @RoleID, @LocationID, @ManagerID)
			SELECT 1;
	    END
	ELSE
		BEGIN
			SELECT 0; 
		END
