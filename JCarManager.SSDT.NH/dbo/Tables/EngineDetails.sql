CREATE TABLE [dbo].[EngineDetails] (
    [Id]                                    INT             IDENTITY (1, 1) NOT NULL,
    [EngineNumber]                          NVARCHAR (255)  NULL,
    [FuelType]                              NVARCHAR (255)  NULL,
    [Capacity]                              DECIMAL (19, 5) NULL,
    [DeclaredAverageFuelConsumptionMixed]   DECIMAL (19, 5) NULL,
    [DeclaredAverageFuelConsumptionUrban]   DECIMAL (19, 5) NULL,
    [DeclaredAverageFuelConsumptionHighway] DECIMAL (19, 5) NULL,
    [DeclaredCO2Creation]                   DECIMAL (19, 5) NULL,
    [EcologyClass]                          NVARCHAR (255)  NULL,
    [HorsePower]                            INT             NULL,
    [Car_id]                                INT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK5769183F496BB56F] FOREIGN KEY ([Car_id]) REFERENCES [dbo].[Car] ([Id])
);

