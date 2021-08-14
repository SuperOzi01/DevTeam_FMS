CREATE PROCEDURE [dbo].[SP_InsertCompanyEmployee]
	@username varchar(40),
	@password varchar(40),
	@FirstName varchar(40),
	@LastName varchar(40),
	@Email varchar(40),
	@SpecializationID INT, 
	@RoleID INT, 
	@LocationID INT, 
	@ManagerID INT

AS
    IF NOT EXISTS (Select Username from dbo.CompanyEmployee where dbo.CompanyEmployee.Username = @username OR dbo.CompanyEmployee.Email like @Email)
	    BEGIN
			INSERT INTO dbo.CompanyEmployee(Username, Password,FirstName,LastName ,Email, Specialization_idSpecialization, Role_idRole, Location_idLocation, ManagerID)
			VALUES (@username, @password,@FirstName,@LastName ,@Email, @SpecializationID, @RoleID, @LocationID, @ManagerID)
			SELECT 1;
	    END
	ELSE
		BEGIN
			SELECT 0; 
		END
