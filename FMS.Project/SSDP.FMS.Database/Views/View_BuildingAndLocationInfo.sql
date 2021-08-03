CREATE VIEW [dbo].[View_BuildingAndLocationInfo]
	AS SELECT [dbo].[Building].[BuildingID], [dbo].[Building].[NoFloors],
	[dbo].[Building].[Ownership], [dbo].[Building].[BuildingManagerID],
	[dbo].[Location].[City] FROM dbo.Building Left JOIN dbo.Location on dbo.Building.LocationID = dbo.Location.LocationID
