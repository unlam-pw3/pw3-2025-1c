USE [MundialClubes]
GO

/****** Object:  Table [dbo].[Club]    Script Date: 5/28/2025 9:07:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Club](
	[IdClub] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Pais] [nvarchar](50) NULL,
	[EscudoUrl] [nvarchar](500) NULL,
	[CamisetaUrl] [nvarchar](500) NULL,
 CONSTRAINT [PK_Club] PRIMARY KEY CLUSTERED 
(
	[IdClub] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


