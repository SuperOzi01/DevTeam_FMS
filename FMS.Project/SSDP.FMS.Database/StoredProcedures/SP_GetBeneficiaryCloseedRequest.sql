CREATE PROCEDURE [dbo].[SP_GetBeneficiaryCloseedRequest]
		@username varchar(40)
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = (select dbo.RequestStatus.RequestStatusID
										from dbo.RequestStatus Where dbo.RequestStatus.StatusName like '%Close%') 
	AND RequestView.Request_Creator = @username 