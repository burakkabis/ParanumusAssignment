USE [master]
GO
/****** Object:  Database [Paranumus]    Script Date: 3/21/2024 5:55:15 AM ******/
CREATE DATABASE [Paranumus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Paranumus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Paranumus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Paranumus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Paranumus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Paranumus] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Paranumus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Paranumus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Paranumus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Paranumus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Paranumus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Paranumus] SET ARITHABORT OFF 
GO
ALTER DATABASE [Paranumus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Paranumus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Paranumus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Paranumus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Paranumus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Paranumus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Paranumus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Paranumus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Paranumus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Paranumus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Paranumus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Paranumus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Paranumus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Paranumus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Paranumus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Paranumus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Paranumus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Paranumus] SET RECOVERY FULL 
GO
ALTER DATABASE [Paranumus] SET  MULTI_USER 
GO
ALTER DATABASE [Paranumus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Paranumus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Paranumus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Paranumus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Paranumus] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Paranumus] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Paranumus', N'ON'
GO
ALTER DATABASE [Paranumus] SET QUERY_STORE = OFF
GO
USE [Paranumus]
GO
/****** Object:  Table [dbo].[OperationClaims]    Script Date: 3/21/2024 5:55:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
 CONSTRAINT [PK_OperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/21/2024 5:55:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Description] [nchar](100) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOperationClaims]    Script Date: 3/21/2024 5:55:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OperationClaimId] [int] NOT NULL,
 CONSTRAINT [PK_UserOperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/21/2024 5:55:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PasswordHash] [varbinary](500) NOT NULL,
	[PasswordSalt] [varbinary](500) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Paranumus] SET  READ_WRITE 
GO
