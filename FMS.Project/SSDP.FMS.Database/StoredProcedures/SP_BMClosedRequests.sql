CREATE PROCEDURE [dbo].[SP_BMClosedRequests]
	@BuildingID INT
AS
	Select * from RequestView Where RequestView.BuildingID = @BuildingID AND RequestView.RequiestStatus = (Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Close%')