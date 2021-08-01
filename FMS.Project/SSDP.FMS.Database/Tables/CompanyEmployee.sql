﻿CREATE TABLE [dbo].[CompanyEmployee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(40) NOT NULL, 
    [Password] NCHAR(40) NOT NULL, 
    [Specialization_idSpecialization] INT NOT NULL, 
    [ManagerID] INT NULL, 
    [Location_idLocation] INT NOT NULL, 
    [Role_idRole] INT NOT NULL, 
    CONSTRAINT [FK_User_ManagerID] FOREIGN KEY ([ManagerID]) REFERENCES [CompanyEmployee]([EmployeeID]), 
    CONSTRAINT [FK_CompanyEmployee_RoleID] FOREIGN KEY ([Role_idRole]) REFERENCES [Role]([RoleID]), 
    CONSTRAINT [FK_CompanyEmployee_Location] FOREIGN KEY ([Location_idLocation]) REFERENCES [Location]([LocationID]), 
    CONSTRAINT [FK_CompanyEmployee_Specialization] FOREIGN KEY ([Specialization_idSpecialization]) REFERENCES [Specialization]([SpecializationID]), 
)