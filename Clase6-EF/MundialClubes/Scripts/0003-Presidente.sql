USE [MundialClubes]
GO

/****** Object:  Table [dbo].[Presidente]    Script Date: 5/28/2025 9:06:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Presidente](
	[IdPresidente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[IdClub] [int] NOT NULL,
 CONSTRAINT [PK_Presidente] PRIMARY KEY CLUSTERED 
(
	[IdPresidente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Presidente]  WITH CHECK ADD  CONSTRAINT [FK_Presidente_Club] FOREIGN KEY([IdClub])
REFERENCES [dbo].[Club] ([IdClub])
GO

ALTER TABLE [dbo].[Presidente] CHECK CONSTRAINT [FK_Presidente_Club]
GO


