CREATE PROCEDURE [dbo].[SP_GetBMCanceledRequests]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%Cancel%')
	AND RequestView.BuildingID = @BuildingID