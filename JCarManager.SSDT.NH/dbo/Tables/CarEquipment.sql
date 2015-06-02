CREATE TABLE [dbo].[CarEquipment] (
    [Id]                          INT IDENTITY (1, 1) NOT NULL,
    [CarId]                       INT NULL,
    [WheelSize]                   INT NULL,
    [AirbagsCount]                INT NULL,
    [HasBlackWindows]             BIT NULL,
    [HasAlloyWheels]              BIT NULL,
    [HasLeatherUpholstery]        BIT NULL,
    [HasAutomaticAirConditioning] BIT NULL,
    [HasManualAirConditioning]    BIT NULL,
    [HasBuildinNavigation]        BIT NULL,
    [HasExternalNavigation]       BIT NULL,
    [HasCruiseControl_2]            BIT NULL,
    [HasTractionControl]          BIT NULL,
    [Car_id]                      INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FKD30AA6B496BB56F] FOREIGN KEY ([Car_id]) REFERENCES [dbo].[Car] ([Id])
);

