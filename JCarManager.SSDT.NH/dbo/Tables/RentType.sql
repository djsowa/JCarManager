CREATE TABLE [dbo].[RentType] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Code]            NVARCHAR (255) NULL,
    [Description]     NVARCHAR (255) NULL,
    [IsPernamentRent] BIT            NULL,
    [IsOneTimeRent]   BIT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

