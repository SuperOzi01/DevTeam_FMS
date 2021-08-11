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
PRINT N'Creating Procedure [dbo].[SP_BMCanceledRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_BMCanceledRequests]
	@BuildingID INT
AS
	Select * from RequestView Where RequestView.BuildingID = @BuildingID AND RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Cancel%')
GO
PRINT N'Creating Procedure [dbo].[SP_BMClosedRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_BMClosedRequests]
	@BuildingID INT
AS
	Select * from RequestView Where RequestView.BuildingID = @BuildingID AND RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Close%')
GO
PRINT N'Creating Procedure [dbo].[SP_BMOpenRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_BMOpenRequests]
	@BuildingID INT
AS
	Select * from RequestView Where RequestView.BuildingID = @BuildingID AND RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%BM Approve%')
GO
PRINT N'Creating Procedure [dbo].[SP_GetWorkerClosedRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetWorkerClosedRequests]
	@username varchar(40)
AS
	Select * FROM dbo.RequestView 
	WHERE dbo.RequestView.Assigned_Worker like @username
	AND dbo.RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus 
											Where dbo.RequestStatus.StatusName like '%Close%')
GO
PRINT N'Update complete.';


GO