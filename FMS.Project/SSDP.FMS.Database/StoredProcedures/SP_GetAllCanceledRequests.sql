CREATE PROCEDURE [dbo].[SP_GetAllCanceledRequests]
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Cancel%')  	