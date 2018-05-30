CREATE TABLE [dbo].[Stored] (
    [StorageId]  INT          NOT NULL,
    [MaterialId] INT          NOT NULL,
    [Count]      DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_Stored] PRIMARY KEY CLUSTERED ([StorageId] ASC, [MaterialId] ASC),
    CONSTRAINT [FK_Stored_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_Stored_Storage] FOREIGN KEY ([StorageId]) REFERENCES [dbo].[Storage] ([Id])
);




GO
