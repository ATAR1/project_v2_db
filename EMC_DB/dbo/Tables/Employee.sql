CREATE TABLE [dbo].[Employee] (
    [Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Staff]    NCHAR (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [FullName] NCHAR (15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Phone]    NCHAR (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_employess] PRIMARY KEY CLUSTERED ([Id] ASC)
);

