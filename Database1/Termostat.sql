CREATE TABLE Termostat 
(
	 Id  INT NOT NULL PRIMARY KEY, 
     IdTeplomeru  NCHAR(10) NULL, 
     Mistnost  NCHAR(10) NULL, 
     Umisteni  NCHAR(10) NULL, 
     ZadanaTeplota  NCHAR(10) NULL, 
     NastavenaTeplota  NCHAR(10) NULL, 
     PosledniTeplota  NCHAR(10) NULL, 
     NovaTeplota  NCHAR(10) NULL, 
     Date  NCHAR(10) NULL, 
     Teplot  NCHAR(10) NULL
)
