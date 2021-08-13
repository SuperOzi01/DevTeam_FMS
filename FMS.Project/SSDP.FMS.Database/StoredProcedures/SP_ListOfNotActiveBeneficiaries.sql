CREATE PROCEDURE [dbo].[SP_ListOfNotActiveBeneficiaries]
	@BuildingID INT
AS
	SELECT * FROM dbo.Beneficiary Where dbo.Beneficiary.AccountStatus = 0 
	AND dbo.Beneficiary.Building_BuildingID = @BuildingID;