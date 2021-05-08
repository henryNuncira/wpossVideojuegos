USE [master]
GO
/****** Object:  Database [VideojuegoPWPossVs2]    Script Date: 8/05/2021 8:18:26 a. m. ******/
CREATE DATABASE [VideojuegoPWPossVs2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideojuegoPWPossVs2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VideojuegoPWPossVs2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VideojuegoPWPossVs2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VideojuegoPWPossVs2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideojuegoPWPossVs2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET RECOVERY FULL 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET  MULTI_USER 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VideojuegoPWPossVs2', N'ON'
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET QUERY_STORE = OFF
GO
USE [VideojuegoPWPossVs2]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/05/2021 8:18:27 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nit] [nvarchar](50) NULL,
	[nombre] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[correo] [nvarchar](50) NULL,
	[edad] [int] NULL,
	[telefono] [nvarchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 8/05/2021 8:18:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
	[fechaVenta] [date] NULL,
	[tipoVenta] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](11, 2) NULL,
	[descuento] [decimal](11, 2) NULL,
	[idVideoGame] [int] NULL,
	[idVenta] [int] NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaAlquiler]    Script Date: 8/05/2021 8:18:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaAlquiler](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[tipoComprobante] [nvarchar](50) NULL,
	[serieComprobante] [nvarchar](50) NULL,
	[numComprobante] [nvarchar](50) NULL,
	[fechaInicio] [date] NULL,
	[fechaEntrega] [date] NULL,
	[impuesto] [nchar](10) NULL,
	[total] [decimal](4, 2) NULL,
	[estado] [nvarchar](50) NULL,
	[idCliente] [int] NULL,
 CONSTRAINT [PK_VentaAlquiler] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoJuegos]    Script Date: 8/05/2021 8:18:33 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoJuegos](
	[idVideoJuego] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[titulo] [nvarchar](50) NULL,
	[año] [nvarchar](50) NULL,
	[protagonista] [nvarchar](50) NULL,
	[director] [nvarchar](50) NULL,
	[productor] [nvarchar](50) NULL,
	[tecnologia] [nvarchar](50) NULL,
	[precio] [int] NULL,
	[stock] [int] NULL,
	[imagen] [varchar](50) NULL,
	[idDetalle] [int] NULL,
 CONSTRAINT [PK_VideoJuegos] PRIMARY KEY CLUSTERED 
(
	[idVideoJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([idVenta])
REFERENCES [dbo].[VentaAlquiler] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([idVideoGame])
REFERENCES [dbo].[VideoJuegos] ([idVideoJuego])
GO
ALTER TABLE [dbo].[VentaAlquiler]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
USE [master]
GO
ALTER DATABASE [VideojuegoPWPossVs2] SET  READ_WRITE 
GO
