CREATE PROCEDURE [dbo].[SP_GetMMClosedRequests]
	
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = 4