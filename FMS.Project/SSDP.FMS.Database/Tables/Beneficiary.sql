CREATE TABLE [dbo].[Beneficiary]
(
	[BeneficiaryID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(40) NOT NULL Unique, 
    [Password] VARCHAR(40) NOT NULL, 
    [FirstName] VARCHAR(40) NOT NULL,
    [LastName] VARCHAR(40) NOT NULL,
    [Email] VARCHAR(40) NOT NULL Unique, 
    [Building_BuildingID] INT NOT NULL, 
    [Role_RoleID] INT NOT NULL, 
    [AccountStatus] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Beneficiary_Building] FOREIGN KEY ([Building_BuildingID]) REFERENCES [Building]([BuildingID]), 
    CONSTRAINT [FK_Beneficiary_Role] FOREIGN KEY ([Role_RoleID]) REFERENCES [Role]([RoleID])
)
