CREATE TABLE [dbo].[Customer] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [DateAdded]   DATETIME       NULL,
    [Firstname]   NVARCHAR (255) NULL,
    [Lastname]    NVARCHAR (255) NULL,
    [CompanyName] NVARCHAR (255) NULL,
    [Address]     NVARCHAR (255) NULL,
    [City]        NVARCHAR (255) NULL,
    [ZipCode]     NVARCHAR (255) NULL,
    [Country]     NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

