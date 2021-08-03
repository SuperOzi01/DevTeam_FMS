CREATE TABLE [dbo].[Building]
(
	[BuildingID] INT NOT NULL , 
    [NoFloors] INT NOT NULL, 
    [Ownership] INT NOT NULL, 
    [BuildingManagerID] INT NOT NULL, 
    [LocationID] INT NOT NULL, 
    CONSTRAINT [FK_Building_CompanyEmployee] FOREIGN KEY ([BuildingManagerID]) REFERENCES [CompanyEmployee]([EmployeeID]), 
    CONSTRAINT [FK_Building_Location] FOREIGN KEY ([LocationID]) REFERENCES [Location]([LocationID]), 
    CONSTRAINT [PK_Building] PRIMARY KEY ([BuildingID])
)
