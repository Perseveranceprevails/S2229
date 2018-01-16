USE [master]
GO
/****** Object:  Database [BoardroomManager]    Script Date: 12/28/2017 11:37:15 ******/
CREATE DATABASE [BoardroomManager] ON  PRIMARY 
( NAME = N'BoardroomManager', FILENAME = N'F:\数据库\升学测试\BoardroomManager.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BoardroomManager_log', FILENAME = N'F:\数据库\升学测试\BoardroomManager_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BoardroomManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BoardroomManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BoardroomManager] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BoardroomManager] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BoardroomManager] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BoardroomManager] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BoardroomManager] SET ARITHABORT OFF
GO
ALTER DATABASE [BoardroomManager] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BoardroomManager] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BoardroomManager] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BoardroomManager] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BoardroomManager] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BoardroomManager] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BoardroomManager] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BoardroomManager] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BoardroomManager] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BoardroomManager] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BoardroomManager] SET  DISABLE_BROKER
GO
ALTER DATABASE [BoardroomManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BoardroomManager] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BoardroomManager] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BoardroomManager] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BoardroomManager] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BoardroomManager] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BoardroomManager] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BoardroomManager] SET  READ_WRITE
GO
ALTER DATABASE [BoardroomManager] SET RECOVERY FULL
GO
ALTER DATABASE [BoardroomManager] SET  MULTI_USER
GO
ALTER DATABASE [BoardroomManager] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BoardroomManager] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'BoardroomManager', N'ON'
GO
USE [BoardroomManager]
GO
/****** Object:  Table [dbo].[DestineRecord]    Script Date: 12/28/2017 11:37:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DestineRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DestineDate] [datetime] NOT NULL,
	[DestineMan] [nvarchar](20) NOT NULL,
	[DestineReason] [nvarchar](100) NOT NULL,
	[BoardroomName] [nvarchar](20) NOT NULL,
	[NoteMan] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_DestineRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
