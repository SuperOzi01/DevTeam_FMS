CREATE TABLE [dbo].[Transactions]
(
	[TransactionID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TransActionMakerUsername] VARCHAR(40) NOT NULL, 
    [TransactionDecision] BIT NOT NULL, 
    [TransactionDate] DATETIME NOT NULL DEFAULT Getdate(), 
    [TransactionServiceID] INT NOT NULL, 
    CONSTRAINT [FK_Transactions_CompanyEmployee] FOREIGN KEY ([TransActionMakerUsername]) REFERENCES [CompanyEmployee]([Username]), 
    CONSTRAINT [FK_Transactions_ServiceRequest] FOREIGN KEY ([TransactionServiceID]) REFERENCES [ServiceRequest]([ServiceRequestID])
)
