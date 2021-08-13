CREATE PROCEDURE [dbo].[SP_CloseServiceRequest]
	@RequestID INT
AS
	UPDATE dbo.ServiceRequest SET RequestCloseDate = CURRENT_TIMESTAMP, 
	RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Close%')
	WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID 
	Select COUNT(1);