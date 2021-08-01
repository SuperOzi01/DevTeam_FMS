CREATE TABLE [dbo].[Beneficiary]
(
	[BeneficiaryID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(40) NOT NULL, 
    [Password] NCHAR(40) NOT NULL, 
    [Building_BuildingID] INT NOT NULL, 
    [Role_RoleID] INT NOT NULL, 
    CONSTRAINT [FK_Beneficiary_Building] FOREIGN KEY ([Building_BuildingID]) REFERENCES [Building]([BuildingID]), 
    CONSTRAINT [FK_Beneficiary_Role] FOREIGN KEY ([Role_RoleID]) REFERENCES [Role]([RoleID])
)
