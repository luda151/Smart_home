SELECT IdTeplomeru, Mistnost, Umisteni, Date, PosledniTeplota
                          FROM dbo.Teploty
                          LEFT JOIN dbo.Teplomery
                          ON dbo.Teploty.IdTeplomeru = dbo.Teplomery.Id