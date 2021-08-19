CREATE TABLE [dbo].[Transactions]
(
	[TransactionID] INT NOT NULL PRIMARY KEY, 
    [TransActionMakerID] INT NOT NULL, 
    [TransactionDecision] BIT NOT NULL, 
    [TransactionDate] DATETIME NOT NULL DEFAULT Getdate(), 
    [TransactionServiceID] INT NOT NULL, 
    CONSTRAINT [FK_Transactions_CompanyEmployee] FOREIGN KEY ([TransActionMakerID]) REFERENCES [CompanyEmployee]([EmployeeID]), 
    CONSTRAINT [FK_Transactions_ServiceRequest] FOREIGN KEY ([TransactionServiceID]) REFERENCES [ServiceRequest]([ServiceRequestID])
)
