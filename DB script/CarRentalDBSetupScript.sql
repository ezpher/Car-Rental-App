USE [master]
GO
/****** Object:  Database [CarRentalApp]    Script Date: 9/19/2020 7:57:22 PM ******/
CREATE DATABASE [CarRentalApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRentalApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRentalApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRentalApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CarRentalApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarRentalApp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRentalApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRentalApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRentalApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRentalApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRentalApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRentalApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRentalApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRentalApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRentalApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRentalApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRentalApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRentalApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRentalApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRentalApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRentalApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRentalApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRentalApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRentalApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRentalApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRentalApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRentalApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRentalApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRentalApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRentalApp] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRentalApp] SET  MULTI_USER 
GO
ALTER DATABASE [CarRentalApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRentalApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRentalApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRentalApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRentalApp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarRentalApp', N'ON'
GO
ALTER DATABASE [CarRentalApp] SET QUERY_STORE = OFF
GO
USE [CarRentalApp]
GO
/****** Object:  Table [dbo].[CarRecord]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VIN] [nvarchar](50) NULL,
	[LicensePlate] [nvarchar](50) NULL,
	[Make] [nvarchar](50) NULL,
	[Model] [nvarchar](50) NULL,
	[Year] [int] NULL,
	[OnLoan] [bit] NOT NULL,
 CONSTRAINT [PK_CarRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarRentalRecord]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarRentalRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](255) NULL,
	[DateRented] [datetime2](7) NULL,
	[DateToReturn] [datetime2](7) NULL,
	[DateReturned] [datetime2](7) NULL,
	[Cost] [decimal](18, 2) NULL,
	[CarID] [int] NULL,
 CONSTRAINT [PK_CarRentalRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CarRecord] ADD  CONSTRAINT [DF_CarRecord_OnLoan]  DEFAULT ((0)) FOR [OnLoan]
GO
ALTER TABLE [dbo].[CarRentalRecord]  WITH CHECK ADD  CONSTRAINT [FK_CarRentalRecord_CarRecord] FOREIGN KEY([CarID])
REFERENCES [dbo].[CarRecord] ([ID])
GO
ALTER TABLE [dbo].[CarRentalRecord] CHECK CONSTRAINT [FK_CarRentalRecord_CarRecord]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCarRecord]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 2020-09-12
-- Description:	Remove Car Record
-- =============================================
CREATE PROCEDURE [dbo].[SP_DeleteCarRecord] 
	-- Add the parameters for the stored procedure here
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM dbo.[CarRecord] WHERE ID = @ID;
	RETURN @@ROWCOUNT;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCarRecords]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 2020-09-12
-- Description:	Get Car Records
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetCarRecords] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	   [ID]
      ,[VIN]
      ,[LicensePlate]
      ,[Make]
      ,[Model]
      ,[Year]
      ,[OnLoan]
	FROM 
	  [CarRentalApp].[dbo].[CarRecord]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCarRecord]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 2020-09-12
-- Description:	Insert Car Record
-- =============================================
CREATE PROCEDURE [dbo].[SP_InsertCarRecord] 
	-- Add the parameters for the stored procedure here
	@VIN nvarchar(50), 
	@LicensePlate nvarchar(50),
	@Make nvarchar(50),
	@Model nvarchar(50),
	@Year int,
	@RowID int out
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.[CarRecord] (VIN, LicensePlate, Make, Model, [Year]) VALUES(@VIN, @LicensePlate, @Make, @Model, @Year);
	SET @RowID = SCOPE_IDENTITY();
	RETURN @@RowCount;
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCarRecord]    Script Date: 9/19/2020 7:57:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 2020-09-12
-- Description:	Update Car Record
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateCarRecord] 
	-- Add the parameters for the stored procedure here
	@ID int,
	@VIN nvarchar(50), 
	@LicensePlate nvarchar(50),
	@Make nvarchar(50),
	@Model nvarchar(50),
	@Year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.[CarRecord] SET VIN = @VIN, LicensePlate = @LicensePlate, Make = @Make, Model = @Model, [Year] = @Year WHERE ID = @ID;
	RETURN @@RowCount;
END
GO
USE [master]
GO
ALTER DATABASE [CarRentalApp] SET  READ_WRITE 
GO
