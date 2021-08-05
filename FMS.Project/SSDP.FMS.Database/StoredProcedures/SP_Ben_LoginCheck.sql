CREATE PROCEDURE [dbo].[SP_Ben_LoginCheck]
	@username varchar (40),
	@password varchar (40)
AS
		IF EXISTS ( SELECT 1 from dbo.Beneficiary where dbo.Beneficiary.Username = @username AND dbo.Beneficiary.Password = @password AND dbo.Beneficiary.AccountStatus = 1)
			BEGIN 
				Select 1;
			END 
		ELSE 
			Begin
				Select 0;
			ENd
