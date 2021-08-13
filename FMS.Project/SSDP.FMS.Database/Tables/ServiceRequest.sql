CREATE TABLE [dbo].[ServiceRequest]
(
	[ServiceRequestID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BuildingID] INT NOT NULL, 
    [SpecializationID] INT NOT NULL, 
    [AssignedWorkerID] INT NULL, 
    [RequiestStatus] INT NOT NULL DEFAULT 1, 
    [RequestIssueDate] DATE NOT NULL DEFAULT CURRENT_TIMESTAMP, 
    [RequestCloseDate] DATE NULL, 
    [ServiceDescribtion] VARCHAR(100) NOT NULL, 
    [RequestCreatorID] INT NOT NULL, 
    CONSTRAINT [FK_ServiceRequest_Building] FOREIGN KEY ([BuildingID]) REFERENCES [Building]([BuildingID]), 
    CONSTRAINT [FK_ServiceRequest_Specialization] FOREIGN KEY ([SpecializationID]) REFERENCES [Specialization]([SpecializationID]), 
    CONSTRAINT [FK_ServiceRequest_CompanyEmployee] FOREIGN KEY ([AssignedWorkerID]) REFERENCES [CompanyEmployee]([EmployeeID]), 
    CONSTRAINT [FK_ServiceRequest_Beneficiary] FOREIGN KEY ([RequestCreatorID]) REFERENCES [Beneficiary]([BeneficiaryID])
)
