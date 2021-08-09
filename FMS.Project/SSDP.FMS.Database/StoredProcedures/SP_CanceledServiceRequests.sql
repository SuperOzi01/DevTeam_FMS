CREATE PROCEDURE [dbo].[SP_CanceledServiceRequests]
AS
	Select * FROM RequestView Where dbo.RequestView.RequiestStatus = 5