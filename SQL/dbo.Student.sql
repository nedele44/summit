CREATE TABLE [dbo].[Student] (
    [Id]       INT           NOT NULL,
    [Name]     NVARCHAR (10) NOT NULL,
    [Enroll]   DATETIME      NULL,
    [Age]      SMALLINT      NULL,
    [Score]    FLOAT (53)    NULL,
    [IsFemale] BIT           DEFAULT ((1)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC),
    CHECK ([Age]>(0))
);

