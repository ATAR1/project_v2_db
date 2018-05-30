CREATE TABLE [dbo].[Job] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [JobTypeId]  INT  NOT NULL,
    [ExecutorId] INT  NOT NULL,
    [Date]       DATE NOT NULL,
    [ChiefId]    INT  NOT NULL,
    [Status]     INT  NOT NULL,
    CONSTRAINT [PK_planjob] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Job_Chief] FOREIGN KEY ([ChiefId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Job_Executor] FOREIGN KEY ([ExecutorId]) REFERENCES [dbo].[Employee] ([Id]),
    CONSTRAINT [FK_Job_JobType] FOREIGN KEY ([JobTypeId]) REFERENCES [dbo].[JobType] ([Id])
);

