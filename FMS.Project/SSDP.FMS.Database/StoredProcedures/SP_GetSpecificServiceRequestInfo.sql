CREATE PROCEDURE [dbo].[SP_GetSpecificServiceRequestInfo]
	@RequestID INT
AS
	Select * from dbo.RequestView where dbo.RequestView.ServiceRequestID = @RequestID