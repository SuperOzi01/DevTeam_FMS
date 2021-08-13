CREATE PROCEDURE [dbo].[SP_GetNumberOfBeneficiaries]
AS
	SELECT COUNT(dbo.Beneficiary.Username) FROM dbo.Beneficiary WHERE dbo.Beneficiary.AccountStatus = 1