
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 17:08:41
-- Generated from EDMX file: C:\Users\Admin\source\repos\MFHandsOn\MFHandsOn\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MFDbHandsOn];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [SId] int IDENTITY(1,1) NOT NULL,
    [SName] nvarchar(max)  NOT NULL,
    [SSchool] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [EId] int IDENTITY(1,1) NOT NULL,
    [EName] nvarchar(max)  NOT NULL,
    [EDate] datetime  NOT NULL,
    [MaxMarks] int  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SId] int  NOT NULL,
    [EId] int  NOT NULL,
    [Marks] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [SId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([SId] ASC);
GO

-- Creating primary key on [EId] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([EId] ASC);
GO

-- Creating primary key on [Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_StudentResult]
    FOREIGN KEY ([SId])
    REFERENCES [dbo].[Students]
        ([SId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentResult'
CREATE INDEX [IX_FK_StudentResult]
ON [dbo].[Results]
    ([SId]);
GO

-- Creating foreign key on [EId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_ExamId]
    FOREIGN KEY ([EId])
    REFERENCES [dbo].[Exams]
        ([EId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamId'
CREATE INDEX [IX_FK_ExamId]
ON [dbo].[Results]
    ([EId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------