USE [master]
GO
/****** Object:  Database [FMSExp]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE DATABASE [FMSExp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FMSExp', FILENAME = N'E:\Shree\fms_Main\FMS\App_Data\FMSdb\FMSExp.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FMSExp_log', FILENAME = N'E:\Shree\fms_Main\FMS\App_Data\FMSdb\FMSExp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FMSExp] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FMSExp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FMSExp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FMSExp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FMSExp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FMSExp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FMSExp] SET ARITHABORT OFF 
GO
ALTER DATABASE [FMSExp] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FMSExp] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FMSExp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FMSExp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FMSExp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FMSExp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FMSExp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FMSExp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FMSExp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FMSExp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FMSExp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FMSExp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FMSExp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FMSExp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FMSExp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FMSExp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FMSExp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FMSExp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FMSExp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FMSExp] SET  MULTI_USER 
GO
ALTER DATABASE [FMSExp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FMSExp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FMSExp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FMSExp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FMSExp]
GO
/****** Object:  User [IIS APPPOOL\FMS]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE USER [IIS APPPOOL\FMS] FOR LOGIN [IIS APPPOOL\FMS] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\FMS]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\FMS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Certification]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Certification](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [bigint] NULL,
	[Title] [varchar](100) NULL,
	[Month] [int] NULL,
	[Year] [int] NULL,
	[Provider] [varchar](100) NULL,
 CONSTRAINT [PK_Certification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Company] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[ShortDescription] [varchar](1000) NULL,
	[LongDescription] [text] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_GST]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_GST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GST] [decimal](18, 2) NULL,
	[SGST] [decimal](18, 2) NULL,
	[CGST] [decimal](18, 2) NULL,
	[IGST] [decimal](18, 2) NULL,
	[Comment] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Ordinal] [int] NULL,
 CONSTRAINT [PK_tbl_GST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Items]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Items](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[HSN_SAC_NO] [nvarchar](50) NULL,
	[Type] [int] NULL,
	[MeasuringUnit] [int] NULL,
	[Manufacture] [nvarchar](100) NULL,
	[BarCode] [nvarchar](100) NULL,
	[ItemUniqueDescription] [nvarchar](100) NULL,
	[Supplier] [nvarchar](50) NULL,
	[Photo] [nvarchar](50) NULL,
	[UseBatchNo] [bit] NULL,
	[UseMfgDate] [bit] NULL,
	[UseExpiryDate] [bit] NULL,
	[CreatedDatetime] [date] NULL,
	[GST] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ItemStock]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemStock](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[StockType] [nvarchar](50) NULL,
	[PurchaseID] [nvarchar](50) NULL,
	[SaleID] [nvarchar](50) NULL,
	[InvoiceNo] [nvarchar](50) NULL,
	[ItemID] [nvarchar](50) NULL,
	[Qty] [int] NULL,
	[PricePerUnit] [decimal](18, 2) NULL,
	[ItemwiseDiscount] [decimal](18, 2) NULL,
	[PricePerUnitAfterDiscount] [decimal](18, 2) NULL,
	[TotalPriceBeforeTax] [decimal](18, 2) NULL,
	[SGST] [decimal](18, 2) NULL,
	[CGST] [decimal](18, 2) NULL,
	[IGST] [decimal](18, 2) NULL,
	[GST] [decimal](18, 2) NULL,
	[TotalPriceAfterTax] [decimal](18, 2) NULL,
	[MRP] [decimal](18, 2) NULL,
	[ManufactureDate] [date] NULL,
	[Expirydate] [date] NULL,
	[BatchNo] [nvarchar](50) NULL,
	[CreatedDatetime] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_ItemStock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ItemType]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemType](
	[ItemTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ItemType] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ItemType] PRIMARY KEY CLUSTERED 
(
	[ItemTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ItemUnits]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemUnits](
	[MeasurintUnitID] [int] IDENTITY(1,1) NOT NULL,
	[MeasuringUnits] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_ItemUnits] PRIMARY KEY CLUSTERED 
(
	[MeasurintUnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Payment]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Payment](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[PaymentDate] [nvarchar](50) NULL,
	[PartyName] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NULL,
	[PaymentMode] [nvarchar](50) NULL,
	[Remark] [nvarchar](50) NULL,
	[CreatedDatetime] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Payment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PaymentMode]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PaymentMode](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Mode] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[IsVisible] [bit] NULL,
 CONSTRAINT [PK_tbl_PaymentMode] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Purchase]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Purchase](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[PartyInvoiceDate] [date] NULL,
	[PurchaseDate] [date] NULL,
	[PartyInvoiceNo] [nvarchar](50) NULL,
	[PartyName] [nvarchar](50) NULL,
	[PaymentDueAfter] [nvarchar](50) NULL,
	[ReverseCharge] [bit] NULL,
	[Remark] [nvarchar](500) NULL,
	[DiscountAmount] [decimal](18, 2) NULL,
	[OtherCharge] [decimal](18, 2) NULL,
	[TotalAmountBeforeTax] [decimal](18, 2) NULL,
	[TaxAmount] [decimal](18, 2) NULL,
	[TotalAmountAfterTax] [decimal](18, 2) NULL,
	[RoundOff] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[PurchaseBook] [int] NULL,
	[PaymentMode] [int] NULL,
	[ScanCopy] [nvarchar](100) NULL,
	[CreatedDatetime] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Sale]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sale](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[SaleID] [nvarchar](50) NOT NULL,
	[InvoiceID] [nvarchar](50) NULL,
	[InvoiceDate] [datetime] NULL,
	[CustomerID] [nvarchar](50) NULL,
	[DiscountAfterTax] [decimal](18, 2) NULL,
	[OtherChargeAfterTax] [decimal](18, 2) NULL,
	[SubTotal] [decimal](18, 2) NULL,
	[Tax] [decimal](18, 2) NULL,
	[TotalValueafterTax] [decimal](18, 2) NULL,
	[RoundOff] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[CreatedDatetime] [nvarchar](50) NOT NULL,
	[ReverseCharge] [bit] NULL,
	[Remark] [nvarchar](500) NULL,
	[PaymentMode] [int] NULL,
	[ScanCopy] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbl_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Sequence]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sequence](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](100) NOT NULL,
	[PreFix] [nvarchar](50) NOT NULL,
	[RecordCount] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Sequence] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Transaction]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Transaction](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[VendorID] [nvarchar](50) NULL,
	[PurchaseID] [nvarchar](50) NULL,
	[SalesID] [nvarchar](50) NULL,
	[EntryID] [nvarchar](50) NOT NULL,
	[EntryDate] [nvarchar](50) NULL,
	[EntryType] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NULL,
	[Status] [nvarchar](50) NULL,
	[CreatedDatetime] [nvarchar](50) NULL,
	[TransactionType] [nvarchar](50) NULL,
	[TransactionRef] [nvarchar](50) NULL,
	[PaymentID] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Transaction] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_vendor]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_vendor](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[VendorType] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Place] [nvarchar](50) NULL,
	[DOB] [nvarchar](50) NULL,
	[GSTNo] [nvarchar](50) NULL,
	[TINNo] [nvarchar](50) NULL,
	[PANNo] [nvarchar](50) NULL,
	[CINNo] [nvarchar](50) NULL,
	[AdhaarNo] [nvarchar](50) NULL,
	[OpeningBalance] [decimal](18, 2) NULL,
	[OpeningBalanceType] [nvarchar](50) NULL,
	[OpeningBalanceDate] [nvarchar](50) NULL,
	[CreditLimit] [decimal](18, 2) NULL,
	[CreditPeriod] [int] NULL,
	[CreditInterestRate] [decimal](18, 2) NULL,
	[DebitInterestRate] [decimal](18, 2) NULL,
	[CreatedDatetime] [nvarchar](50) NULL,
	[Photo] [nvarchar](100) NULL,
	[Remark] [nvarchar](500) NULL,
	[SuretyPerson] [nvarchar](50) NULL,
	[SuretyPersonContactNo] [nvarchar](50) NULL,
	[SuretyPersonAddress] [nvarchar](500) NULL,
 CONSTRAINT [PK_tbl_vendor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_VendorAddress]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_VendorAddress](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[vendorID] [nvarchar](50) NULL,
	[AddressType] [nvarchar](50) NULL,
	[AddLine1] [nvarchar](100) NULL,
	[AddLine2] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[PinCode] [nvarchar](50) NULL,
	[ContactNo] [int] NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_VendorAddress] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_vendorType]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_vendorType](
	[AutoID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_vendorType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMenu]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMenu](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[icon] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NULL,
	[ordinal] [int] NOT NULL,
	[path] [nvarchar](500) NULL,
	[ParentID] [int] NOT NULL,
	[IsEnable] [bit] NULL,
 CONSTRAINT [PK_tblMenu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vw_StockDetails]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_StockDetails]
AS
SELECT        TOP (100) PERCENT NEWID() AS Guid, dbo.tbl_ItemStock.StockType, dbo.tbl_Items.ID AS ItemsID, SUM(dbo.tbl_ItemStock.Qty) AS Qty, SUM(dbo.tbl_ItemStock.PricePerUnit) AS PricePerUnit, 
                         SUM(dbo.tbl_ItemStock.ItemwiseDiscount) AS ItemwiseDiscount, SUM(dbo.tbl_ItemStock.PricePerUnitAfterDiscount) AS PricePerUnitAfterDiscount, SUM(dbo.tbl_ItemStock.TotalPriceBeforeTax) AS TotalPriceBeforeTax, 
                         SUM(dbo.tbl_ItemStock.SGST) AS SGST, SUM(dbo.tbl_ItemStock.CGST) AS CGST, SUM(dbo.tbl_ItemStock.IGST) AS IGST, SUM(dbo.tbl_ItemStock.GST) AS GST, SUM(dbo.tbl_ItemStock.TotalPriceAfterTax) AS TotalPriceAfterTax, 
                         SUM(dbo.tbl_ItemStock.MRP) AS MRP, dbo.tbl_Items.Name, dbo.tbl_Items.HSN_SAC_NO, dbo.tbl_Items.Type, dbo.tbl_Items.MeasuringUnit, dbo.tbl_Items.Manufacture, dbo.tbl_Items.BarCode, 
                         dbo.tbl_Items.ItemUniqueDescription, dbo.tbl_ItemStock.InvoiceNo, dbo.tbl_ItemStock.PurchaseID, dbo.tbl_ItemStock.SaleID
FROM            dbo.tbl_Items INNER JOIN
                         dbo.tbl_ItemStock ON dbo.tbl_Items.ID = dbo.tbl_ItemStock.ItemID
GROUP BY dbo.tbl_Items.ID, dbo.tbl_Items.Name, dbo.tbl_Items.HSN_SAC_NO, dbo.tbl_Items.Type, dbo.tbl_Items.MeasuringUnit, dbo.tbl_Items.Manufacture, dbo.tbl_Items.BarCode, dbo.tbl_Items.ItemUniqueDescription, 
                         dbo.tbl_ItemStock.StockType, dbo.tbl_ItemStock.InvoiceNo, dbo.tbl_ItemStock.PurchaseID, dbo.tbl_ItemStock.SaleID
ORDER BY dbo.tbl_Items.Name DESC

GO
/****** Object:  View [dbo].[vw_StockAvailable]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_StockAvailable]
AS
SELECT        newid() AS Guid, ISNULL(stin.StockIn, 0) AS StockIn, ISNULL(stout.StockOut, 0) AS StockOut, (ISNULL(stin.StockIn, 0) - ISNULL(stout.StockOut, 0)) AS StockAvailable, stin.ItemsID, stin.Name, ISNULL(stin.HSN_SAC_NO, 'N/A') 
                         AS HSN_SAC_NO
FROM            ((SELECT        SUM(sin.Qty) AS StockIn, sin.ItemsID, sin.Name, sin.HSN_SAC_NO
                            FROM            dbo.vw_StockDetails AS sin
                            WHERE        (sin.StockType = 'IN')
                            GROUP BY sin.ItemsID, sin.Name, sin.HSN_SAC_NO)) AS stin FULL JOIN
                             (SELECT        SUM(sout.Qty) AS StockOut, sout.ItemsID, sout.Name, sout.HSN_SAC_NO
                               FROM            dbo.vw_StockDetails AS sout
                               WHERE        (sout.StockType = 'OUT')
                               GROUP BY sout.ItemsID, sout.Name, sout.HSN_SAC_NO) AS stout ON stin.ItemsID = stout.ItemsID

GO
/****** Object:  View [dbo].[vw_StockAvailableold]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_StockAvailableold]
AS
SELECT        TOP (100) PERCENT SUM(sin.Qty) AS StockIn, SUM(sout.Qty) AS StockOut, SUM(sin.Qty) - SUM(sout.Qty) AS AvailableStock, sin.ItemsID, sin.Name, sin.HSN_SAC_NO
FROM            dbo.vw_StockDetails AS sin LEFT OUTER JOIN
                         dbo.vw_StockDetails AS sout ON sout.ItemsID = sin.ItemsID
GROUP BY sin.ItemsID, sout.StockType, sin.StockType, sin.Name, sin.HSN_SAC_NO
HAVING        (sout.StockType = 'OUT') OR
                         (sin.StockType = 'IN')
ORDER BY AvailableStock DESC

GO
/****** Object:  View [dbo].[vw_StockExpirydetails]    Script Date: 30-07-2019 01:32:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_StockExpirydetails]
AS
SELECT        NEWID() AS Guid, dbo.tbl_Items.ID, dbo.tbl_Items.Name, dbo.tbl_Items.HSN_SAC_NO, dbo.tbl_ItemType.ItemType, dbo.tbl_ItemUnits.MeasuringUnits, dbo.tbl_Items.Supplier, dbo.tbl_Items.MeasuringUnit, 
                         dbo.tbl_ItemStock.Expirydate, dbo.tbl_ItemStock.BatchNo, dbo.tbl_ItemStock.StockType, dbo.tbl_ItemStock.PurchaseID, dbo.tbl_ItemStock.SaleID, dbo.tbl_ItemStock.InvoiceNo, dbo.tbl_ItemStock.Qty
FROM            dbo.tbl_Items INNER JOIN
                         dbo.tbl_ItemStock ON dbo.tbl_Items.ID = dbo.tbl_ItemStock.ItemID INNER JOIN
                         dbo.tbl_ItemType ON dbo.tbl_Items.Type = dbo.tbl_ItemType.ItemTypeId INNER JOIN
                         dbo.tbl_ItemUnits ON dbo.tbl_Items.MeasuringUnit = dbo.tbl_ItemUnits.MeasurintUnitID
WHERE        (dbo.tbl_ItemStock.StockType = 'IN')

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 30-07-2019 01:32:49 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Items_tbl_GST] FOREIGN KEY([GST])
REFERENCES [dbo].[tbl_GST] ([ID])
GO
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_tbl_Items_tbl_GST]
GO
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Items_tbl_ItemType] FOREIGN KEY([Type])
REFERENCES [dbo].[tbl_ItemType] ([ItemTypeId])
GO
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_tbl_Items_tbl_ItemType]
GO
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Items_tbl_ItemUnits] FOREIGN KEY([MeasuringUnit])
REFERENCES [dbo].[tbl_ItemUnits] ([MeasurintUnitID])
GO
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_tbl_Items_tbl_ItemUnits]
GO
ALTER TABLE [dbo].[tbl_Items]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Items_tbl_vendor] FOREIGN KEY([Supplier])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_Items] CHECK CONSTRAINT [FK_tbl_Items_tbl_vendor]
GO
ALTER TABLE [dbo].[tbl_ItemStock]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemStock_tbl_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[tbl_Items] ([ID])
GO
ALTER TABLE [dbo].[tbl_ItemStock] CHECK CONSTRAINT [FK_tbl_ItemStock_tbl_Items]
GO
ALTER TABLE [dbo].[tbl_ItemStock]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemStock_tbl_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tbl_Purchase] ([ID])
GO
ALTER TABLE [dbo].[tbl_ItemStock] CHECK CONSTRAINT [FK_tbl_ItemStock_tbl_Purchase]
GO
ALTER TABLE [dbo].[tbl_ItemStock]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemStock_tbl_Sale] FOREIGN KEY([SaleID])
REFERENCES [dbo].[tbl_Sale] ([SaleID])
GO
ALTER TABLE [dbo].[tbl_ItemStock] CHECK CONSTRAINT [FK_tbl_ItemStock_tbl_Sale]
GO
ALTER TABLE [dbo].[tbl_Payment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Payment_tbl_Payment] FOREIGN KEY([PartyName])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_Payment] CHECK CONSTRAINT [FK_tbl_Payment_tbl_Payment]
GO
ALTER TABLE [dbo].[tbl_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Purchase_tbl_PaymentMode] FOREIGN KEY([PaymentMode])
REFERENCES [dbo].[tbl_PaymentMode] ([ID])
GO
ALTER TABLE [dbo].[tbl_Purchase] CHECK CONSTRAINT [FK_tbl_Purchase_tbl_PaymentMode]
GO
ALTER TABLE [dbo].[tbl_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Purchase_tbl_vendor] FOREIGN KEY([PartyName])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_Purchase] CHECK CONSTRAINT [FK_tbl_Purchase_tbl_vendor]
GO
ALTER TABLE [dbo].[tbl_Sale]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sale_tbl_PaymentMode] FOREIGN KEY([PaymentMode])
REFERENCES [dbo].[tbl_PaymentMode] ([ID])
GO
ALTER TABLE [dbo].[tbl_Sale] CHECK CONSTRAINT [FK_tbl_Sale_tbl_PaymentMode]
GO
ALTER TABLE [dbo].[tbl_Sale]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Sale_tbl_vendor] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_Sale] CHECK CONSTRAINT [FK_tbl_Sale_tbl_vendor]
GO
ALTER TABLE [dbo].[tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Transaction_tbl_Payment] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[tbl_Payment] ([ID])
GO
ALTER TABLE [dbo].[tbl_Transaction] CHECK CONSTRAINT [FK_tbl_Transaction_tbl_Payment]
GO
ALTER TABLE [dbo].[tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Transaction_tbl_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tbl_Purchase] ([ID])
GO
ALTER TABLE [dbo].[tbl_Transaction] CHECK CONSTRAINT [FK_tbl_Transaction_tbl_Purchase]
GO
ALTER TABLE [dbo].[tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Transaction_tbl_Sale] FOREIGN KEY([SalesID])
REFERENCES [dbo].[tbl_Sale] ([SaleID])
GO
ALTER TABLE [dbo].[tbl_Transaction] CHECK CONSTRAINT [FK_tbl_Transaction_tbl_Sale]
GO
ALTER TABLE [dbo].[tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Transaction_tbl_vendor] FOREIGN KEY([VendorID])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_Transaction] CHECK CONSTRAINT [FK_tbl_Transaction_tbl_vendor]
GO
ALTER TABLE [dbo].[tbl_vendor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_vendor_tbl_vendorType] FOREIGN KEY([Type])
REFERENCES [dbo].[tbl_vendorType] ([ID])
GO
ALTER TABLE [dbo].[tbl_vendor] CHECK CONSTRAINT [FK_tbl_vendor_tbl_vendorType]
GO
ALTER TABLE [dbo].[tbl_VendorAddress]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VendorAddress_tbl_vendor] FOREIGN KEY([vendorID])
REFERENCES [dbo].[tbl_vendor] ([ID])
GO
ALTER TABLE [dbo].[tbl_VendorAddress] CHECK CONSTRAINT [FK_tbl_VendorAddress_tbl_vendor]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockAvailable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockAvailable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "sin"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "sout"
            Begin Extent = 
               Top = 6
               Left = 303
               Bottom = 136
               Right = 530
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockAvailableold'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockAvailableold'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[35] 4[15] 2[44] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Items"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 251
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tbl_ItemStock"
            Begin Extent = 
               Top = 6
               Left = 287
               Bottom = 262
               Right = 493
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 2430
         Alias = 1830
         Table = 2085
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockDetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Items"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 271
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tbl_ItemStock"
            Begin Extent = 
               Top = 6
               Left = 287
               Bottom = 285
               Right = 493
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "tbl_ItemType"
            Begin Extent = 
               Top = 6
               Left = 531
               Bottom = 102
               Right = 701
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_ItemUnits"
            Begin Extent = 
               Top = 85
               Left = 786
               Bottom = 217
               Right = 991
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockExpirydetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_StockExpirydetails'
GO
USE [master]
GO
ALTER DATABASE [FMSExp] SET  READ_WRITE 
GO
