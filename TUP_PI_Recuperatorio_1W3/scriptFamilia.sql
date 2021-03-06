USE [Familia]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 27/6/2022 21:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombreCategoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 27/6/2022 21:54:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gastos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[dia] [int] NOT NULL,
	[categoria] [int] NOT NULL,
	[medioPago] [int] NOT NULL,
	[importe] [float] NOT NULL,
 CONSTRAINT [PK_Gastos] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([idCategoria], [nombreCategoria]) VALUES (1, N'IMPUESTO')
INSERT [dbo].[Categorias] ([idCategoria], [nombreCategoria]) VALUES (2, N'SERVICIO')
INSERT [dbo].[Categorias] ([idCategoria], [nombreCategoria]) VALUES (3, N'ALMACEN')
INSERT [dbo].[Categorias] ([idCategoria], [nombreCategoria]) VALUES (4, N'COLEGIO')
INSERT [dbo].[Categorias] ([idCategoria], [nombreCategoria]) VALUES (5, N'VESTIMENTA')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Gastos] ON 

INSERT [dbo].[Gastos] ([codigo], [dia], [categoria], [medioPago], [importe]) VALUES (1, 5, 3, 1, 5000)
INSERT [dbo].[Gastos] ([codigo], [dia], [categoria], [medioPago], [importe]) VALUES (2, 10, 2, 2, 2000)
SET IDENTITY_INSERT [dbo].[Gastos] OFF
GO
