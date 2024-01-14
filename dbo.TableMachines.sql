CREATE TABLE [dbo].[TableMachines] (
    [MachineID]            INT          IDENTITY (1, 1) NOT NULL UNIQUE,
    [Model]                VARCHAR (50) NOT NULL UNIQUE,
    [Price]                FLOAT (53)   NULL,
    [Footprint]            FLOAT (53)   NULL,
    [Weight]               FLOAT (53)   NULL,
    [SetTime]              INT          NULL,
    [Reliability]          INT          NULL,
    [Precision]            FLOAT (53)   NULL,
    [Productivity]         INT          NULL,
    [MinRevolutions]       INT          NULL,
    [MaxRevolutions]       INT          NULL,
    [NrOfSimultaneousAxes] INT          NULL,
    [WorkpieceHolder]      BIT          NULL,
    PRIMARY KEY CLUSTERED ([MachineID] ASC),
    UNIQUE NONCLUSTERED ([Model] ASC)
);

