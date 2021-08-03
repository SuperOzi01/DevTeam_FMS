CREATE PROCEDURE [dbo].[SP_AddBuilding]
	@BuildingID INT,
	@NoFloors INT,
	@Ownership INT, 
	@ManagerID INT, 
	@LocationID INT
AS
	INSERT INTO dbo.Building( BuildingID,NoFloors, Ownership, BuildingManagerID, LocationID)
	VALUES (@BuildingID, @NoFloors, @Ownership, @ManagerID, @LocationID)
	Select 1; 