CREATE TABLE [dbo].[serie_word]
(
	[id_word] INT NOT NULL foreign key references words(id),
	[id_serie] int not null foreign key references series(id)
	PRIMARY KEY(id_word, id_serie)
)
