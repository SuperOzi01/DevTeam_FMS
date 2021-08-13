CREATE PROCEDURE [dbo].[SP_InsertNewServiceRequiest]
	@BuildinNo INT,
	@Specialization INT,
	@Describtion varchar(100),
	@CreatorUsername varchar(40)
AS
	Declare @creatorID AS INT
	Select @creatorID = dbo.Beneficiary.BeneficiaryID FROM dbo.Beneficiary WHERE dbo.Beneficiary.Username = @CreatorUsername

	IF NOT EXISTS(
	SELECT 1 FROM dbo.ServiceRequest 
	WHERE dbo.ServiceRequest.BuildingID = @BuildinNo 
	AND dbo.ServiceRequest.SpecializationID = @Specialization 
	AND dbo.ServiceRequest.RequiestStatus = (SELECT dbo.RequestStatus.RequestStatusID FROM dbo.RequestStatus WHERE dbo.RequestStatus.StatusName like '%Open%')  
	)
	Begin
		INSERT INTO dbo.ServiceRequest(BuildingID, SpecializationID, ServiceDescribtion, RequestCreatorID)
		VALUES (@BuildinNo, @Specialization, @Describtion, @creatorID)
		SELECT 1;
	End
	ELSE
	BEGIN
		SELECT 0;
	END