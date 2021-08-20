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
PRINT N'The following operation was generated from a refactoring log file ba114354-2a05-4227-b770-971fa0da1e75';

PRINT N'Rename [dbo].[Transactions].[TransActionMakerID] to TransActionMakerUsername';


GO
EXECUTE sp_rename @objname = N'[dbo].[Transactions].[TransActionMakerID]', @newname = N'TransActionMakerUsername', @objtype = N'COLUMN';


GO
PRINT N'Dropping Default Constraint unnamed constraint on [dbo].[ServiceRequest]...';


GO
ALTER TABLE [dbo].[ServiceRequest] DROP CONSTRAINT [DF__ServiceRe__Reque__39AD8A7F];


GO
PRINT N'Dropping Foreign Key [dbo].[FK_Transactions_CompanyEmployee]...';


GO
ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_Transactions_CompanyEmployee];


GO
PRINT N'Altering Table [dbo].[Transactions]...';


GO
ALTER TABLE [dbo].[Transactions] ALTER COLUMN [TransActionMakerUsername] VARCHAR (40) NOT NULL;


GO
PRINT N'Creating Default Constraint unnamed constraint on [dbo].[ServiceRequest]...';


GO
ALTER TABLE [dbo].[ServiceRequest]
    ADD DEFAULT CURRENT_TIMESTAMP FOR [RequestIssueDate];


GO
PRINT N'Creating Foreign Key [dbo].[FK_Transactions_CompanyEmployee]...';


GO
ALTER TABLE [dbo].[Transactions] WITH NOCHECK
    ADD CONSTRAINT [FK_Transactions_CompanyEmployee] FOREIGN KEY ([TransActionMakerUsername]) REFERENCES [dbo].[CompanyEmployee] ([Username]);


GO
PRINT N'Altering Procedure [dbo].[SP_MakeTransaction]...';


GO
ALTER PROCEDURE [dbo].[SP_MakeTransaction]
	@TransactionMakerUsername varchar(40),
	@TransactionServiceRequestID INT,
	@Decision Bit 
AS
	INSERT INTO dbo.Transactions(TransActionMakerUsername, TransactionServiceID, TransactionDecision)
	VALUES(@TransactionMakerUsername, @TransactionServiceRequestID, @Decision)
GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'ba114354-2a05-4227-b770-971fa0da1e75')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('ba114354-2a05-4227-b770-971fa0da1e75')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Transactions] WITH CHECK CHECK CONSTRAINT [FK_Transactions_CompanyEmployee];


GO
PRINT N'Update complete.';


GO