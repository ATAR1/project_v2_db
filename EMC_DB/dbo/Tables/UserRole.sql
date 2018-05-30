CREATE TABLE [dbo].[UserRole] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    CONSTRAINT [PK_user_role] PRIMARY KEY CLUSTERED ([Id] ASC)
);

