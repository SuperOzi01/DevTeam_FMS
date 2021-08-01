﻿/*
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
:setvar DefaultDataPath "C:\Users\zshar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\zshar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
PRINT N'Creating Procedure [dbo].[SP_InsertBeneficiary]...';


GO
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
GO
PRINT N'Creating Procedure [dbo].[SP_InsertCompanyEmployee]...';


GO
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
GO
PRINT N'Update complete.';


GO
