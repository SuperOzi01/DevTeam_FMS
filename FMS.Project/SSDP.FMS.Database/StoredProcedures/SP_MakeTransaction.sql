CREATE PROCEDURE [dbo].[SP_MakeTransaction]
	@TransactionMakerUsername varchar(40),
	@TransactionServiceRequestID INT,
	@Decision Bit 
AS
	INSERT INTO dbo.Transactions(TransActionMakerUsername, TransactionServiceID, TransactionDecision)
	VALUES(@TransactionMakerUsername, @TransactionServiceRequestID, @Decision)