CREATE PROCEDURE [dbo].[SP_AddBuilding]
	@BuildingID INT,
	@NoFloors INT,
	@Ownership int, 
	@ManagerID INT, 
	@LocationID INT
AS
	IF NOT EXISTS (Select 1 FROM dbo.Building Where dbo.Building.BuildingID = @BuildingID)
	Begin
		INSERT INTO dbo.Building( BuildingID,NoFloors, Ownership, BuildingManagerID, LocationID)
		VALUES (@BuildingID, @NoFloors, @Ownership, @ManagerID, @LocationID)
		Select 1; 
	End
	ELSE
	BEGIN
		SELECT 0;
	END