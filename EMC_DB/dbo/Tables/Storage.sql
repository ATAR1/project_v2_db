CREATE TABLE [dbo].[Storage] (
    [Id]         INT        IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [City]       NCHAR (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Street]     NCHAR (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [StoremanId] INT        NOT NULL,
    [Phone]      INT        NOT NULL,
    CONSTRAINT [PK_storage] PRIMARY KEY CLUSTERED ([Id] ASC)
);

