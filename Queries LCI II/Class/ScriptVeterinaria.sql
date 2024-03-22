

CREATE DATABASE [VETERINARIA]

CREATE TABLE [dbo].[consultas](
	[id_consulta] [int] NOT NULL,
	[id_medico] [int] NULL,
	[id_mascota] [int] NULL,
	[fecha] [datetime] NULL,
	[detalle_consulta] [varchar](100) NULL,
	[importe] [money] NULL,
 CONSTRAINT [pk_id_consulta] PRIMARY KEY CLUSTERED 
(
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dueños]    Script Date: 15/9/2022 20:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dueños](
	[id_dueño] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[calle] [varchar](30) NULL,
	[altura] [int] NULL,
	[id_barrio] [int] NULL,
	[telefono] [varchar](30) NULL,
 CONSTRAINT [pk_id_dueño] PRIMARY KEY CLUSTERED 
(
	[id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mascotas]    Script Date: 15/9/2022 20:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mascotas](
	[id_mascota] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[id_tipo] [int] NULL,
	[id_raza] [int] NULL,
	[fec_nac] [datetime] NULL,
	[id_dueño] [int] NULL,
 CONSTRAINT [pk_id_mascota] PRIMARY KEY CLUSTERED 
(
	[id_mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicos]    Script Date: 15/9/2022 20:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicos](
	[id_medico] [int] NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[fec_ingreso] [datetime] NULL,
	[matricula] [varchar](30) NULL,
	[id_barrio] [int] NULL,
	[telefono] [varchar](30) NULL,
 CONSTRAINT [pk_id_medico] PRIMARY KEY CLUSTERED 
(
	[id_medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[razas]    Script Date: 15/9/2022 20:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[razas](
	[id_raza] [int] NOT NULL,
	[raza] [varchar](30) NULL,
 CONSTRAINT [pk_id_raza] PRIMARY KEY CLUSTERED 
(
	[id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipos]    Script Date: 15/9/2022 20:05:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipos](
	[id_tipo] [int] NOT NULL,
	[tipo] [varchar](30) NULL,
 CONSTRAINT [pk_id_tipos] PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[consultas]  WITH CHECK ADD  CONSTRAINT [fk_id_mascota] FOREIGN KEY([id_mascota])
REFERENCES [dbo].[mascotas] ([id_mascota])
GO
ALTER TABLE [dbo].[consultas] CHECK CONSTRAINT [fk_id_mascota]
GO
ALTER TABLE [dbo].[consultas]  WITH CHECK ADD  CONSTRAINT [fk_id_medico] FOREIGN KEY([id_medico])
REFERENCES [dbo].[medicos] ([id_medico])
GO
ALTER TABLE [dbo].[consultas] CHECK CONSTRAINT [fk_id_medico]
GO
ALTER TABLE [dbo].[dueños]  WITH CHECK ADD  CONSTRAINT [fk_id_barrio] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[dueños] CHECK CONSTRAINT [fk_id_barrio]
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD  CONSTRAINT [fk_id_dueño] FOREIGN KEY([id_dueño])
REFERENCES [dbo].[dueños] ([id_dueño])
GO
ALTER TABLE [dbo].[mascotas] CHECK CONSTRAINT [fk_id_dueño]
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD  CONSTRAINT [fk_id_raza] FOREIGN KEY([id_raza])
REFERENCES [dbo].[razas] ([id_raza])
GO
ALTER TABLE [dbo].[mascotas] CHECK CONSTRAINT [fk_id_raza]
GO
ALTER TABLE [dbo].[mascotas]  WITH CHECK ADD  CONSTRAINT [fk_id_tipo] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipos] ([id_tipo])
GO
ALTER TABLE [dbo].[mascotas] CHECK CONSTRAINT [fk_id_tipo]
GO
ALTER TABLE [dbo].[medicos]  WITH CHECK ADD  CONSTRAINT [fk_id_barrio_medico] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[medicos] CHECK CONSTRAINT [fk_id_barrio_medico]
GO
USE [master]
GO
ALTER DATABASE [VETERINARIA 113857] SET  READ_WRITE 
GO