CREATE PROCEDURE [dbo].[SP_AddBuilding]
	@NoFloors INT,
	@Ownership INT, 
	@ManagerID INT, 
	@LocationID INT
AS
	INSERT INTO dbo.Building(NoFloors, Ownership, BuildingManagerID, LocationID) VALUES (@NoFloors, @Ownership, @ManagerID, @LocationID)
	Select 1; 