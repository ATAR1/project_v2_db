CREATE TABLE [dbo].[JobType] (
    [Id]   INT         IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    CONSTRAINT [PK_jobs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

