CREATE PROCEDURE [dbo].[SP_GetMMClosedRequests]
	
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Close%')  