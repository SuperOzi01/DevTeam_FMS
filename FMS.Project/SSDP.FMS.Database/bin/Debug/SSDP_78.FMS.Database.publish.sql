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
PRINT N'Altering Procedure [dbo].[SP_ChangeServiceRequestStatus]...';


GO
ALTER PROCEDURE [dbo].[SP_ChangeServiceRequestStatus]
	@WorkerID INT,
	@RequestID INT
AS
	DECLARE @Role AS Varchar(40)


	SELECT @Role = dbo.Role.RoleName FROM dbo.Role 
	Where dbo.Role.RoleID = (SELECT dbo.CompanyEmployee.Role_idRole FROM dbo.CompanyEmployee WHERE dbo.CompanyEmployee.EmployeeID = @WorkerID)

	IF (@Role like 'Maintenance Manager')
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%MM Approve%') WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END
	ELSE IF (@Role like 'Building Manager')
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%BM Approve%') WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END
	ELSE
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Close%') WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END
GO
PRINT N'Creating Procedure [dbo].[SP_GetBeneficiaryCanceledRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBeneficiaryCanceledRequests]
		@username varchar(40)
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID
										from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Cancel%') 
	AND RequestView.Request_Creator = @username
GO
PRINT N'Creating Procedure [dbo].[SP_GetBeneficiaryCloseedRequest]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBeneficiaryCloseedRequest]
		@username varchar(40)
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID
										from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Close%') 
	AND RequestView.Request_Creator = @username
GO
PRINT N'Creating Procedure [dbo].[SP_GetBeneficiaryOpenRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBeneficiaryOpenRequests]
	@username varchar(40)
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID
										from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Open%') 
	AND RequestView.Request_Creator = @username
GO
PRINT N'Creating Procedure [dbo].[SP_GetBM_MM_ApprovedRequesets]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBM_MM_ApprovedRequesets]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%MM Approve%')
	AND RequestView.BuildingID = @BuildingID
GO
PRINT N'Creating Procedure [dbo].[SP_GetBMCanceledRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBMCanceledRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Cancel%')
	AND RequestView.BuildingID = @BuildingID
GO
PRINT N'Creating Procedure [dbo].[SP_GetBMClosedRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBMClosedRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Close%')
	AND RequestView.BuildingID = @BuildingID
GO
PRINT N'Creating Procedure [dbo].[SP_GetBMOpenedRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetBMOpenedRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Open%')
	AND RequestView.BuildingID = @BuildingID
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
PRINT N'Creating Procedure [dbo].[SP_GetWorkerOpenRequests]...';


GO
CREATE PROCEDURE [dbo].[SP_GetWorkerOpenRequests]
	@username varchar(40)
AS
	Select * FROM dbo.RequestView WHERE dbo.RequestView.Assigned_Worker like @username AND dbo.RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%MM Approve%')
GO
PRINT N'Creating Procedure [dbo].[SP_TestDB]...';


GO
CREATE PROCEDURE [dbo].[SP_TestDB]
AS
	Select 1;
GO
PRINT N'Update complete.';


GO
