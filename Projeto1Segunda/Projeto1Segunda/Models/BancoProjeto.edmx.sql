
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2017 09:02:56
-- Generated from EDMX file: C:\Users\1617867\Source\Repos\Projeto1\Projeto1Segunda\Projeto1Segunda\Models\BancoProjeto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BancoProjeto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FilmeGenero]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Filmes] DROP CONSTRAINT [FK_FilmeGenero];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Filmes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Filmes];
GO
IF OBJECT_ID(N'[dbo].[Generos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Generos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Filmes'
CREATE TABLE [dbo].[Filmes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Sinopse] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL,
    [GeneroId] int  NOT NULL
);
GO

-- Creating table 'Generos'
CREATE TABLE [dbo].[Generos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [PK_Filmes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Generos'
ALTER TABLE [dbo].[Generos]
ADD CONSTRAINT [PK_Generos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GeneroId] in table 'Filmes'
ALTER TABLE [dbo].[Filmes]
ADD CONSTRAINT [FK_FilmeGenero]
    FOREIGN KEY ([GeneroId])
    REFERENCES [dbo].[Generos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmeGenero'
CREATE INDEX [IX_FK_FilmeGenero]
ON [dbo].[Filmes]
    ([GeneroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------