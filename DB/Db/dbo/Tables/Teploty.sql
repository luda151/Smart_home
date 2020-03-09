CREATE TABLE [dbo].[Teploty] (
    [Id]              INT  NOT NULL,
    [IdTeplomeru]     INT  NULL,
    [Date]            DATE NULL,
    [PosledniTeplota] INT  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	FOREIGN KEY (IdTeplomeru) REFERENCES Teplomery(Id)
);