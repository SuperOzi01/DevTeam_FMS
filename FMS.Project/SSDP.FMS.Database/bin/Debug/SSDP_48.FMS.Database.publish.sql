/*
Deployment script for FMS_Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FMS_Database"
:setvar DefaultFilePrefix "FMS_Database"
:setvar DefaultDataPath "C:\Users\alano\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\alano\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The type for column Email in table [dbo].[Beneficiary] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column FirstName in table [dbo].[Beneficiary] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column LastName in table [dbo].[Beneficiary] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column Password in table [dbo].[Beneficiary] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column Username in table [dbo].[Beneficiary] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[Beneficiary])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The type for column Email in table [dbo].[CompanyEmployee] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column FirstName in table [dbo].[CompanyEmployee] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column LastName in table [dbo].[CompanyEmployee] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column Password in table [dbo].[CompanyEmployee] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.

The type for column Username in table [dbo].[CompanyEmployee] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[CompanyEmployee])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The type for column City in table [dbo].[Location] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[Location])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The type for column RoleName in table [dbo].[Role] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[Role])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The type for column ServiceDescribtion in table [dbo].[ServiceRequest] is currently  NCHAR (100) NOT NULL but is being changed to  VARCHAR (100) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (100) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[ServiceRequest])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
/*
The type for column SpecializationName in table [dbo].[Specialization] is currently  NCHAR (40) NOT NULL but is being changed to  VARCHAR (40) NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  VARCHAR (40) NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[Specialization])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Dropping Unique Constraint unnamed constraint on [dbo].[Beneficiary]...';


GO
ALTER TABLE [dbo].[Beneficiary] DROP CONSTRAINT [UQ__Benefici__A9D105346E02C92D];


GO
PRINT N'Dropping Unique Constraint unnamed constraint on [dbo].[Beneficiary]...';


GO
ALTER TABLE [dbo].[Beneficiary] DROP CONSTRAINT [UQ__Benefici__536C85E484B6FF5C];


GO
PRINT N'Dropping Unique Constraint unnamed constraint on [dbo].[CompanyEmployee]...';


GO
ALTER TABLE [dbo].[CompanyEmployee] DROP CONSTRAINT [UQ__CompanyE__A9D10534ACA387E5];


GO
PRINT N'Dropping Unique Constraint unnamed constraint on [dbo].[CompanyEmployee]...';


GO
ALTER TABLE [dbo].[CompanyEmployee] DROP CONSTRAINT [UQ__CompanyE__536C85E41FDAF7AB];


GO
PRINT N'Altering Table [dbo].[Beneficiary]...';


GO
ALTER TABLE [dbo].[Beneficiary] ALTER COLUMN [Email] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[Beneficiary] ALTER COLUMN [FirstName] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[Beneficiary] ALTER COLUMN [LastName] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[Beneficiary] ALTER COLUMN [Password] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[Beneficiary] ALTER COLUMN [Username] VARCHAR (40) NOT NULL;


GO
PRINT N'Creating Unique Constraint unnamed constraint on [dbo].[Beneficiary]...';


GO
ALTER TABLE [dbo].[Beneficiary]
    ADD UNIQUE NONCLUSTERED ([Email] ASC);


GO
PRINT N'Creating Unique Constraint unnamed constraint on [dbo].[Beneficiary]...';


GO
ALTER TABLE [dbo].[Beneficiary]
    ADD UNIQUE NONCLUSTERED ([Username] ASC);


GO
PRINT N'Altering Table [dbo].[CompanyEmployee]...';


GO
ALTER TABLE [dbo].[CompanyEmployee] ALTER COLUMN [Email] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[CompanyEmployee] ALTER COLUMN [FirstName] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[CompanyEmployee] ALTER COLUMN [LastName] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[CompanyEmployee] ALTER COLUMN [Password] VARCHAR (40) NOT NULL;

ALTER TABLE [dbo].[CompanyEmployee] ALTER COLUMN [Username] VARCHAR (40) NOT NULL;


GO
PRINT N'Creating Unique Constraint unnamed constraint on [dbo].[CompanyEmployee]...';


GO
ALTER TABLE [dbo].[CompanyEmployee]
    ADD UNIQUE NONCLUSTERED ([Email] ASC);


GO
PRINT N'Creating Unique Constraint unnamed constraint on [dbo].[CompanyEmployee]...';


GO
ALTER TABLE [dbo].[CompanyEmployee]
    ADD UNIQUE NONCLUSTERED ([Username] ASC);


GO
PRINT N'Altering Table [dbo].[Location]...';


GO
ALTER TABLE [dbo].[Location] ALTER COLUMN [City] VARCHAR (40) NOT NULL;


GO
PRINT N'Altering Table [dbo].[Role]...';


GO
ALTER TABLE [dbo].[Role] ALTER COLUMN [RoleName] VARCHAR (40) NOT NULL;


GO
PRINT N'Altering Table [dbo].[ServiceRequest]...';


GO
ALTER TABLE [dbo].[ServiceRequest] ALTER COLUMN [ServiceDescribtion] VARCHAR (100) NOT NULL;


GO
PRINT N'Altering Table [dbo].[Specialization]...';


GO
ALTER TABLE [dbo].[Specialization] ALTER COLUMN [SpecializationName] VARCHAR (40) NOT NULL;


GO
PRINT N'Refreshing View [dbo].[View_BuildingAndLocationInfo]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[View_BuildingAndLocationInfo]';


GO
PRINT N'Altering Procedure [dbo].[SP_Ben_LoginCheck]...';


GO
ALTER PROCEDURE [dbo].[SP_Ben_LoginCheck]
	@username varchar (40),
	@password varchar (40)
AS
		IF EXISTS ( SELECT 1 from dbo.Beneficiary where dbo.Beneficiary.Username = @username AND dbo.Beneficiary.Password = @password AND dbo.Beneficiary.AccountStatus = 1)
			BEGIN 
				Select 1;
			END 
		ELSE 
			Begin
				Select 0;
			ENd
GO
PRINT N'Altering Procedure [dbo].[SP_GetUserRoles]...';


GO
ALTER PROCEDURE [dbo].[SP_GetUserRoles]
	@username varchar(40)
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
GO
PRINT N'Altering Procedure [dbo].[SP_InsertBeneficiary]...';


GO
ALTER PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username varchar (40),
	@Password varchar (40), 
	@FirstName varchar (40), 
	@LastName varchar (40), 
	@Email varchar (40), 
	@BuildingID INT
AS
	IF NOT EXISTS (Select Username from dbo.Beneficiary where dbo.Beneficiary.Username = @Username)
		Begin
			INSERT INTO dbo.Beneficiary(Username, Password, FirstName,LastName ,Email, Building_BuildingID, Role_RoleID)
			VALUES (@Username, @Password,@FirstName,@LastName ,@Email,@BuildingID, (Select RoleID from dbo.Role where dbo.Role.RoleName = 'Beneficiary'))
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0; 
		END
GO
PRINT N'Altering Procedure [dbo].[SP_Employee_LoginCheck]...';


GO
ALTER PROCEDURE [dbo].[SP_Employee_LoginCheck]
	@username varchar (40),
	@pass varchar (40)
AS
	IF EXISTS (SELECT 1 from dbo.CompanyEmployee where dbo.CompanyEmployee.Username = @username AND dbo.CompanyEmployee.Password = @pass) 
		BEGIN
			SELECT 1;
		END
	ELSE
		SELECT 0;
GO
PRINT N'Altering Procedure [dbo].[SP_EmployeeResetPassAndActivateAccount]...';


GO
ALTER PROCEDURE [dbo].[SP_EmployeeResetPassAndActivateAccount]
	@password varchar(40),
	@EmployeeID INT
AS
	UPDATE dbo.CompanyEmployee SET Password = @password, AccountStatus = 1 
	WHERE dbo.CompanyEmployee.EmployeeID = @EmployeeID
GO
PRINT N'Altering Procedure [dbo].[SP_InsertCompanyEmployee]...';


GO
ALTER PROCEDURE [dbo].[SP_InsertCompanyEmployee]
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
    IF NOT EXISTS (Select Username from dbo.CompanyEmployee where dbo.CompanyEmployee.Username = @username)
	    BEGIN
			INSERT INTO dbo.CompanyEmployee(Username, Password,FirstName,LastName ,Email, Specialization_idSpecialization, Role_idRole, Location_idLocation, ManagerID)
			VALUES (@username, @password,@FirstName,@LastName ,@Email, @SpecializationID, @RoleID, @LocationID, @ManagerID)
			SELECT 1;
	    END
	ELSE
		BEGIN
			SELECT 0; 
		END
GO
PRINT N'Altering Procedure [dbo].[SP_AddLocation]...';


GO
ALTER PROCEDURE [dbo].[SP_AddLocation]
	@CityName varchar (40)
AS
	IF NOT EXISTS (select 1 from dbo.Location where dbo.Location.City like @CityName)
		BEGIN
			INSERT INTO dbo.Location(City) VALUES (@CityName);
			SELECT 1;
		END
	ELSE
		BEGIN
			PRINT 'This City Already Exists';
			SELECT 0;
		END
GO
PRINT N'Altering Procedure [dbo].[SP_InsertNewServiceRequiest]...';


GO
ALTER PROCEDURE [dbo].[SP_InsertNewServiceRequiest]
	@BuildinNo INT,
	@Specialization INT,
	@Describtion varchar(100),
	@CreatorID INT
AS
	IF NOT EXISTS (SELECT 1 from dbo.ServiceRequest where dbo.ServiceRequest.BuildingID = @BuildinNo AND dbo.ServiceRequest.SpecializationID = @Specialization AND dbo.ServiceRequest.RequiestStatus = 1)
		BEGIN
			INSERT INTO dbo.ServiceRequest(BuildingID, SpecializationID, ServiceDescribtion,RequestCreatorID)
			Values (@BuildinNo, @Specialization, @Describtion, @CreatorID);
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
GO
PRINT N'Altering Procedure [dbo].[SP_AddSpecialization]...';


GO
ALTER PROCEDURE [dbo].[SP_AddSpecialization]
	@SpecializationName varchar (40)
AS
		IF NOT EXISTS (select 1 from dbo.Specialization where dbo.Specialization.SpecializationName like @SpecializationName)
		BEGIN
			INSERT INTO dbo.Specialization(SpecializationName) VALUES (@SpecializationName);
			SELECT 1;
		END
	ELSE
		BEGIN
			PRINT 'This Specialization Already Exists';
			SELECT 0;
		END
GO
PRINT N'Refreshing Procedure [dbo].[SP_ActivateBeneficiaryAccount]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_ActivateBeneficiaryAccount]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_GetAllServiceRequests]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_GetAllServiceRequests]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_GetAllLocations]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_GetAllLocations]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_GetAllRoles]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_GetAllRoles]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_AssignWorkerToRequest]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_AssignWorkerToRequest]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_HandleServiceRequestByWorker]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_HandleServiceRequestByWorker]';


GO
PRINT N'Refreshing Procedure [dbo].[SP_GetAllSpecializations]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[SP_GetAllSpecializations]';


GO
PRINT N'Update complete.';


GO
