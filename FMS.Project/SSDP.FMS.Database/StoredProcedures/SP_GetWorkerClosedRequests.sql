CREATE PROCEDURE [dbo].[SP_GetWorkerClosedRequests]
	@username varchar(40)
AS
	Select * FROM dbo.RequestView 
	WHERE dbo.RequestView.Assigned_Worker like @username
	AND dbo.RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus 
											Where dbo.RequestStatus.StatusName like '%Close%')