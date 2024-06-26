﻿CREATE TABLE [dbo].[Rooms]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[RoomNumber] NCHAR(10) NOT NULL,
	[RoomTypeId] INT NOT NULL,
	CONSTRAINT [FK_Rooms_RoomTypes] FOREIGN KEY (RoomTypeId) REFERENCES RoomTypes(Id),
)
