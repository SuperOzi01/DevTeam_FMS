CREATE PROCEDURE [dbo].[SP_BMOpenRequests]
	@BuildingID INT
AS
	Select * from RequestView Where RequestView.BuildingID = @BuildingID AND RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%BM Approve%')