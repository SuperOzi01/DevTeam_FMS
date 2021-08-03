CREATE PROCEDURE [dbo].[SP_AssignWorkerToRequest]
	@WorkerID INT,
	@RequestID INT
AS
	Update dbo.ServiceRequest SET AssignedWorkerID = @WorkerID 
	WHERE dbo.ServiceRequest.ServiceRequestID = @RequestID