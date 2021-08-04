CREATE TABLE [dbo].[CompanyEmployee]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NCHAR(40) NOT NULL Unique, 
    [Password] NCHAR(40) NOT NULL,
    [FirstName] NCHAR(40) NOT NULL, 
    [LastName] NCHAR(40) NOT NULL, 
    [Email] NCHAR(40) NOT NULL Unique, 
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
