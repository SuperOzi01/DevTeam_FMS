CREATE PROCEDURE [dbo].[SP_ChangeServiceRequestStatus]
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