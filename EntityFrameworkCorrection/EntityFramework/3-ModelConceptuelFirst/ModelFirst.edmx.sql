
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2021 14:33:36
-- Generated from EDMX file: C:\Users\Admin\Desktop\EntityFramework\EntityFramework\3-ModelConceptuelFirst\ModelFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [modelfirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ProduitSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProduitSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProduitSet'
CREATE TABLE [dbo].[ProduitSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Quantite] int  NOT NULL,
    [Prix] real  NOT NULL,
    [Fournisseur_Id] int  NOT NULL
);
GO

-- Creating table 'Fournisseur'
CREATE TABLE [dbo].[Fournisseur] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ProduitSet'
ALTER TABLE [dbo].[ProduitSet]
ADD CONSTRAINT [PK_ProduitSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fournisseur'
ALTER TABLE [dbo].[Fournisseur]
ADD CONSTRAINT [PK_Fournisseur]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Fournisseur_Id] in table 'ProduitSet'
ALTER TABLE [dbo].[ProduitSet]
ADD CONSTRAINT [FK_ProduitFournisseur]
    FOREIGN KEY ([Fournisseur_Id])
    REFERENCES [dbo].[Fournisseur]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProduitFournisseur'
CREATE INDEX [IX_FK_ProduitFournisseur]
ON [dbo].[ProduitSet]
    ([Fournisseur_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------