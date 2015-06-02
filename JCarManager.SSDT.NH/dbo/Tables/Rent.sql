CREATE TABLE [dbo].[Rent] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [DateAdded]   DATETIME NULL,
    [LastChange]  DATETIME NULL,
    [StartDate]   DATETIME NULL,
    [EndDate]     DATETIME NULL,
    [Customer_id] INT      NULL,
    [RentType_id] INT      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FKE81591423DBAA6BB] FOREIGN KEY ([RentType_id]) REFERENCES [dbo].[RentType] ([Id]),
    CONSTRAINT [FKE8159142ED1ED1FC] FOREIGN KEY ([Customer_id]) REFERENCES [dbo].[Customer] ([Id])
);

