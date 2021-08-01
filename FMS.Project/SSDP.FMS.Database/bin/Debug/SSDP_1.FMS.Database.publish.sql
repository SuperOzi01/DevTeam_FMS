﻿/*
Deployment script for FMS_Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FMS_Database"
:setvar DefaultFilePrefix "FMS_Database"
:setvar DefaultDataPath "C:\Users\zshar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\zshar\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Rename refactoring operation with key a52c3e5e-af6c-4541-99c1-550f059ceca1 is skipped, element [dbo].[Building].[Id] (SqlSimpleColumn) will not be renamed to BuildingID';


GO
PRINT N'Rename refactoring operation with key ad692faf-1fc4-472d-8232-52784ef9187e is skipped, element [dbo].[Location].[Id] (SqlSimpleColumn) will not be renamed to LocationID';


GO
PRINT N'Rename refactoring operation with key 134eba03-a441-4194-b788-fcfbabac2823 is skipped, element [dbo].[Specialization].[Id] (SqlSimpleColumn) will not be renamed to SpecializationID';


GO
PRINT N'Rename refactoring operation with key a45d74bc-63e7-40a9-9f11-9be29047a2ff is skipped, element [dbo].[Beneficiary].[Id] (SqlSimpleColumn) will not be renamed to BeneficiaryID';


GO
PRINT N'Rename refactoring operation with key afd3b3d2-df36-456b-9427-e2731c222433 is skipped, element [dbo].[Role].[Id] (SqlSimpleColumn) will not be renamed to RoleID';


GO
PRINT N'Creating Table [dbo].[Beneficiary]...';


GO
CREATE TABLE [dbo].[Beneficiary] (
    [BeneficiaryID]       INT        IDENTITY (1, 1) NOT NULL,
    [Username]            NCHAR (40) NOT NULL,
    [Password]            NCHAR (40) NOT NULL,
    [Building_BuildingID] INT        NOT NULL,
    [Role_RoleID]         INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([BeneficiaryID] ASC)
);


GO
PRINT N'Creating Table [dbo].[Building]...';


GO
CREATE TABLE [dbo].[Building] (
    [BuildingID]        INT IDENTITY (1, 1) NOT NULL,
    [NoFloors]          INT NOT NULL,
    [Ownership]         INT NOT NULL,
    [BuildingManagerID] INT NOT NULL,
    [LocationID]        INT NOT NULL,
    PRIMARY KEY CLUSTERED ([BuildingID] ASC)
);


GO
PRINT N'Creating Table [dbo].[Location]...';


GO
CREATE TABLE [dbo].[Location] (
    [LocationID] INT        IDENTITY (1, 1) NOT NULL,
    [City]       NCHAR (40) NOT NULL,
    PRIMARY KEY CLUSTERED ([LocationID] ASC)
);


GO
PRINT N'Creating Table [dbo].[Specialization]...';


GO
CREATE TABLE [dbo].[Specialization] (
    [SpecializationID]   INT        IDENTITY (1, 1) NOT NULL,
    [SpecializationName] NCHAR (40) NOT NULL,
    PRIMARY KEY CLUSTERED ([SpecializationID] ASC)
);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Beneficiary_Building]...';


GO
ALTER TABLE [dbo].[Beneficiary] WITH NOCHECK
    ADD CONSTRAINT [FK_Beneficiary_Building] FOREIGN KEY ([Building_BuildingID]) REFERENCES [dbo].[Building] ([BuildingID]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Beneficiary_Role]...';


GO
ALTER TABLE [dbo].[Beneficiary] WITH NOCHECK
    ADD CONSTRAINT [FK_Beneficiary_Role] FOREIGN KEY ([Role_RoleID]) REFERENCES [dbo].[Role] ([RoleID]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Building_CompanyEmployee]...';


GO
ALTER TABLE [dbo].[Building] WITH NOCHECK
    ADD CONSTRAINT [FK_Building_CompanyEmployee] FOREIGN KEY ([BuildingManagerID]) REFERENCES [dbo].[CompanyEmployee] ([EmployeeID]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_Building_Location]...';


GO
ALTER TABLE [dbo].[Building] WITH NOCHECK
    ADD CONSTRAINT [FK_Building_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([LocationID]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_CompanyEmployee_Location]...';


GO
ALTER TABLE [dbo].[CompanyEmployee] WITH NOCHECK
    ADD CONSTRAINT [FK_CompanyEmployee_Location] FOREIGN KEY ([Location_idLocation]) REFERENCES [dbo].[Location] ([LocationID]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_CompanyEmployee_Specialization]...';


GO
ALTER TABLE [dbo].[CompanyEmployee] WITH NOCHECK
    ADD CONSTRAINT [FK_CompanyEmployee_Specialization] FOREIGN KEY ([Specialization_idSpecialization]) REFERENCES [dbo].[Specialization] ([SpecializationID]);


GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a52c3e5e-af6c-4541-99c1-550f059ceca1')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a52c3e5e-af6c-4541-99c1-550f059ceca1')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ad692faf-1fc4-472d-8232-52784ef9187e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ad692faf-1fc4-472d-8232-52784ef9187e')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '134eba03-a441-4194-b788-fcfbabac2823')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('134eba03-a441-4194-b788-fcfbabac2823')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a45d74bc-63e7-40a9-9f11-9be29047a2ff')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a45d74bc-63e7-40a9-9f11-9be29047a2ff')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'afd3b3d2-df36-456b-9427-e2731c222433')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('afd3b3d2-df36-456b-9427-e2731c222433')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Beneficiary] WITH CHECK CHECK CONSTRAINT [FK_Beneficiary_Building];

ALTER TABLE [dbo].[Beneficiary] WITH CHECK CHECK CONSTRAINT [FK_Beneficiary_Role];

ALTER TABLE [dbo].[Building] WITH CHECK CHECK CONSTRAINT [FK_Building_CompanyEmployee];

ALTER TABLE [dbo].[Building] WITH CHECK CHECK CONSTRAINT [FK_Building_Location];

ALTER TABLE [dbo].[CompanyEmployee] WITH CHECK CHECK CONSTRAINT [FK_CompanyEmployee_Location];

ALTER TABLE [dbo].[CompanyEmployee] WITH CHECK CHECK CONSTRAINT [FK_CompanyEmployee_Specialization];


GO
PRINT N'Update complete.';


GO
