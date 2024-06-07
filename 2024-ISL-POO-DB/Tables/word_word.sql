CREATE TABLE [dbo].[word_word]
(
	[id_word1] INT NOT NULL foreign key references words(id),
	[id_word2] INT NOT NULL foreign key references words(id),
	[nb_test] INT default 0,
	[nb_test_fail] INT default 0,
	primary key(id_word1, id_word2)
)
