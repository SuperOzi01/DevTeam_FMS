CREATE PROCEDURE [dbo].[SP_Cancel_OpenedServiceRequest]
	@RequestID INT
AS
	UPDATE dbo.ServiceRequest SET RequestCloseDate = CURRENT_TIMESTAMP, 
	RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Cancel%')
	WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID 
	Select COUNT(1);