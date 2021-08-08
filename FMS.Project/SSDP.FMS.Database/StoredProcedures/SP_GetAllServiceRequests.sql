CREATE PROCEDURE [dbo].[SP_GetAllServiceRequests]
AS
	SELECT Req.ServiceRequestID, 
	Ben.Username,
	Special.SpecializationName, 
	Req.ServiceDescribtion, 
	BuildingInfo.BuildingID, 
	BuildingInfo.City, 
	BuildingInfo.NoFloors, 
	BuildingInfo.BuildingManagerID,
	Req.RequiestStatus,
	Req.RequestIssueDate,
	Req.RequestCloseDate 
	from dbo.ServiceRequest AS Req LEFT JOIN dbo.Specialization AS Special on Req.SpecializationID = Special.SpecializationID
	LEFT JOIN dbo.Beneficiary AS Ben ON Req.RequestCreatorID = Ben.BeneficiaryID
	LEFT JOIN dbo.View_BuildingAndLocationInfo AS BuildingInfo ON BuildingInfo.BuildingID = Req.BuildingID

	
