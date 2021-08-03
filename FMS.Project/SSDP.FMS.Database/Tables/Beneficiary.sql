﻿CREATE TABLE [dbo].[Beneficiary]
(
	[BeneficiaryID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(40) NOT NULL Unique, 
    [Password] NCHAR(40) NOT NULL, 
    [FirstName] NCHAR(40) NOT NULL,
    [LastName] NCHAR(40) NOT NULL,
    [Email] NCHAR(40) NOT NULL Unique, 
    [Building_BuildingID] INT NOT NULL, 
    [Role_RoleID] INT NOT NULL, 
    [AccountStatus] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Beneficiary_Building] FOREIGN KEY ([Building_BuildingID]) REFERENCES [Building]([BuildingID]), 
    CONSTRAINT [FK_Beneficiary_Role] FOREIGN KEY ([Role_RoleID]) REFERENCES [Role]([RoleID])
)
