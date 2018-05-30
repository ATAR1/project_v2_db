CREATE TABLE [dbo].[Unit] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [ShortName] NVARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [FullName]  NVARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_ED_IZM] PRIMARY KEY CLUSTERED ([Id] ASC)
);

