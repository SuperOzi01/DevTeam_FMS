CREATE PROCEDURE [dbo].[SP_HandleServiceRequestByWorker]
	@BuildingNo INT,
	@RequestID INT
AS
	UPDATE dbo.ServiceRequest SET RequestHandlingStatus = 1 
	WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID