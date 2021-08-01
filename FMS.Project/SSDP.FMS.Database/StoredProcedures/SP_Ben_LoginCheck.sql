CREATE PROCEDURE [dbo].[SP_Ben_LoginCheck]
	@username nchar (40),
	@password nchar (40)
AS
		IF EXISTS ( SELECT 1 from dbo.Beneficiary where dbo.Beneficiary.Username = @username AND dbo.Beneficiary.Password = @password )
			BEGIN 
				Select 1;
			END 
		ELSE 
			Begin
				Select 0;
			ENd
