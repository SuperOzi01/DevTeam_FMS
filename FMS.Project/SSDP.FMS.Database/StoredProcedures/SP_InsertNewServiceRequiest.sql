CREATE PROCEDURE [dbo].[SP_InsertNewServiceRequiest]
	@BuildinNo INT,
	@Specialization INT,
	@Describtion varchar(100),
	@CreatorID INT
AS
	IF NOT EXISTS (SELECT 1 from dbo.ServiceRequest where dbo.ServiceRequest.BuildingID = @BuildinNo AND dbo.ServiceRequest.SpecializationID = @Specialization AND dbo.ServiceRequest.RequiestStatus = 1)
		BEGIN
			INSERT INTO dbo.ServiceRequest(BuildingID, SpecializationID, ServiceDescribtion,RequestCreatorID)
			Values (@BuildinNo, @Specialization, @Describtion, @CreatorID);
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
