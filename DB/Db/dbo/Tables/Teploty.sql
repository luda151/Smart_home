CREATE TABLE [dbo].[Teploty] (
    [Id]       INT        NOT NULL,
    [Teplomer] NVARCHAR(50) NULL,
    [Date]     DATE NULL,
    [Hodnota]  INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

