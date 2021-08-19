CREATE PROCEDURE [dbo].[SP_MakeTransaction]
	@TransactionMakerID INT,
	@TransactionServiceRequestID INT,
	@Decision Bit 
AS
	INSERT INTO dbo.Transactions(TransActionMakerID, TransactionServiceID, TransactionDecision)
	VALUES(@TransactionMakerID, @TransactionServiceRequestID, @Decision)