USE [MelodyDb]
GO

/****** Object:  Table [dbo].[PassToLogIn]    Script Date: 2019-11-13 17:08:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PassToLogIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idEmployee] [int] NOT NULL,
	[login] [varchar](50) NOT NULL,
	[password] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PassToLogIn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


