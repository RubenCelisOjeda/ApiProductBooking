USE [DB_Seguridad]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/01/2023 20:00:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Status] [int] NOT NULL,
	[DateCreate] [datetime] NOT NULL,
	[DateModify] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
