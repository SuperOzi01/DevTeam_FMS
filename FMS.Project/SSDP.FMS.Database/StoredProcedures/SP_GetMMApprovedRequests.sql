CREATE PROCEDURE [dbo].[SP_GetMMApprovedRequests]
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%MM Approve%')  