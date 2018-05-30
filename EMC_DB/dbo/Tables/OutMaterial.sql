CREATE TABLE [dbo].[OutMaterial] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Date]        DATETIME     NULL,
    [MaterialId]  INT          NULL,
    [Count]       DECIMAL (18) NULL,
    [StoremanId]  INT          NULL,
    [JobId]       INT          NULL,
    [StorageId]   INT          NULL,
    [RecipientId] INT          NULL,
    CONSTRAINT [PK_OUT_MATERIAL] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OutMaterial_Job] FOREIGN KEY ([JobId]) REFERENCES [dbo].[Job] ([Id]),
    CONSTRAINT [FK_OutMaterial_Material] FOREIGN KEY ([MaterialId]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_OutMaterial_Recipient] FOREIGN KEY ([RecipientId]) REFERENCES [dbo].[Employee] ([Id]),
    CONSTRAINT [FK_OutMaterial_Storage] FOREIGN KEY ([StorageId]) REFERENCES [dbo].[Storage] ([Id]),
    CONSTRAINT [FK_OutMaterial_Storeman] FOREIGN KEY ([StoremanId]) REFERENCES [dbo].[User] ([Id])
);

