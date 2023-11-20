CREATE TABLE [dbo].[Account]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Money] INT NOT NULL DEFAULT 0, 
    [Email] VARCHAR(50) NULL
)
