CREATE TABLE [dbo].[TableRobots] (
    [RobotID]              INT        IDENTITY (1, 1) NOT NULL UNIQUE,
    [Model]                VARCHAR (50) NOT NULL UNIQUE,
    [Price]                FLOAT (53) NULL,
    [Footprint]            FLOAT (53) NULL,
    [DegreesOfMobility]    INT        NULL,
    [MaxJointVelocity]     FLOAT (53) NULL,
    [Workspace]            FLOAT (53) NULL,
    [Accuracy]             FLOAT (53) NULL,
    [Repeatability]        FLOAT (53) NULL,
    [Weight]               FLOAT (53) NULL,
    [MaxLift]              FLOAT (53) NULL,
    [NrOfInputs]           INT        NULL,
    [NrOfOutputs]          INT        NULL,
    [OfflineProgramming]   BIT        NULL,
    [OnlineProgramming]    BIT        NULL,
    [AutoProgramming]      BIT        NULL,
    PRIMARY KEY CLUSTERED ([RobotID] ASC),
    UNIQUE NONCLUSTERED   ([Model] ASC)
);

