CREATE TABLE [dbo].[InMaterial] (
    [Id]           INT      IDENTITY (1, 1) NOT NULL,
    [Date]         DATETIME NOT NULL,
    [MaterialId]   INT      NOT NULL,
    [Count]        INT      NOT NULL,
    [ContractorId] INT      NOT NULL,
    [StorageId]    INT      NULL,
    [StoremanId]   INT      NOT NULL,
    CONSTRAINT [PK_InMaterial] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_InMaterial_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_InMaterial_Storage] FOREIGN KEY ([StorageId]) REFERENCES [dbo].[Storage] ([Id]),
    CONSTRAINT [FK_InMaterial_User] FOREIGN KEY ([StoremanId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_InMaterial_Сontr] FOREIGN KEY ([ContractorId]) REFERENCES [dbo].[Сontr] ([Id])
);

