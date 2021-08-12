CREATE PROCEDURE [dbo].[SP_GetBMOpenedRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Open%')
	AND RequestView.BuildingID = @BuildingID