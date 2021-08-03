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
:setvar DefaultDataPath "C:\Users\Rana Alhamdan\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Rana Alhamdan\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
PRINT N'Altering Procedure [dbo].[SP_InsertBeneficiary]...';


GO
ALTER PROCEDURE [dbo].[SP_InsertBeneficiary]
	@Username nchar (40),
	@Password nchar (40), 
	@FirstName nchar (40), 
	@LastName nchar (40), 
	@Email nchar (40), 
	@BuildingID INT
AS
	IF NOT EXISTS (Select Username from dbo.Beneficiary where dbo.Beneficiary.Username = @Username)
		Begin
			Select RoleID from dbo.Role where dbo.Role.RoleName = 'Tenant'
			INSERT INTO dbo.Beneficiary(Username, Password, FirstName,LastName ,Email, Building_BuildingID, Role_RoleID)
			VALUES (@Username, @Password,@FirstName,@LastName ,@Email,@BuildingID, (Select RoleID from dbo.Role where dbo.Role.RoleName = 'Tenant'))
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0; 
		END
GO
PRINT N'Update complete.';


GO
