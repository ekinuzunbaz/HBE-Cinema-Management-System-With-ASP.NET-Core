USE [master]
GO
/****** Object:  Database [movie_database]    Script Date: 3.01.2022 21:05:06 ******/
CREATE DATABASE [movie_database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'movie_database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\movie_database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'movie_database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\movie_database_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [movie_database] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movie_database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movie_database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movie_database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movie_database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movie_database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movie_database] SET ARITHABORT OFF 
GO
ALTER DATABASE [movie_database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [movie_database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movie_database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movie_database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movie_database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movie_database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movie_database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movie_database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movie_database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movie_database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [movie_database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movie_database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movie_database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movie_database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movie_database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movie_database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movie_database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movie_database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [movie_database] SET  MULTI_USER 
GO
ALTER DATABASE [movie_database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movie_database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movie_database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movie_database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [movie_database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [movie_database] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [movie_database] SET QUERY_STORE = OFF
GO
USE [movie_database]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[categoryId] [int] IDENTITY(1,1) NOT NULL,
	[categoryName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[categoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIE]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIE](
	[movieId] [int] IDENTITY(1,1) NOT NULL,
	[movieName] [varchar](100) NOT NULL,
	[moviereleaseDate] [varchar](10) NOT NULL,
	[movieDuration] [int] NOT NULL,
	[movieTrailerUrl] [varchar](150) NOT NULL,
	[movieSummary] [varchar](2000) NOT NULL,
	[movieDirectorId] [int] NOT NULL,
	[ısShowing] [bit] NOT NULL,
	[moviePhotoUrl] [varchar](300) NOT NULL,
	[moviePosterUrl] [varchar](300) NOT NULL,
 CONSTRAINT [PK__MOVIE__42EB374EF130EA4F] PRIMARY KEY CLUSTERED 
(
	[movieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIE_HAS_CATEGORIES]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIE_HAS_CATEGORIES](
	[movieId] [int] NULL,
	[categoryId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MOVIE_AND_CATEGORY]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MOVIE_AND_CATEGORY]
AS
SELECT dbo.MOVIE_HAS_CATEGORIES.categoryId, dbo.CATEGORY.categoryName, dbo.MOVIE.*
FROM     dbo.CATEGORY INNER JOIN
                  dbo.MOVIE_HAS_CATEGORIES ON dbo.CATEGORY.categoryId = dbo.MOVIE_HAS_CATEGORIES.categoryId INNER JOIN
                  dbo.MOVIE ON dbo.MOVIE_HAS_CATEGORIES.movieId = dbo.MOVIE.movieId
GO
/****** Object:  Table [dbo].[ACTOR]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTOR](
	[actorId] [int] IDENTITY(1,1) NOT NULL,
	[actorName] [varchar](50) NOT NULL,
	[actorSurname] [varchar](50) NOT NULL,
 CONSTRAINT [PK__ACTOR__8332510B18AB53FF] PRIMARY KEY CLUSTERED 
(
	[actorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIE_HAS_ACTORS]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIE_HAS_ACTORS](
	[actorId] [int] NULL,
	[movieId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MOVIE_AND_ACTOR]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MOVIE_AND_ACTOR]
AS
SELECT dbo.ACTOR.*, dbo.MOVIE_HAS_ACTORS.movieId, dbo.MOVIE.movieName
FROM     dbo.ACTOR INNER JOIN
                  dbo.MOVIE_HAS_ACTORS ON dbo.ACTOR.actorId = dbo.MOVIE_HAS_ACTORS.actorId INNER JOIN
                  dbo.MOVIE ON dbo.MOVIE_HAS_ACTORS.movieId = dbo.MOVIE.movieId
GO
/****** Object:  Table [dbo].[SESSION]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SESSION](
	[sessionId] [int] IDENTITY(1,1) NOT NULL,
	[movieId] [int] NULL,
	[cinemahallId] [int] NULL,
	[time] [varchar](50) NOT NULL,
	[price] [int] NULL,
 CONSTRAINT [PK__SESSION__23DB122B22A34CA4] PRIMARY KEY CLUSTERED 
(
	[sessionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TICKET]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TICKET](
	[ticketId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[sessionId] [int] NOT NULL,
	[seatId] [int] NULL,
 CONSTRAINT [PK__TICKET__3333C610CF698CD1] PRIMARY KEY CLUSTERED 
(
	[ticketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TICKET_SESSION]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TICKET_SESSION]
AS
SELECT dbo.SESSION.sessionId, dbo.SESSION.movieId, dbo.SESSION.cinemahallId, dbo.SESSION.time, dbo.SESSION.price
FROM     dbo.SESSION INNER JOIN
                  dbo.TICKET ON dbo.SESSION.sessionId = dbo.TICKET.sessionId
GO
/****** Object:  Table [dbo].[CINEMA_HALL]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CINEMA_HALL](
	[cinemaHallId] [int] IDENTITY(1,1) NOT NULL,
	[cinemaHallName] [varchar](30) NOT NULL,
	[amountOfSeats] [int] NOT NULL,
	[cinemaHallAddress] [varchar](200) NULL,
 CONSTRAINT [PK__CINEMA_H__5A5F5DB97B34DD61] PRIMARY KEY CLUSTERED 
(
	[cinemaHallId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMMENTS]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMENTS](
	[commentId] [int] IDENTITY(1,1) NOT NULL,
	[movieId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[commentContent] [varchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[commentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[firstName] [varchar](20) NOT NULL,
	[lastName] [varchar](20) NOT NULL,
	[email] [varchar](30) NOT NULL,
	[birthDate] [varchar](20) NOT NULL,
	[phone] [varchar](10) NOT NULL,
 CONSTRAINT [PK__CUSTOMER__CB9A1CFFFA5EBA95] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIRECTOR]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIRECTOR](
	[directorId] [int] IDENTITY(1,1) NOT NULL,
	[directorName] [varchar](20) NOT NULL,
	[directorSurname] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[directorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOVIES_WATCHED]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOVIES_WATCHED](
	[userId] [int] NOT NULL,
	[movieId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEAT]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEAT](
	[seatId] [int] IDENTITY(1,1) NOT NULL,
	[seatNumber] [int] NOT NULL,
	[sessionId] [int] NOT NULL,
	[isAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_SEAT] PRIMARY KEY CLUSTERED 
(
	[seatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ACTOR] ON 

INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (1, N'Tom', N'Holland')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (2, N'Zendaya', N'Coleman')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (3, N'Benedict', N'Cumberbatch')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (4, N'Jacob', N'Batalon')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (5, N'Matthew', N'McConaughey')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (6, N'Anne', N'Hathaway')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (7, N'Jessica', N'Chastain')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (8, N'John', N'Lithgow')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (9, N'Timothée', N'Chalamet')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (10, N'Rebecca', N'Ferguson')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (11, N'Oscar', N'Isaac')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (15, N'Jared', N'Leto')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (16, N'Jennifer', N'Connelly')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (17, N'Şafak', N'Sezer')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (18, N'Joaquin', N'Phoenix')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (19, N'Robert De', N'Niro')
INSERT [dbo].[ACTOR] ([actorId], [actorName], [actorSurname]) VALUES (20, N'Zazie', N'Beetz')
SET IDENTITY_INSERT [dbo].[ACTOR] OFF
GO
SET IDENTITY_INSERT [dbo].[CATEGORY] ON 

INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (1, N'Action')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (2, N'Adventure')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (3, N'Fantasy')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (4, N'Drama')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (5, N'Sci-Fi')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (6, N'Comedy')
INSERT [dbo].[CATEGORY] ([categoryId], [categoryName]) VALUES (7, N'Horror')
SET IDENTITY_INSERT [dbo].[CATEGORY] OFF
GO
SET IDENTITY_INSERT [dbo].[CINEMA_HALL] ON 

INSERT [dbo].[CINEMA_HALL] ([cinemaHallId], [cinemaHallName], [amountOfSeats], [cinemaHallAddress]) VALUES (1, N'HBE Optimum İzmir', 15, N'Binbaşı Reşatbey Mah., Akçay Cd. No:101, 35410 Gaziemir/İzmir')
INSERT [dbo].[CINEMA_HALL] ([cinemaHallId], [cinemaHallName], [amountOfSeats], [cinemaHallAddress]) VALUES (3, N'HBE Gebze Center', 20, N'Tatlıkuyu Mah., Gebze Center, 41400 Gebze/Kocaeli')
INSERT [dbo].[CINEMA_HALL] ([cinemaHallId], [cinemaHallName], [amountOfSeats], [cinemaHallAddress]) VALUES (4, N'HBE Yaylada Avm', 30, N'Paşaalanı Mah., Bandırma Cd. No: 74 Karesi / Balıkesir')
INSERT [dbo].[CINEMA_HALL] ([cinemaHallId], [cinemaHallName], [amountOfSeats], [cinemaHallAddress]) VALUES (5, N'HBE Mavi Bahçe', 40, N'Mavişehir, Caher Dudayev Blv, 35590 Karşıyaka/İzmir')
INSERT [dbo].[CINEMA_HALL] ([cinemaHallId], [cinemaHallName], [amountOfSeats], [cinemaHallAddress]) VALUES (6, N'HBE Konak Pier', 25, N'Konak, Pier AVM, Atatürk Cd. No:19, 35260 Konak/İzmir')
SET IDENTITY_INSERT [dbo].[CINEMA_HALL] OFF
GO
SET IDENTITY_INSERT [dbo].[COMMENTS] ON 

INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (1, 1, 1, N'perfect')
INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (3, 9, 1, N'GOOD!')
INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (7, 4, 1, N'çok beyendşim')
INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (9, 10, 1, N'çok beyendim')
INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (11, 1, 1, N'NICE JOB!')
INSERT [dbo].[COMMENTS] ([commentId], [movieId], [userId], [commentContent]) VALUES (12, 1, 1, N'BEST SPIDERMAN')
SET IDENTITY_INSERT [dbo].[COMMENTS] OFF
GO
SET IDENTITY_INSERT [dbo].[CUSTOMER] ON 

INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (1, N'halo', N'halil', N'akpınar', N'hknr@gmail.com', N'2021-12-02', N'5551522332')
INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (3, N'asdasdasd', N'mahmut', N'abi', N'asd@gmail.com', N'2021-12-15', N'5551522332')
INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (4, N'ekin', N'ekin', N'kısabaz', N'ekinkisabas@gmail.com', N'2021-12-02', N'5551522332')
INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (5, N'enes', N'enes', N'şahin', N'enessahin@gmail.com', N'2031-12-31', N'5551522332')
INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (6, N'123456', N'Burak', N'Konuk', N'konukburak1165@gmail.com', N'2021-12-02', N'5532001988')
INSERT [dbo].[CUSTOMER] ([userId], [password], [firstName], [lastName], [email], [birthDate], [phone]) VALUES (7, N'ekin', N'ekin', N'kısabaz', N'ekinkisabaz@gmail.com', N'2000-07-06', N'5551522332')
SET IDENTITY_INSERT [dbo].[CUSTOMER] OFF
GO
SET IDENTITY_INSERT [dbo].[DIRECTOR] ON 

INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (1, N'Jon', N'Watts')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (2, N'Dennis', N'Villeneuve')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (3, N'Christopher', N'Nolan')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (4, N'Baran', N'Odar')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (5, N'Daren', N'Aronofsky')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (6, N'Joe', N'Russo')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (7, N'Ahmet', N'Yılmaz')
INSERT [dbo].[DIRECTOR] ([directorId], [directorName], [directorSurname]) VALUES (8, N'Todd', N'Phillips')
SET IDENTITY_INSERT [dbo].[DIRECTOR] OFF
GO
SET IDENTITY_INSERT [dbo].[MOVIE] ON 

INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (1, N'Spider-Man: No Way Home', N'2021-12-31', 148, N'https://www.youtube.com/embed/JfVOs4VSpmA', N'With Spider-Man''s identity now revealed, Peter asks Doctor Strange for help. When a spell goes wrong, dangerous foes from other worlds start to appear, forcing Peter to discover what it truly means to be Spider-Man.', 1, 1, N'https://media.cinemaximum.com.tr/255//Files/POSTER/SpiderManNoWayHome_Poster_Main_y.jpg', N'https://static2.srcdn.com/wordpress/wp-content/uploads/2021/12/NWH-IMAX-Poster.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (3, N'Dune', N'2021-10-22', 156, N'https://www.youtube.com/embed/8g18jFHCLXk', N'Uzak bir gelecekte geçen "Dune", ailesi çöl gezegeni Arrakis’in kontrolüne sahip olan Paul Atreides’in hikayesini anlatıyor. Galaksinin farklı noktalarındaki gezegenler, rakip feodal aileler tarafından yönetilmektedir. Çok değerli bir kaynağın tek üreticisi olan çöl gezegeni Arrakis''in kontrolü asil aileler arasında son derece talep Feature adaptation of Frank Herbert''s science fiction novel about the son of a noble family entrusted with the protection of the most valuable asset and most vital element in the galaxy.', 2, 1, N'https://media.cinemaximum.com.tr/255//Files/POSTER/DUNE_Poster.jpg', N'https://posterspy.com/wp-content/uploads/2020/04/DuneFINAL-1500x761.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (4, N'Interstellar', N'2014-11-07', 169, N'https://www.youtube.com/embed/zSWdZVtXT7E', N'A team of explorers travel through a wormhole in space in an attempt to ensure humanity''s survival.', 3, 1, N'https://tr.web.img2.acsta.net/pictures/14/10/09/15/52/150664.jpg', N'https://images-ext-1.discordapp.net/external/ka-DpSOd31jeyTmM7bP6hrsKJbqMyLDHQgqP877p600/%3Fd%3D1456501251/https/www.hometheaterforum.com/community/media/2014-interstellar-movie-poster.1964/full?width=1073&height=670')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (5, N'Who Am I?', N'2015-09-04', 106, N'https://www.youtube.com/embed/5vnjheCqRIs', N'Benjamin, a young German computer whiz, is invited to join a subversive hacker group that wants to be noticed on the world''s stage.', 4, 0, N'https://m.media-amazon.com/images/M/MV5BYmRiYjQ0OGQtYTAzMi00OGVjLWE4YTQtM2Q4YjBlZTBhMWM5XkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_.jpg', N'https://i.pinimg.com/originals/bb/3d/6e/bb3d6e91e482acded7dfee96e5474d82.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (8, N'Requiem For A Dream', N'2000-10-27', 102, N'https://www.youtube.com/embed/QBwzN4v1vA0', N'The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.', 5, 0, N'https://m.media-amazon.com/images/M/MV5BOTdiNzJlOWUtNWMwNS00NmFlLWI0YTEtZmI3YjIzZWUyY2Y3XkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg', N'https://hollywoodsuite.ca/wp-content/uploads/poster/HS903237_poster_1920_1080.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (9, N'Avengers:Infinity War', N'2018-04-27', 156, N'https://www.youtube.com/embed/6ZfuNTqbHE8', N'The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.', 6, 0, N'https://cdn.europosters.eu/image/750/posters/avengers-infinity-war-one-sheet-i58560.jpg', N'https://wallpaperaccess.com/full/95489.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (10, N'Kutsal Damacana(Sacred Demijohn)', N'2007-12-20', 105, N'https://www.youtube.com/embed/rJSL0_Wy49U', N'Son dönem Türkiye sinemasına karikatürist Ahmet Yılmaz dokunuşuyla enfes bir yön veren bir eser var karşımızda: Kutsal Damacana! Komedinin usta ismi Şafak Sezer''in başrolünü oynadığı film, çakma ama sevimli bir papazın kahkahalarla dolu komik ve sihirli macerasını farklı bir mizah üslubuyla beyaz perdeye taşıyor. Özel efektleri, animasyonları ve zengin post prodüksiyonuyla da son derece güçlü bir yapım olan "Kutsal Damacana" , dinamik hikayesi ve akıcı anlatım üslubuyla; heyecanı ve eğlencesi sürekli yükselen son dönemin en iddialı komedisi olarak bir kült statüsüne çoktan erişti bile.', 7, 1, N'https://m.media-amazon.com/images/M/MV5BNTUzM2YyZmQtYjVmZS00NWU5LWFjNmItODdjODg2NWRmYzk4XkEyXkFqcGdeQXVyMjExNjgyMTc@._V1_.jpg', N'https://www.boxerdergisi.com.tr/Content/Images/News/CoverSize/kutsal-damacana-filmi-nerede-cekildi-kutsal-damacana-oyuncu-kadrosu-ve-konusu-35623-18062019155628.jpg')
INSERT [dbo].[MOVIE] ([movieId], [movieName], [moviereleaseDate], [movieDuration], [movieTrailerUrl], [movieSummary], [movieDirectorId], [ısShowing], [moviePhotoUrl], [moviePosterUrl]) VALUES (13, N'Joker', N'2019-10-04', 122, N'https://www.youtube.com/embed/zAGVQLHvwOY', N'In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.', 8, 1, N'https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1000_.jpg', N'https://mankato.mnsu.edu/contentassets/c473932177bc4520866dc7f6c8794764/joker.jpg')
SET IDENTITY_INSERT [dbo].[MOVIE] OFF
GO
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (1, 1)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (2, 1)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (3, 1)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (4, 1)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (9, 3)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (10, 3)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (2, 3)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (11, 3)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (5, 4)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (6, 4)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (7, 4)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (8, 4)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (1, 5)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (15, 8)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (16, 8)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (17, 10)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (18, 13)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (19, 13)
INSERT [dbo].[MOVIE_HAS_ACTORS] ([actorId], [movieId]) VALUES (20, 13)
GO
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (1, 1)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (5, 5)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (3, 5)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (4, 2)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (8, 4)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (9, 2)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (10, 6)
INSERT [dbo].[MOVIE_HAS_CATEGORIES] ([movieId], [categoryId]) VALUES (13, 4)
GO
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 1)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 3)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 4)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 5)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 8)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 9)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (6, 10)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (1, 10)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (6, 3)
INSERT [dbo].[MOVIES_WATCHED] ([userId], [movieId]) VALUES (6, 13)
GO
SET IDENTITY_INSERT [dbo].[SEAT] ON 

INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (241, 1, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (242, 2, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (243, 3, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (244, 4, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (245, 5, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (246, 6, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (247, 7, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (248, 8, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (249, 9, 49, 0)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (250, 10, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (251, 11, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (252, 12, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (253, 13, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (254, 14, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (255, 15, 49, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (256, 1, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (257, 2, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (258, 3, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (259, 4, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (260, 5, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (261, 6, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (262, 7, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (263, 8, 50, 0)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (264, 9, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (265, 10, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (266, 11, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (267, 12, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (268, 13, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (269, 14, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (270, 15, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (271, 16, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (272, 17, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (273, 18, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (274, 19, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (275, 20, 50, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (276, 1, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (277, 2, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (278, 3, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (279, 4, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (280, 5, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (281, 6, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (282, 7, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (283, 8, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (284, 9, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (285, 10, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (286, 11, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (287, 12, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (288, 13, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (289, 14, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (290, 15, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (291, 16, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (292, 17, 51, 0)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (293, 18, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (294, 19, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (295, 20, 51, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (296, 1, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (297, 2, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (298, 3, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (299, 4, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (300, 5, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (301, 6, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (302, 7, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (303, 8, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (304, 9, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (305, 10, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (306, 11, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (307, 12, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (308, 13, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (309, 14, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (310, 15, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (311, 16, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (312, 17, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (313, 18, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (314, 19, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (315, 20, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (316, 21, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (317, 22, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (318, 23, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (319, 24, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (320, 25, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (321, 26, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (322, 27, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (323, 28, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (324, 29, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (325, 30, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (326, 31, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (327, 32, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (328, 33, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (329, 34, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (330, 35, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (331, 36, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (332, 37, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (333, 38, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (334, 39, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (335, 40, 52, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (336, 1, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (337, 2, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (338, 3, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (339, 4, 53, 1)
GO
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (340, 5, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (341, 6, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (342, 7, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (343, 8, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (344, 9, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (345, 10, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (346, 11, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (347, 12, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (348, 13, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (349, 14, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (350, 15, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (351, 16, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (352, 17, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (353, 18, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (354, 19, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (355, 20, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (356, 21, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (357, 22, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (358, 23, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (359, 24, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (360, 25, 53, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (361, 1, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (362, 2, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (363, 3, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (364, 4, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (365, 5, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (366, 6, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (367, 7, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (368, 8, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (369, 9, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (370, 10, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (371, 11, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (372, 12, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (373, 13, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (374, 14, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (375, 15, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (376, 16, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (377, 17, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (378, 18, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (379, 19, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (380, 20, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (381, 21, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (382, 22, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (383, 23, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (384, 24, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (385, 25, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (386, 26, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (387, 27, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (388, 28, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (389, 29, 54, 1)
INSERT [dbo].[SEAT] ([seatId], [seatNumber], [sessionId], [isAvailable]) VALUES (390, 30, 54, 1)
SET IDENTITY_INSERT [dbo].[SEAT] OFF
GO
SET IDENTITY_INSERT [dbo].[SESSION] ON 

INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (49, 1, 1, N'2022-01-01T12:00', 30)
INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (50, 4, 3, N'2022-01-01T00:00', 35)
INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (51, 13, 3, N'2022-01-05T10:00', 25)
INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (52, 3, 5, N'2022-01-20T15:00', 50)
INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (53, 13, 6, N'2022-01-20T08:00', 25)
INSERT [dbo].[SESSION] ([sessionId], [movieId], [cinemahallId], [time], [price]) VALUES (54, 1, 4, N'2022-01-26T04:00', 25)
SET IDENTITY_INSERT [dbo].[SESSION] OFF
GO
SET IDENTITY_INSERT [dbo].[TICKET] ON 

INSERT [dbo].[TICKET] ([ticketId], [userId], [sessionId], [seatId]) VALUES (10, 1, 50, 263)
INSERT [dbo].[TICKET] ([ticketId], [userId], [sessionId], [seatId]) VALUES (11, 1, 49, 249)
INSERT [dbo].[TICKET] ([ticketId], [userId], [sessionId], [seatId]) VALUES (12, 6, 51, 292)
SET IDENTITY_INSERT [dbo].[TICKET] OFF
GO
ALTER TABLE [dbo].[COMMENTS]  WITH CHECK ADD  CONSTRAINT [FK__COMMENT__movieI__656C112C] FOREIGN KEY([movieId])
REFERENCES [dbo].[MOVIE] ([movieId])
GO
ALTER TABLE [dbo].[COMMENTS] CHECK CONSTRAINT [FK__COMMENT__movieI__656C112C]
GO
ALTER TABLE [dbo].[COMMENTS]  WITH CHECK ADD  CONSTRAINT [FK__COMMENT__userId__3A81B327] FOREIGN KEY([userId])
REFERENCES [dbo].[CUSTOMER] ([userId])
GO
ALTER TABLE [dbo].[COMMENTS] CHECK CONSTRAINT [FK__COMMENT__userId__3A81B327]
GO
ALTER TABLE [dbo].[MOVIE]  WITH CHECK ADD  CONSTRAINT [FK__MOVIE__movieDire__4CA06362] FOREIGN KEY([movieDirectorId])
REFERENCES [dbo].[DIRECTOR] ([directorId])
GO
ALTER TABLE [dbo].[MOVIE] CHECK CONSTRAINT [FK__MOVIE__movieDire__4CA06362]
GO
ALTER TABLE [dbo].[MOVIE_HAS_ACTORS]  WITH CHECK ADD  CONSTRAINT [FK__MOVIE_HAS__actor__3D5E1FD2] FOREIGN KEY([actorId])
REFERENCES [dbo].[ACTOR] ([actorId])
GO
ALTER TABLE [dbo].[MOVIE_HAS_ACTORS] CHECK CONSTRAINT [FK__MOVIE_HAS__actor__3D5E1FD2]
GO
ALTER TABLE [dbo].[MOVIE_HAS_ACTORS]  WITH CHECK ADD  CONSTRAINT [FK__MOVIE_HAS__movie__534D60F1] FOREIGN KEY([movieId])
REFERENCES [dbo].[MOVIE] ([movieId])
GO
ALTER TABLE [dbo].[MOVIE_HAS_ACTORS] CHECK CONSTRAINT [FK__MOVIE_HAS__movie__534D60F1]
GO
ALTER TABLE [dbo].[MOVIE_HAS_CATEGORIES]  WITH CHECK ADD FOREIGN KEY([categoryId])
REFERENCES [dbo].[CATEGORY] ([categoryId])
GO
ALTER TABLE [dbo].[MOVIE_HAS_CATEGORIES]  WITH CHECK ADD  CONSTRAINT [FK__MOVIE_HAS__movie__5535A963] FOREIGN KEY([movieId])
REFERENCES [dbo].[MOVIE] ([movieId])
GO
ALTER TABLE [dbo].[MOVIE_HAS_CATEGORIES] CHECK CONSTRAINT [FK__MOVIE_HAS__movie__5535A963]
GO
ALTER TABLE [dbo].[MOVIES_WATCHED]  WITH CHECK ADD  CONSTRAINT [FK__MOVIES_WA__movie__6383C8BA] FOREIGN KEY([movieId])
REFERENCES [dbo].[MOVIE] ([movieId])
GO
ALTER TABLE [dbo].[MOVIES_WATCHED] CHECK CONSTRAINT [FK__MOVIES_WA__movie__6383C8BA]
GO
ALTER TABLE [dbo].[MOVIES_WATCHED]  WITH CHECK ADD  CONSTRAINT [FK__MOVIES_WA__userI__412EB0B6] FOREIGN KEY([userId])
REFERENCES [dbo].[CUSTOMER] ([userId])
GO
ALTER TABLE [dbo].[MOVIES_WATCHED] CHECK CONSTRAINT [FK__MOVIES_WA__userI__412EB0B6]
GO
ALTER TABLE [dbo].[SEAT]  WITH CHECK ADD  CONSTRAINT [FK_SEAT_SESSION] FOREIGN KEY([sessionId])
REFERENCES [dbo].[SESSION] ([sessionId])
GO
ALTER TABLE [dbo].[SEAT] CHECK CONSTRAINT [FK_SEAT_SESSION]
GO
ALTER TABLE [dbo].[SESSION]  WITH CHECK ADD  CONSTRAINT [FK__SESSION__cinemah__4316F928] FOREIGN KEY([cinemahallId])
REFERENCES [dbo].[CINEMA_HALL] ([cinemaHallId])
GO
ALTER TABLE [dbo].[SESSION] CHECK CONSTRAINT [FK__SESSION__cinemah__4316F928]
GO
ALTER TABLE [dbo].[SESSION]  WITH CHECK ADD  CONSTRAINT [FK__SESSION__movieId__5DCAEF64] FOREIGN KEY([movieId])
REFERENCES [dbo].[MOVIE] ([movieId])
GO
ALTER TABLE [dbo].[SESSION] CHECK CONSTRAINT [FK__SESSION__movieId__5DCAEF64]
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD  CONSTRAINT [FK__TICKET__sessionI__44FF419A] FOREIGN KEY([sessionId])
REFERENCES [dbo].[SESSION] ([sessionId])
GO
ALTER TABLE [dbo].[TICKET] CHECK CONSTRAINT [FK__TICKET__sessionI__44FF419A]
GO
ALTER TABLE [dbo].[TICKET]  WITH CHECK ADD  CONSTRAINT [FK__TICKET__userId__45F365D3] FOREIGN KEY([userId])
REFERENCES [dbo].[CUSTOMER] ([userId])
GO
ALTER TABLE [dbo].[TICKET] CHECK CONSTRAINT [FK__TICKET__userId__45F365D3]
GO
/****** Object:  StoredProcedure [dbo].[getAllMovies]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllMovies]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.movieId FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId ORDER BY T3.movieId
END
GO
/****** Object:  StoredProcedure [dbo].[getMovieById]    Script Date: 3.01.2022 21:05:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMovieById]
	-- Add the parameters for the stored procedure here
	@movieId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  * FROM (SELECT MOVIE.movieId,MOVIE.movieName,MOVIE.moviereleaseDate,MOVIE.movieDuration,MOVIE.movieTrailerUrl,MOVIE.movieSummary,MOVIE.movieDirectorId,MOVIE.ısShowing,MOVIE.moviePhotoUrl,MOVIE.moviePosterUrl,T1.categoryName,T1.categoryId FROM MOVIE INNER JOIN (SELECT CATEGORY.categoryName,MOVIE_HAS_CATEGORIES.* FROM MOVIE_HAS_CATEGORIES INNER JOIN CATEGORY ON CATEGORY.categoryId=MOVIE_HAS_CATEGORIES.categoryId) AS T1 ON MOVIE.movieId=T1.movieId) AS T3 INNER JOIN DIRECTOR ON T3.movieDirectorId=DIRECTOR.directorId WHERE movieId=@movieId
END
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
         Begin Table = "ACTOR"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 148
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MOVIE_HAS_ACTORS"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MOVIE"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 747
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
         Column = 3504
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MOVIE_AND_ACTOR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MOVIE_AND_ACTOR'
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
         Begin Table = "CATEGORY"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 126
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MOVIE"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MOVIE_HAS_CATEGORIES"
            Begin Extent = 
               Top = 7
               Left = 553
               Bottom = 126
               Right = 747
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
         Column = 3552
         Alias = 900
         Table = 2364
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 768
         Or = 924
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MOVIE_AND_CATEGORY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'MOVIE_AND_CATEGORY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[35] 2[5] 3) )"
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
         Left = -12
      End
      Begin Tables = 
         Begin Table = "SESSION"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TICKET"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 726
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
         Column = 3708
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TICKET_SESSION'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'TICKET_SESSION'
GO
USE [master]
GO
ALTER DATABASE [movie_database] SET  READ_WRITE 
GO
