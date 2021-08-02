CREATE PROCEDURE [dbo].[SP_AddSpecialization]
	@SpecializationName nchar (40)
AS
		IF NOT EXISTS (select 1 from dbo.Specialization where dbo.Specialization.SpecializationName like @SpecializationName)
		BEGIN
			INSERT INTO dbo.Specialization(SpecializationName) VALUES (@SpecializationName);
			SELECT 1;
		END
	ELSE
		BEGIN
			PRINT 'This Specialization Already Exists';
			SELECT 0;
		END