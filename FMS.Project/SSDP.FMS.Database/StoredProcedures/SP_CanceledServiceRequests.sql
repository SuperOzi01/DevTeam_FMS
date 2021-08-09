CREATE PROCEDURE [dbo].[SP_CanceledServiceRequests]
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Cancel%')

	