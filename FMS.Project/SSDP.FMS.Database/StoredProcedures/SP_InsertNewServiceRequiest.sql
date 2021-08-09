CREATE PROCEDURE [dbo].[SP_InsertNewServiceRequiest]
	@BuildinNo INT,
	@Specialization INT,
	@Describtion varchar(100),
	@CreatorID INT
AS
	IF NOT EXISTS (SELECT 1 from dbo.ServiceRequest where dbo.ServiceRequest.BuildingID = @BuildinNo AND dbo.ServiceRequest.SpecializationID = @Specialization AND dbo.ServiceRequest.RequiestStatus = ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Open%'))
		BEGIN
			INSERT INTO dbo.ServiceRequest(BuildingID, SpecializationID, ServiceDescribtion,RequestCreatorID, RequiestStatus)
			Values (@BuildinNo, @Specialization, @Describtion, @CreatorID, ( Select dbo.RequestStatus.RequestStatusID From dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%open%'));
			SELECT 1;
		END
	ELSE
		BEGIN
			SELECT 0;
		END
