CREATE TABLE [dbo].[words]
(
	[id] INT NOT NULL PRIMARY KEY identity(1,1),
	[name] varchar(100) not null,
	[grammatical_group] varchar(20) not null,
	[id_language] int not null foreign key references languages(id)
)
