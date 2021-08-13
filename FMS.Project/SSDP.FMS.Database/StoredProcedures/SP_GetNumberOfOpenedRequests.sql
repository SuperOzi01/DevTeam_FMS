CREATE PROCEDURE [dbo].[SP_GetNumberOfOpenedRequests]
AS
	SELECT COUNT(dbo.RequestView.ServiceRequestID) FROM dbo.RequestView 
	WHERE dbo.RequestView.RequiestStatus = (SELECT dbo.RequestStatus.RequestStatusID FROM dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Open%')