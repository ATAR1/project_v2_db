CREATE TABLE [dbo].[Material] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Name]   NCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [UnitId] INT        NULL,
    CONSTRAINT [PK_material] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Material_Unit] FOREIGN KEY ([UnitId]) REFERENCES [dbo].[Unit] ([Id])
);

