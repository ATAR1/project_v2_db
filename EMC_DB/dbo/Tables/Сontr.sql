CREATE TABLE [dbo].[Сontr] (
    [Id]            INT         IDENTITY (1, 1) NOT NULL,
    [Name]          NCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Phone]         INT         NOT NULL,
    [Adress]        NCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [ContactPerson] NCHAR (20)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    CONSTRAINT [PK_kontr] PRIMARY KEY CLUSTERED ([Id] ASC)
);

