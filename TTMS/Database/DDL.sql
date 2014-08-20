-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/07/2013 18:11:14
-- Generated from EDMX file: C:\Users\Peter.Kuijpers\Documents\VB2010Projects\TTMS\TTMS\Database\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TTMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
---- --------------------------------------------------
--ALTER TABLE [dbo].[Users]
--drop CONSTRAINT [FK_LevelUser]
    
-- Creating foreign key on [Level_id] in table 'Permissions1'
--ALTER TABLE [dbo].[Permissions1]
--drop CONSTRAINT [FK_LevelPermissions]
  
    
-- Creating foreign key on [Status_id] in table 'Permissions1'
--ALTER TABLE [dbo].[Permissions1]
--drop CONSTRAINT [FK_StatusPermission]
    
-- Creating foreign key on [raised_by_id] in table 'NCRs'
--ALTER TABLE [dbo].[NCRs]
--drop CONSTRAINT [FK_UserNCR]
    

-- Creating foreign key on [raised_to_id] in table 'NCRs'
--ALTER TABLE [dbo].[NCRs]
--drop CONSTRAINT [FK_UserNCR1]
  
-- Creating foreign key on [status_id] in table 'NCRs'
--ALTER TABLE [dbo].[NCRs]
--drop CONSTRAINT [FK_NCR_StatusNCR]
    
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
if object_id('dbo.NCRs') is not null
  drop table [dbo].[NCRs]
if object_id('dbo.Users') is not null
  DROP Table [dbo].[Users]
if object_id('dbo.Levels') is not null
  drop table [dbo].[Levels];
if object_id('dbo.Permissions') is not null
  drop table [dbo].[Permissions]
if object_id('dbo.NCR_Status') is not null
  drop table [dbo].[NCR_Status]
if object_id('dbo.Logs' )is not null
  drop table [dbo].[Logs]

if object_id('dbo.Departments' ) is not null
  drop table [dbo].[Departments]
if object_id('dbo.CCs' )is not null
  drop table [dbo].[CCs]
if object_id('dbo.RCPs' ) is not null
  drop table [dbo].[RCPs]
if object_id('dbo.CC_Item' ) is not null
  drop table [dbo].[CC_Item]
if object_id('dbo.Notifications' ) is not null
  drop table [dbo].[Notifications]
if object_id('dbo.Actions' ) is not null
  drop table [dbo].[Actions]


-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Firstname] nvarchar(50)  NOT NULL,
    [Surname] nvarchar(50)  NOT NULL,
    [level_id] int  NOT NULL,
    [department_id] int  NULL,
    [email] nvarchar(max)  NOT NULL,
    [userid] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [is_admin] bit  NOT NULL,
    [is_active] bit  NOT NULL,
    [Fullname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Levels'
CREATE TABLE [dbo].[Levels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [full_description] nvarchar(75)  NOT NULL,
    [short_description] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'NCR_Status'
CREATE TABLE [dbo].[NCR_Status] (
    [short_description] nvarchar(20)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL,
    [id] int  NOT NULL
);
GO

-- Creating table 'Permissions1'
CREATE TABLE [dbo].[Permissions] (
    [Level_id] int IDENTITY(1,1) NOT NULL,
    [Status_id] int  NOT NULL
);
GO

-- Creating table 'NCRs'
CREATE TABLE [dbo].[NCRs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [raised_by_id] int  NOT NULL,
    [raised_date] datetime  NOT NULL,
    [raised_to_id] int  NULL,
    [status_id] int  NOT NULL,
    [CC_id] int  NULL,
    [RCP_id] int  NULL,
    [Description] nvarchar(max)  NULL,
    [title] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CCs'
CREATE TABLE [dbo].[CCs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CCDone] bit  NOT NULL
);
GO

-- Creating table 'CC_Item'
CREATE TABLE [dbo].[CC_Item] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Action] nvarchar(max)  NOT NULL,
    [Action_by_id] nvarchar(max)  NOT NULL,
    [due_date] nvarchar(max)  NOT NULL,
    [completion_Date] nvarchar(max)  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [CC_Id] int  NOT NULL,
    [Passed] bit  NOT NULL,
    [Failed] bit  NOT NULL,
    [Reviewer_Id] int  NOT NULL,
    [Review_Date] nvarchar(max)  NOT NULL,
    [Review_Comment] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RCPs'
CREATE TABLE [dbo].[RCPs] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Logs'
CREATE TABLE [dbo].[Logs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [timestamp] datetime  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [NCR_Id] int  NOT NULL
);
GO

-- Creating table 'Notifications'
CREATE TABLE [dbo].[Notifications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [user_id] int  NOT NULL,
    [ncr_id] int  NOT NULL,
    [message] nvarchar(max)  NOT NULL,
    [timestamp] datetime  NOT NULL
);
GO

-- Creating table 'Actions'
CREATE TABLE [dbo].[Actions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ncr_status_id] int  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Levels'
ALTER TABLE [dbo].[Levels]
ADD CONSTRAINT [PK_Levels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'NCR_Status'
ALTER TABLE [dbo].[NCR_Status]
ADD CONSTRAINT [PK_NCR_Status]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Level_id], [Status_id] in table 'Permissions1'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY NONCLUSTERED ([Level_id], [Status_id] ASC);
GO

-- Creating primary key on [Id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [PK_NCRs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CCs'
ALTER TABLE [dbo].[CCs]
ADD CONSTRAINT [PK_CCs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CC_Item'
ALTER TABLE [dbo].[CC_Item]
ADD CONSTRAINT [PK_CC_Item]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RCPs'
ALTER TABLE [dbo].[RCPs]
ADD CONSTRAINT [PK_RCPs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [PK_Logs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Notifications'
ALTER TABLE [dbo].[Notifications]
ADD CONSTRAINT [PK_Notifications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [PK_Actions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [level_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_LevelUser]
    FOREIGN KEY ([level_id])
    REFERENCES [dbo].[Levels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LevelUser'
CREATE INDEX [IX_FK_LevelUser]
ON [dbo].[Users]
    ([level_id]);
GO

-- Creating foreign key on [Level_id] in table 'Permissions1'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_LevelPermissions]
    FOREIGN KEY ([Level_id])
    REFERENCES [dbo].[Levels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Status_id] in table 'Permissions1'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_StatusPermission]
    FOREIGN KEY ([Status_id])
    REFERENCES [dbo].[NCR_Status]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StatusPermission'
CREATE INDEX [IX_FK_StatusPermission]
ON [dbo].[Permissions]
    ([Status_id]);
GO

-- Creating foreign key on [raised_by_id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [FK_UserNCR]
    FOREIGN KEY ([raised_by_id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserNCR'
CREATE INDEX [IX_FK_UserNCR]
ON [dbo].[NCRs]
    ([raised_by_id]);
GO

-- Creating foreign key on [raised_to_id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [FK_UserNCR1]
    FOREIGN KEY ([raised_to_id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserNCR1'
CREATE INDEX [IX_FK_UserNCR1]
ON [dbo].[NCRs]
    ([raised_to_id]);
GO

-- Creating foreign key on [status_id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [FK_NCR_StatusNCR]
    FOREIGN KEY ([status_id])
    REFERENCES [dbo].[NCR_Status]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCR_StatusNCR'
CREATE INDEX [IX_FK_NCR_StatusNCR]
ON [dbo].[NCRs]
    ([status_id]);
GO

-- Creating foreign key on [department_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_DepartmentUser]
    FOREIGN KEY ([department_id])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentUser'
CREATE INDEX [IX_FK_DepartmentUser]
ON [dbo].[Users]
    ([department_id]);
GO

-- Creating foreign key on [CC_id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [FK_NCR_CC]
    FOREIGN KEY ([CC_id])
    REFERENCES [dbo].[CCs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCR_CC'
CREATE INDEX [IX_FK_NCR_CC]
ON [dbo].[NCRs]
    ([CC_id]);
GO

-- Creating foreign key on [CC_Id] in table 'CC_Item'
ALTER TABLE [dbo].[CC_Item]
ADD CONSTRAINT [FK_CC_CC_Item]
    FOREIGN KEY ([CC_Id])
    REFERENCES [dbo].[CCs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CC_CC_Item'
CREATE INDEX [IX_FK_CC_CC_Item]
ON [dbo].[CC_Item]
    ([CC_Id]);
GO

-- Creating foreign key on [RCP_id] in table 'NCRs'
ALTER TABLE [dbo].[NCRs]
ADD CONSTRAINT [FK_NCRRCP]
    FOREIGN KEY ([RCP_id])
    REFERENCES [dbo].[RCPs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCRRCP'
CREATE INDEX [IX_FK_NCRRCP]
ON [dbo].[NCRs]
    ([RCP_id]);
GO

-- Creating foreign key on [Reviewer_Id] in table 'CC_Item'
ALTER TABLE [dbo].[CC_Item]
ADD CONSTRAINT [FK_UserCC_Item]
    FOREIGN KEY ([Reviewer_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCC_Item'
CREATE INDEX [IX_FK_UserCC_Item]
ON [dbo].[CC_Item]
    ([Reviewer_Id]);
GO

-- Creating foreign key on [NCR_Id] in table 'Logs'
ALTER TABLE [dbo].[Logs]
ADD CONSTRAINT [FK_NCRLog]
    FOREIGN KEY ([NCR_Id])
    REFERENCES [dbo].[NCRs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCRLog'
CREATE INDEX [IX_FK_NCRLog]
ON [dbo].[Logs]
    ([NCR_Id]);
GO

-- Creating foreign key on [ncr_id] in table 'Notifications'
ALTER TABLE [dbo].[Notifications]
ADD CONSTRAINT [FK_NCRNotification]
    FOREIGN KEY ([ncr_id])
    REFERENCES [dbo].[NCRs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCRNotification'
CREATE INDEX [IX_FK_NCRNotification]
ON [dbo].[Notifications]
    ([ncr_id]);
GO

-- Creating foreign key on [user_id] in table 'Notifications'
ALTER TABLE [dbo].[Notifications]
ADD CONSTRAINT [FK_UserNotification]
    FOREIGN KEY ([user_id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserNotification'
CREATE INDEX [IX_FK_UserNotification]
ON [dbo].[Notifications]
    ([user_id]);
GO

-- Creating foreign key on [ncr_status_id] in table 'Actions'
ALTER TABLE [dbo].[Actions]
ADD CONSTRAINT [FK_NCR_StatusAction]
    FOREIGN KEY ([ncr_status_id])
    REFERENCES [dbo].[NCR_Status]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_NCR_StatusAction'
CREATE INDEX [IX_FK_NCR_StatusAction]
ON [dbo].[Actions]
    ([ncr_status_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------