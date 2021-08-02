CREATE TABLE [dbo].[ServiceRequest]
(
	[ServiceRequestID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BuildingID] INT NOT NULL, 
    [SpecializationID] INT NOT NULL, 
    [AssignedWorkerID] INT NULL, 
    [RequiestStatus] BIT NOT NULL, 
    [RequestHandlingStatus] BIT NOT NULL, 
    [RequestIssueDate] DATE NOT NULL DEFAULT GETDATE(), 
    [RequestCloseDate] DATE NOT NULL, 
    [ServiceDescribtion] NCHAR(100) NOT NULL, 
    CONSTRAINT [FK_ServiceRequest_Building] FOREIGN KEY ([BuildingID]) REFERENCES [Building]([BuildingID]), 
    CONSTRAINT [FK_ServiceRequest_Specialization] FOREIGN KEY ([SpecializationID]) REFERENCES [Specialization]([SpecializationID]), 
    CONSTRAINT [FK_ServiceRequest_CompanyEmployee] FOREIGN KEY ([AssignedWorkerID]) REFERENCES [CompanyEmployee]([EmployeeID])
)
