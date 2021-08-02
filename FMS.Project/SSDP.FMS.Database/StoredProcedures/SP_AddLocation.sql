CREATE PROCEDURE [dbo].[SP_AddLocation]
	@CityName nchar (40)
AS
	IF NOT EXISTS (select 1 from dbo.Location where dbo.Location.City like @CityName)
		BEGIN
			INSERT INTO dbo.Location(City) VALUES (@CityName);
			SELECT 1;
		END
	ELSE
		BEGIN
			PRINT 'This City Already Exists';
			SELECT 0;
		END