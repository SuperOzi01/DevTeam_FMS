CREATE PROCEDURE [dbo].[SP_GetBMClosedRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Close%')
	AND RequestView.BuildingID = @BuildingID