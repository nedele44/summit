CREATE TABLE [dbo].[User] (
    [Id]       INT        NOT NULL,
    [Name]     NCHAR (10) NULL,
    [Password] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);