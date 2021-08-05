CREATE TABLE [dbo].[CompanyEmployee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] VARCHAR(40) NOT NULL Unique, 
    [Password] VARCHAR(40) NOT NULL,
    [FirstName] VARCHAR(40) NOT NULL, 
    [LastName] VARCHAR(40) NOT NULL, 
    [Email] VARCHAR(40) NOT NULL Unique, 
    [Specialization_idSpecialization] INT NOT NULL, 
    [ManagerID] INT NULL, 
    [Location_idLocation] INT NOT NULL, 
    [Role_idRole] INT NOT NULL, 
    [AccountStatus] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_User_ManagerID] FOREIGN KEY ([ManagerID]) REFERENCES [CompanyEmployee]([EmployeeID]), 
    CONSTRAINT [FK_CompanyEmployee_RoleID] FOREIGN KEY ([Role_idRole]) REFERENCES [Role]([RoleID]), 
    CONSTRAINT [FK_CompanyEmployee_Location] FOREIGN KEY ([Location_idLocation]) REFERENCES [Location]([LocationID]), 
    CONSTRAINT [FK_CompanyEmployee_Specialization] FOREIGN KEY ([Specialization_idSpecialization]) REFERENCES [Specialization]([SpecializationID]), 
)
