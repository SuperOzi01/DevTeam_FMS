CREATE PROCEDURE [dbo].[SP_GetMMOpenRequests]
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%BM Approve%')  
	