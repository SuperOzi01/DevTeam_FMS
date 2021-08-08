CREATE PROCEDURE [dbo].[SP_GetMMOpenRequests]
AS
	Select * FROM RequestView
	WHERE RequestView.RequiestStatus = 2  
	