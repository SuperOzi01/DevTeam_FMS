CREATE PROCEDURE [dbo].[SP_ActivateBeneficiaryAccount]
	@BeneficiaryUsername varchar(40)
AS
	IF EXISTS (Select 1 From dbo.Beneficiary where dbo.Beneficiary.Username = @BeneficiaryUsername)
		BEGIN
			UPDATE dbo.Beneficiary SET AccountStatus = 1 WHERE dbo.Beneficiary.Username = @BeneficiaryUsername;
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
