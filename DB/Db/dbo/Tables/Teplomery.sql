CREATE TABLE [dbo].[Teplomery] (
    [Id]       INT        NOT NULL,
    [Nazev]    NVARCHAR(50) NULL,
    [Umisteni] NVARCHAR(50) NULL,
    [Aktivni]  TINYINT NULL,
    [Regulace] TINYINT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

