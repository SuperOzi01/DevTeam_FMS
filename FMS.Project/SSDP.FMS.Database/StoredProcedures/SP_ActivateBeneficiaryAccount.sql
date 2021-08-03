CREATE PROCEDURE [dbo].[SP_ActivateBeneficiaryAccount]
	@BeneficiaryID INT
AS
	IF EXISTS (Select 1 From dbo.Beneficiary where dbo.Beneficiary.BeneficiaryID = @BeneficiaryID)
		BEGIN
			UPDATE dbo.Beneficiary SET AccountStatus = 1 WHERE dbo.Beneficiary.BeneficiaryID = @BeneficiaryID;
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
