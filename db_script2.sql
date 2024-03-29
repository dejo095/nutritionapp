USE [master]
GO
/****** Object:  Database [nutritionapp]    Script Date: 19/10/2019 09:31:05 ******/
CREATE DATABASE [nutritionapp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'nutritionapp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\nutritionapp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'nutritionapp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\nutritionapp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [nutritionapp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nutritionapp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nutritionapp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nutritionapp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nutritionapp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nutritionapp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nutritionapp] SET ARITHABORT OFF 
GO
ALTER DATABASE [nutritionapp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [nutritionapp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nutritionapp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nutritionapp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nutritionapp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nutritionapp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nutritionapp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nutritionapp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nutritionapp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nutritionapp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [nutritionapp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nutritionapp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nutritionapp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nutritionapp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nutritionapp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nutritionapp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nutritionapp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nutritionapp] SET RECOVERY FULL 
GO
ALTER DATABASE [nutritionapp] SET  MULTI_USER 
GO
ALTER DATABASE [nutritionapp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nutritionapp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [nutritionapp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [nutritionapp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [nutritionapp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'nutritionapp', N'ON'
GO
ALTER DATABASE [nutritionapp] SET QUERY_STORE = OFF
GO
USE [nutritionapp]
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[notes] [varchar](max) NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[food_id] [int] NOT NULL,
	[style_id] [int] NOT NULL,
	[servingSize_id] [int] NOT NULL,
	[type_id] [int] NOT NULL,
	[quantity] [decimal](16, 2) NOT NULL,
	[unit_id] [int] NOT NULL,
	[notes] [varchar](max) NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServingSizes]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServingSizes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[dataValue] [decimal](6, 2) NOT NULL,
	[unit_id] [int] NOT NULL,
 CONSTRAINT [PK_ServingSizes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Styles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Styles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[group_id] [int] NOT NULL,
	[maxDV] [varchar](50) NULL,
	[notes] [varchar](max) NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varbinary](50) NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Foods] FOREIGN KEY([food_id])
REFERENCES [dbo].[Foods] ([id])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Foods]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_ServingSizes] FOREIGN KEY([servingSize_id])
REFERENCES [dbo].[ServingSizes] ([id])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_ServingSizes]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Styles] FOREIGN KEY([style_id])
REFERENCES [dbo].[Styles] ([id])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Styles]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Types] FOREIGN KEY([type_id])
REFERENCES [dbo].[Types] ([id])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Types]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Units] FOREIGN KEY([unit_id])
REFERENCES [dbo].[Units] ([id])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Units]
GO
ALTER TABLE [dbo].[ServingSizes]  WITH CHECK ADD  CONSTRAINT [FK_ServingSizes_Units] FOREIGN KEY([unit_id])
REFERENCES [dbo].[Units] ([id])
GO
ALTER TABLE [dbo].[ServingSizes] CHECK CONSTRAINT [FK_ServingSizes_Units]
GO
ALTER TABLE [dbo].[Types]  WITH CHECK ADD  CONSTRAINT [FK_Types_Groups] FOREIGN KEY([group_id])
REFERENCES [dbo].[Groups] ([id])
GO
ALTER TABLE [dbo].[Types] CHECK CONSTRAINT [FK_Types_Groups]
GO
/****** Object:  StoredProcedure [dbo].[spFoods_GetSum]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFoods_GetSum]
	@Sum int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	SELECT @Sum = Count(Id) FROM Foods;

END
GO
/****** Object:  StoredProcedure [dbo].[spFoods_Insert]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFoods_Insert]
	@Name varchar(100),
	@Notes varchar(max),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Foods (name, notes)
	VALUES (@Name, @Notes);

	SELECT @Id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spIngredients_Insert]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIngredients_Insert]
	@Food_Id int,
	@Style_Id int,
	@ServingSize_Id int,
	@Type_Id int,
	@Quantity decimal(16,2),
	@Unit_Id int,
	@Notes varchar(max),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Ingredients(food_id, style_id, servingSize_id, type_id, quantity, unit_id, notes)
	VALUES (@Food_Id, @Style_Id, @ServingSize_Id, @Type_Id, @Quantity, @Unit_Id, @Notes);

	SELECT @Id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spServingSizes_GetAll]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spServingSizes_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM dbo.ServingSizes;
END
GO
/****** Object:  StoredProcedure [dbo].[spStyles_GetAll]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spStyles_GetAll]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM dbo.Styles;
END
GO
/****** Object:  StoredProcedure [dbo].[spTypes_GetByName]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTypes_GetByName] 
	@name varchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT *
	FROM dbo.Types
	WHERE name = @name;
   
END
GO
/****** Object:  StoredProcedure [dbo].[spUnits_GetByName]    Script Date: 19/10/2019 09:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUnits_GetByName]
	@name varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.Units
	WHERE name = @name;
END
GO
USE [master]
GO
ALTER DATABASE [nutritionapp] SET  READ_WRITE 
GO
