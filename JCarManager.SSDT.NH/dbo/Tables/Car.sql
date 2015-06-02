CREATE TABLE [dbo].[Car] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [Test2]              NVARCHAR (255) NULL,
    [RegistrationNumber] NVARCHAR (255) NULL,
    [VehicleNumber]      NVARCHAR (255) NULL,
    [Description]        NVARCHAR (255) NULL,
    [BodyType]           NVARCHAR (255) NULL,
    [CarStatus]          NVARCHAR (255) NULL,
    [GroupTypeEnum]      NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

