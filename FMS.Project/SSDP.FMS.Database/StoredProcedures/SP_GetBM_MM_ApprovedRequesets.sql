CREATE PROCEDURE [dbo].[SP_GetBM_MM_ApprovedRequesets]
	@BuildingID INT
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID 
										from dbo.RequestStatus 
										Where dbo.RequestStatus.StatusName like '%MM Approve%')
	AND RequestView.BuildingID = @BuildingID