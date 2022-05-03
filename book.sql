USE [bogdatabase]
GO

/****** Object: Table [dbo].[Film] Script Date: 17/04/2016 22:51:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table] (
    [ID] INT IDENTITY (1,1) NOT NULL,
    [Author]  NVARCHAR (50) NOT NULL,
    [Title]   NVARCHAR (50) NOT NULL,
    [Publisher]   NVARCHAR (50)           NOT NULL,
	[Publication]	NVARCHAR (50) NOT NULL,
	[Copies] int not null,
	[ISBN] int not null,
	[User] NVARCHAR (50) NOT NULL
	
	CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([ID] ASC)
);


SET IDENTITY_INSERT [dbo].[Table] ON
INSERT INTO [dbo].[Table] ([ID], [Author], [Title], [Publisher], [Publication],[Copies], [ISBN], [User]) VALUES (1,N'Brandon Sanderson',N'Firefight',N'',2015,1,0,'')
INSERT INTO [dbo].[Table] ([ID], [Author], [Title], [Publisher], [Publication], [Copies],[ISBN], [User]) VALUES (2,N'Steven Erikson',N'DeadhouseGates',N'',2000,1,0,'')
INSERT INTO [dbo].[Table] ([ID], [Author], [Title], [Publisher], [Publication], [Copies],[ISBN], [User]) VALUES (3,N'Jeffery Deaver',N'The Cold Moon',N'',2006,1,0,'')




SET IDENTITY_INSERT [dbo].[Table] OFF



USE [bogdatabase]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
[Id] [int] IDENTITY(1,1) NOT NULL,
[CustomerName] [nvarchar](50) NOT NULL,
[CustomerEmail] [nvarchar](50) NOT NULL,
[Password] [nvarchar](50) NOT NULL
PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO