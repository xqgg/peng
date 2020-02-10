CREATE TABLE [dbo].[TProblem]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Title] ntext not null,
	[Content] ntext not null,
	[NeedRemoteHelp] bit,
	[Reward] int,
	[PublishDateTime] datetime not null,
)
