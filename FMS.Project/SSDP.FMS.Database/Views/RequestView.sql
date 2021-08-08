CREATE VIEW [dbo].[RequestView]
	AS 
	Select [ServiceRequestID],
	[BuildingID],
	dbo.Specialization.SpecializationName AS Specialization_Type,
	dbo.CompanyEmployee.Username AS Assigned_Worker,
	[RequiestStatus],
	[RequestIssueDate],
	[RequestCloseDate],
	[ServiceDescribtion],
	dbo.Beneficiary.Username AS Request_Creator
	FROM dbo.ServiceRequest LEFT JOIN dbo.CompanyEmployee ON dbo.ServiceRequest.AssignedWorkerID = dbo.CompanyEmployee.EmployeeID 
	LEFT JOIN dbo.Specialization ON dbo.Specialization.SpecializationID = dbo.ServiceRequest.SpecializationID
	LEFT JOIN dbo.Beneficiary ON dbo.ServiceRequest.RequestCreatorID = dbo.Beneficiary.BeneficiaryID
	