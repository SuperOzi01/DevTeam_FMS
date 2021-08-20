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
PRINT N'Dropping Default Constraint unnamed constraint on [dbo].[ServiceRequest]...';


GO
ALTER TABLE [dbo].[ServiceRequest] DROP CONSTRAINT [DF__ServiceRe__Reque__7AF13DF7];


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[ServiceRequest]...';


GO
ALTER TABLE [dbo].[ServiceRequest]
    ADD DEFAULT CURRENT_TIMESTAMP FOR [RequestIssueDate];


GO
PRINT N'Creating Procedure [dbo].[SP_GetAllBuildingManagers]...';


GO
CREATE PROCEDURE [dbo].[SP_GetAllBuildingManagers]
AS
	SELECT [EmployeeID], [FirstName], [LastName] FROM dbo.CompanyEmployee 
	WHERE dbo.CompanyEmployee.Role_idRole = (Select dbo.Role.RoleID from dbo.Role Where dbo.Role.RoleName like '%Building Manager%')
GO
PRINT N'Update complete.';


GO