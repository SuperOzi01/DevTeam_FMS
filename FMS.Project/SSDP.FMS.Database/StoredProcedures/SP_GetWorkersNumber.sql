CREATE PROCEDURE [dbo].[SP_GetWorkersNumber]
AS
	Select COUNT(dbo.CompanyEmployee.Username) From dbo.CompanyEmployee WHERE dbo.CompanyEmployee.AccountStatus = 1