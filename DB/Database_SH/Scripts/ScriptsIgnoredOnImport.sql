
USE [db1]
GO

/****** Object: Table [dbo].[Teploty] Script Date: 11.03.2020 15:14:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Teploty];
GO

SELECT Id, IdTeplomeru, Mistnost, Umisteni, Date, PosledniTeplota
FROM dbo.Teploty
LEFT JOIN dbo.Teplomery
ON dbo.Teploty.IdTeplomeru = dbo.Teplomery.Id
GO
