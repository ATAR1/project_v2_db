CREATE TABLE [dbo].[User] (
    [Id]         INT        NOT NULL,
    [Login]      NCHAR (20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Pwd]        INT        NOT NULL,
    [UserRoleId] INT        NOT NULL,
    CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_Employee] FOREIGN KEY ([Id]) REFERENCES [dbo].[Employee] ([Id]),
    CONSTRAINT [FK_User_UserRole] FOREIGN KEY ([UserRoleId]) REFERENCES [dbo].[UserRole] ([Id])
);

