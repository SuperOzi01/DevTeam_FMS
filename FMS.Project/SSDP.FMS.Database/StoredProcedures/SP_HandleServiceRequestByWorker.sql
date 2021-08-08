CREATE PROCEDURE [dbo].[SP_HandleServiceRequestByWorker]
	@BuildingNo INT,
	@RequestID INT
AS
	UPDATE dbo.ServiceRequest SET RequiestStatus = 4 
	WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID