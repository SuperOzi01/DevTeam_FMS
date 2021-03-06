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
PRINT N'Creating Procedure [dbo].[SP_GetWorkersOfSpecialization]...';


GO
CREATE PROCEDURE [dbo].[SP_GetWorkersOfSpecialization]
	@SpecializationName varchar(40)
AS	
	Select [EmployeeID], [FirstName], [LastName] From dbo.CompanyEmployee 
	Where dbo.CompanyEmployee.AccountStatus = 1 AND dbo.CompanyEmployee.Specialization_idSpecialization = ( SELECt dbo.Specialization.SpecializationID From Dbo.Specialization Where dbo.Specialization.SpecializationName like @SpecializationName)
	AND dbo.CompanyEmployee.Role_idRole = ( Select dbo.Role.RoleID From Dbo.Role Where dbo.Role.RoleName like '%Maintenance Worker%')
GO
PRINT N'Update complete.';


GO
