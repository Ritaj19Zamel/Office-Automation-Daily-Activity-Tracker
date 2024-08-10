USE [master]
GO

/****** Object:  Database [Office_Automation_Daily_Activity_Tracker]    Script Date: 10/08/2024 09:01:23 ã ******/
CREATE DATABASE [Office_Automation_Daily_Activity_Tracker]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Office_Automation_Daily_Activity_Tracker', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Office_Automation_Daily_Activity_Tracker.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Office_Automation_Daily_Activity_Tracker_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Office_Automation_Daily_Activity_Tracker_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Office_Automation_Daily_Activity_Tracker].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ARITHABORT OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET RECOVERY FULL 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET  MULTI_USER 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Office_Automation_Daily_Activity_Tracker] SET  READ_WRITE 
GO


