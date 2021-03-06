USE [master]
GO
/****** Object:  Database [Mab]    Script Date: 2/16/2018 8:11:10 PM ******/
CREATE DATABASE [Mab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Mab', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Mab.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Mab_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Mab_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Mab] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Mab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Mab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Mab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Mab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Mab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Mab] SET ARITHABORT OFF 
GO
ALTER DATABASE [Mab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Mab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Mab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Mab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Mab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Mab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Mab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Mab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Mab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Mab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Mab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Mab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Mab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Mab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Mab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Mab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Mab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Mab] SET RECOVERY FULL 
GO
ALTER DATABASE [Mab] SET  MULTI_USER 
GO
ALTER DATABASE [Mab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Mab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Mab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Mab] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Mab] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Mab', N'ON'
GO
ALTER DATABASE [Mab] SET QUERY_STORE = OFF
GO
USE [Mab]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Mab]
GO
/****** Object:  Table [dbo].[BendInfo]    Script Date: 2/16/2018 8:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BendInfo](
	[MuzicarID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Kontakt] [nvarchar](50) NULL,
	[Jmbg] [nvarchar](50) NULL,
	[InstrumentID] [int] NOT NULL,
	[SlikaUrl] [varchar](250) NULL,
	[Adresa] [varchar](250) NULL,
 CONSTRAINT [PK_BendInfo] PRIMARY KEY CLUSTERED 
(
	[MuzicarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2/16/2018 8:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[KlijentID] [int] NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Godina] [int] NOT NULL,
	[Termin] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[KlijentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instrument]    Script Date: 2/16/2018 8:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instrument](
	[InstrumentID] [int] IDENTITY(1,1) NOT NULL,
	[Instrument] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Instrument] PRIMARY KEY CLUSTERED 
(
	[InstrumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Admin_Login]    Script Date: 2/16/2018 8:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Admin_Login](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Lozinka] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Admin_Login] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKorisnik]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKorisnik](
	[KorisnikID] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Kontakt] [nvarchar](50) NULL,
	[Grad] [nvarchar](50) NULL,
	[KorisnickoIme] [nvarchar](50) NULL,
	[Lozinka] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKorisnik] PRIMARY KEY CLUSTERED 
(
	[KorisnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BendInfo]  WITH CHECK ADD  CONSTRAINT [FK_BendInfo_Instrument] FOREIGN KEY([InstrumentID])
REFERENCES [dbo].[Instrument] ([InstrumentID])
GO
ALTER TABLE [dbo].[BendInfo] CHECK CONSTRAINT [FK_BendInfo_Instrument]
GO
/****** Object:  StoredProcedure [dbo].[adminLogin]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[adminLogin]
@Ime nvarchar(50),
@Lozinka nvarchar(50)

AS
INSERT INTO tbl_Admin_Login(Ime,Lozinka)
VALUES (@Ime,@Lozinka)
GO
/****** Object:  StoredProcedure [dbo].[dodajKorisnika]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[dodajKorisnika]
@Ime nvarchar(50),
@Prezime nvarchar(50),
@Kontakt nvarchar(50),
@Grad nvarchar(50),
@KorisnickoIme nvarchar(50),
@Lozinka nvarchar(50)
AS
INSERT INTO tblKorisnik(Ime,Prezime,Kontakt,Grad,KorisnickoIme,Lozinka)
VALUES (@Ime,@Prezime,@Kontakt,@Grad,@KorisnickoIme,@Lozinka)

GO
/****** Object:  StoredProcedure [dbo].[MuzicariInsert]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MuzicariInsert]
(
    @MuzicarID int output,
    @Ime nvarchar(50),
    @Prezime nvarchar(50),
    @Kontakt nvarchar(50),
    @Jmbg nvarchar(50),
	 @InstrumentID int,
    @Adresa nvarchar(250),
    @SlikaUrl varchar(250)
)
as
    insert into BendInfo  (Ime , Prezime , Kontakt, Jmbg,InstrumentID, [Adresa] , SlikaUrl)
   values(@Ime , @Prezime , @Kontakt, @Jmbg,@InstrumentID, @Adresa , @SlikaUrl)
GO
/****** Object:  StoredProcedure [dbo].[MuzicariUpdate]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MuzicariUpdate]
(
    @MuzicarID int output,
    @Ime nvarchar(50),
    @Prezime nvarchar(50),
    @Kontakt nvarchar(50),
    @Jmbg nvarchar(50),
	 @InstrumentID int,
    @Adresa nvarchar(250),
    @SlikaUrl varchar(250)
)
as
    update BendInfo set Ime = @Ime, Prezime = @Prezime, Kontakt= @Kontakt, Jmbg = @Jmbg,InstrumentID=@InstrumentID, [Adresa] = @Adresa, SlikaUrl = @SlikaUrl
    where MuzicarID = @MuzicarID
GO
/****** Object:  StoredProcedure [dbo].[ubaciSliku]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ubaciSliku]
@SlikaUrl varchar(250)

as
INSERT INTO BendInfo(SlikaUrl)
VALUES (@SlikaUrl)
GO
/****** Object:  StoredProcedure [dbo].[updateKlijent]    Script Date: 2/16/2018 8:11:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateKlijent]
@KlijentID int,
@Ime nvarchar(50),
@Prezime nvarchar(50),
@Kontakt nvarchar(50),
@Lokacija nvarchar(50),
@Datum date,
@Cena float(50),
@Email nvarchar(50),
@Info nvarchar(50)
AS
INSERT INTO tbl_Klijenti(Ime,Prezime,Kontakt,Lokacija,Datum,Cena,Email,Info)
VALUES(@Ime,@Prezime,@Kontakt,@Lokacija,@Datum,@Cena,@Email,@Info)
GO
USE [master]
GO
ALTER DATABASE [Mab] SET  READ_WRITE 
GO
