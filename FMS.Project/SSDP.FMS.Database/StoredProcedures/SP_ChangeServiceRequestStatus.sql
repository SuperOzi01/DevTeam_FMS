CREATE PROCEDURE [dbo].[SP_ChangeServiceRequestStatus]
	@Username varchar(40),
	@RequestID INT
AS
	DECLARE @Role AS Varchar(40)


	SELECT @Role = dbo.Role.RoleName FROM dbo.Role 
	Where dbo.Role.RoleID = (SELECT dbo.CompanyEmployee.Role_idRole FROM dbo.CompanyEmployee WHERE dbo.CompanyEmployee.Username = @Username)

	IF (@Role like 'Maintenance Manager')
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = 3 WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END
	ELSE IF (@Role like 'Building Manager')
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = 2 WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END
	ELSE
		BEGIN
			UPDATE dbo.ServiceRequest SET RequiestStatus = 4 WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID
			SELECT CAST(1 AS INT)
		END