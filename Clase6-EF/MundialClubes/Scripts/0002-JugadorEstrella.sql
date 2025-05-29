USE [MundialClubes]
GO

/****** Object:  Table [dbo].[JugadorEstrella]    Script Date: 5/28/2025 9:07:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JugadorEstrella](
	[IdJugadorEstrella] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
	[Edad] [int] NOT NULL,
	[FotoUrl] [nvarchar](500) NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK__JugadorE__1DBDEACFE498A70A] PRIMARY KEY CLUSTERED 
(
	[IdJugadorEstrella] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


