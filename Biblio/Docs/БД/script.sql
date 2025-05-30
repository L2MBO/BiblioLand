USE [master]
GO
/****** Object:  Database [Biblio_Liamkin]    Script Date: 27.05.2025 5:37:39 ******/
CREATE DATABASE [Biblio_Liamkin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblio_Liamkin', FILENAME = N'C:\Users\lamki\Desktop\GG\C#\БД\Biblio_Liamkin.mdf' , SIZE = 70656KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblio_Liamkin_log', FILENAME = N'C:\Users\lamki\Desktop\GG\C#\БД\Biblio_Liamkin_log.ldf' , SIZE = 69568KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Biblio_Liamkin] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblio_Liamkin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblio_Liamkin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblio_Liamkin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblio_Liamkin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Biblio_Liamkin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblio_Liamkin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET RECOVERY FULL 
GO
ALTER DATABASE [Biblio_Liamkin] SET  MULTI_USER 
GO
ALTER DATABASE [Biblio_Liamkin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblio_Liamkin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblio_Liamkin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblio_Liamkin] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblio_Liamkin] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblio_Liamkin] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Biblio_Liamkin', N'ON'
GO
ALTER DATABASE [Biblio_Liamkin] SET QUERY_STORE = OFF
GO
USE [Biblio_Liamkin]
GO
/****** Object:  Table [dbo].[BookReports]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookReports](
	[BookReportID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[BookID] [int] NULL,
	[ReportCategoryID] [int] NULL,
	[ReportMessage] [nvarchar](max) NULL,
	[ReportDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Author] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](255) NULL,
	[PdfPath] [nvarchar](255) NULL,
	[TotalPages] [int] NULL,
	[GenreID] [int] NULL,
	[CategoryID] [int] NULL,
	[OftenSearched] [int] NULL,
	[AverageRating] [decimal](5, 2) NULL,
	[AddedDate] [datetime] NULL,
 CONSTRAINT [PK__Books__3DE0C22754D4C8D6] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[BookID] [int] NULL,
	[Rating] [int] NULL,
 CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportCategory]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportCategory](
	[ReportCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ReportCategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[BookID] [int] NULL,
	[Comment] [nvarchar](max) NULL,
	[LikesCount] [int] NULL,
	[ReviewDate] [datetime] NULL,
 CONSTRAINT [PK__Reviews__74BC79AE41C6B527] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserBookmarks]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserBookmarks](
	[UserBookID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[BookID] [int] NULL,
	[CurrentPage] [int] NULL,
	[CategoryID] [int] NULL,
	[LastReadDate] [datetime] NULL,
 CONSTRAINT [PK__UserBook__82C73910A8F3134B] PRIMARY KEY CLUSTERED 
(
	[UserBookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCategories]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserRoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.05.2025 5:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[CoinsNumber] [int] NULL,
	[Descriotion] [nvarchar](max) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[UserRoleID] [int] NOT NULL,
	[RegistrationDate] [datetime] NULL,
	[ConfirmationCode] [nvarchar](6) NULL,
	[ConfirmationCodeExpiration] [datetime] NULL,
	[AvatarPath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__Users__1788CCACA016861A] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookReports] ON 

INSERT [dbo].[BookReports] ([BookReportID], [UserID], [BookID], [ReportCategoryID], [ReportMessage], [ReportDate]) VALUES (1, 29, 39, 3, N'test', NULL)
INSERT [dbo].[BookReports] ([BookReportID], [UserID], [BookID], [ReportCategoryID], [ReportMessage], [ReportDate]) VALUES (2, 29, 7, 1, N'test', NULL)
INSERT [dbo].[BookReports] ([BookReportID], [UserID], [BookID], [ReportCategoryID], [ReportMessage], [ReportDate]) VALUES (3, 29, 18, 2, N'test', CAST(N'2025-05-27T05:34:47.373' AS DateTime))
SET IDENTITY_INSERT [dbo].[BookReports] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (1, N'О войне', N'Карл фон Клаузевиц', N'Основополагающая работа по военному искусству, где Карл фон Клаузевиц анализирует стратегию и тактику военных действий, а также роль политики в ведении войны. Книга является фундаментальным текстом для военных историков и теоретиков.', N'voina.jpg', N'voina.pdf', 0, 1, 3, NULL, CAST(9.50 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (2, N'Государь', N'Никколо Макиавелли', N'Классический труд политического мышления, где Никколо Макиавелли описывает принципы правления и политических манёвров. Книга стала основополагающим текстом для политических наставников и исследователей.', N'gosudar.jpg', N'gosudar.pdf', 0, 2, 3, 1, CAST(10.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (3, N'Сумма теологии', N'Фома Аквинский', N'Книга выдающегося историка философии М.Грабманна вводит в проблематику "Суммы теологии" Фомы Аквинского, самого значительного труда европейского Средневековья. Автор раскрывает исторический контекст, в котором создавалась "Сумма", обращается к работам предшественников, современников и комментаторов Аквината, приводя колоссальный массив исторического материала; кроме того, особо исследуется непреходящее значение этого труда для католической богословской мысли.', N'summa.jpg', N'summa_teologii.pdf', 0, 3, 3, 1, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (4, N'1984', N'Джордж Оруэлл', N'Антиутопия XX века, где правительство контролирует все аспекты жизни граждан, используя технологию и психическую манипуляцию. Роман исследует темы тоталитаризма, цензуры и свободы мысли.', N'1984.jpg', N'1984.pdf', 0, 4, 2, NULL, CAST(9.00 AS Decimal(5, 2)), CAST(N'2025-04-27T20:00:10.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (5, N'Шерлок Холмс: Убийство в Восточном экспрессе', N'Артур Конан Дойл', N'Классический детектив Шерлока Холмса, где герой решает загадочное убийство на поезде. Роман полон интриг, загадок и научного расследования.', N'sherlock.jpg', N'sherlock.pdf', 0, 5, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (6, N'Биография писателя: Александр Сергеевич Пушкин', N'Ю.М.Лотман', N'В книге на основе богатого фактического материала рассказывается о жизни великого русского поэта А. С. Пушкина, творчество которого составило эпоху в развитии русской литературы. Обстоятельно характеризуется личность поэта, его душевный склад. Широко показана политическая, общественная, культурная жизнь эпохи, в которую жил и творил Пушкин, его окружение — родные, друзья, соратники по литературной борьбе. Особое внимание уделено связям Пушкина с революционным движением своего времени, с передовым литературным движением эпохи.', N'pushkin_biografiya.jpg', N'pushkin_biografiya.pdf', 0, 6, 2, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-27T18:30:10.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (7, N'Апология математики', N'Владимир Андреевич Успенский', N'Успенский Владимир Андреевич - доктор физико-математических наук, профессор, заведующий кафедрой математической логики и теории алгоритмов механикоматематического факультета МГУ им. М. В. Ломоносова. Родился в 1930 году. Автор филологических и культурологических статей, опубликованных в журналах «Новое литературное обозрение», «Неприкосновенный запас» и других изданиях. Постоянный автор «Нового мира». Книга представляет собой глубокий анализ математики и её роли в современном мире.', N'apologia_matematiki.jpg', N'apologia_matematiki.pdf', 0, 7, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (8, N'Евгений Онегин', N'А.С. Пушкин', N'«Евгений Онегин» – роман в стихах великого русского поэта, драматурга, прозаика, создателя современного русского литературного языка Александра Сергеевича Пушкина (1799-1837). Написан в 1823-1831 годы. Роман исследует жизнь молодого дворянина Онегина и его отношения с девушкой Татьяной. Пушкин использовал в романе множество стихотворных форм, что делает его уникальным произведением русской литературы.', N'evgeniy_onegin.jpg', N'evgeniy_onegin.pdf', 0, 8, 3, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (9, N'Сто лет одиночества', N'Габриэль Гарсиа Маркес', N'Классический роман магического реализма, где Габриэль Гарсиа Маркес рассказывает о семье Буэнди, живущей в изолированном городе Маккондо. Роман полон магических элементов, циклических событий и философских размышлений о времени и человеческой судьбе.', N'100_let.jpg', N'100_let.pdf', 0, 9, 2, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-27T20:52:10.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (10, N'Война и мир', N'Лев Толстой', N'Эпический роман Льва Толстого, охватывающий период с конца XVIII по начало XIX века. Роман исследует жизнь нескольких дворянских семей, влияние революции 1812 года и Наполеоновских войн на Россию. Толстой использует в романе огромное количество персонажей и подробных описаний исторических событий.', N'voina_i_mir.jpg', N'voina_i_mir.pdf', 0, 9, 3, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (11, N'Мастер и Маргарита', N'Михаил Булгаков', N'Роман Михаила Булгакова, написанный в 1928-1939 годах, но опубликованный только после смерти автора в 1966 году. Роман сочетает реальную историю жизни Мастера и мифическую историю о том, как Маргарита встречает Сатану и его послов в Москве. Булгаков исследует темы любви, веры, власти и свободы.', N'master_i_margarita.jpg', N'master_i_margarita.pdf', 0, 8, 3, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (12, N'Приключения Тома Сойера', N'Марк Твен', N'Юмористический роман Марка Твена о приключениях подростка Тома Сойера в городке Миссури. Роман полон забавных историй, друзей и приключений, а также исследует темы дружбы, добрых дел и природы человеческого характера.', N'tom_soyer.jpg', N'tom_soyer.pdf', 80, 8, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (13, N'Тёмная башня', N'Стивен Кинг', N'Эпический фэнтезийный роман Стивена Кинга, где главный герой Роланд Десчанский путешествует по мосту к Тёмной башне, чтобы встретиться с его женой Эадуиной и сыграть решающую роль в борьбе со злом. Книга полна философских размышлений и мистических элементов.', N'temnaya_bashnya.jpg', N'temnaya_bashnya.pdf', 0, 4, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (14, N'Гарри Поттер и философский камень', N'Дж.К. Роулинг', N'Первая книга в серии о Гарри Поттере, где мальчик узнаёт о своей жизни в магическом мире и поступает в школу магии Хогвартс. Роулинг исследует темы дружбы, семьи, добра и зла, а также волшебства и магии.', N'harry_potter.jpg', N'harry_potter.pdf', 360, 4, 3, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (15, N'Дюймовочка', N'Ханса Кристиана Андерсена', N'Классическая фольклорная сказка Ханса Кристиана Андерсена о маленькой девочке, которая сталкивается с трудностями и преодолевает их, чтобы стать настоящей принцессой. Сказка исследует темы красоты, доброты и справедливости.', N'dyumovochka.jpg', N'dyumovochka.pdf', 60, 8, 1, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T19:50:10.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (16, N'Братья Карамазовы', N'Фёдор Достоевский', N'Эпический роман Фёдора Достоевского о семье Карамазовых, которая столкнулась с серьёзными семейными проблемами и вопросами веры, свободы и ответственности. Достоевский исследует глубокие психологические портреты персонажей и философские темы.', N'karamazovy.jpg', N'karamazovy.pdf', 0, 7, 2, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-27T20:10:10.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (17, N'Преступление и наказание', N'Фёдор Достоевский', N'Роман Фёдора Достоевского о студенте Родионе Раскольнике и его преступлении. Достоевский исследует темы совести, наказания и духовного поиска человека, а также философские вопросы свободы и ответственности.', N'prestuplenie.jpg', N'prestuplenie.pdf', 0, 7, 1, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-28T01:26:00.000' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (18, N'Герой нашего времени', N'Михаил Юрьевич Лермонтов', N'Роман Михаила Юрьевича Лермонтова о лихаче Пьере Милюшкове, который убегает из военного учреждения и сталкивается с различными жизненными трудностями. Лермонтов исследует темы любви, веры и человеческого характера, а также философские вопросы.', N'geroi_nashego_vremeny.jpg', N'hero.pdf', 0, 8, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (19, N'Атлант расправил плечи', N'Айн Рэнд', N'Роман Айн Рэнда о бизнесмене Даниеле Данилевиче и его борьбе за капитализм и индивидуальность. Рэнд исследует экономические, этические и философские аспекты свободы и ответственности.', N'atlas_shrugged.jpg', N'atlas_shrugged.pdf', 120, 9, 3, 1, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (20, N'Смысл любви', N'Владимир Соловьев', N'Владимир Соловьев - одна из важнейших фигур в русской культуре, гениальная и разносторонняя личность, оказавшая огромное влияние на целое поколение мыслителей, писателей и поэтов Серебряного века. В эстетике Соловьев развил мысль о деятельном искусстве, которое, воскрешая образы прошлого, воскрешает в человеке его самую подлинную любовь. Как определяет Соловьев: "Любовь, как действительное упразднение эгоизма, есть действительное оправдание и спасение индивидуальности". Сколь ни были бы разнообразны предметы, которыми занимался Соловьев, одно общее в них: переживание мысли как живого существа. Мысль для него - та глубина в нас самих, о которой мы не догадываемся так же, как мы не догадываемся о своей влюбленности, пока не влюбимся.', N'smisl_lubvi.jpg', N'smisl_lubvi.pdf', 0, 9, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (21, N'О военном искусстве', N'Никколо Макиавелли', N'Никколо Макиавелли — один из самых известных итальянских мыслителей и политических деятелей эпохи Возрождения (занимал во Флоренции пост государственного секретаря), писатель, историк, военный теоретик, создавший ряд историко-политических сочинений («Рассуждения о первой декаде Тита Ливия», «История Флоренции»). Самым значительным и неоднозначным его произведением стал трактат «Государь». Долгие годы эта книга ассоциировалась с политикой яда и кинжала, а после ее выхода появился термин «макиавеллизм», обозначающий цинизм, вседозволенность, двуличие в политике. Настоящее издание знакомит читателя с трактатом Макиавелли «О военном искусстве», стоящим в одном ряду с величайшими работами по теории военного дела. Именно здесь впервые звучат идеи, важность которых для последующей истории западного мира трудно переоценить и которые подкреплены множеством примеров великих побед и поражений древности. Трактат «О военном искусстве» представлен в новом переводе и сопровождается статьей и подробными примечаниями.', N'o_voennom_iscusstve.jpg', N'o_voennom_iscusstve.pdf', 0, 2, 3, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (22, N'Критика чистого разума', N'Иммануил Кант', N'Классический философский труд Иммануила Канта, в котором он исследует границы человеческого познания и формирует основы критического философия.', N'kritika_chistogo_razuma.jpg', N'kritika_chistogo_razuma.pdf', 0, 3, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (23, N'Тень великого человека', N'Артур Конан Дойл', N'Детективный роман Артура Конан Дойла, где Шерлок Холмс расследует загадочное убийство, происходящее в доме с таинственным черным теневым существом. Книга полна интриг и мистических элементов.', N'ten_velicogo_cheloveka.jpg', N'chernyy_ten.pdf', 0, 5, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (24, N'Биография Наполеона Бонапарта', N'Эндрю Робертс', N'Историческая биография Эндрю Робертс о жизни и правлении Наполеона Бонапарта, одного из самых влиятельных военных и политических лидеров в истории Франции. Книга подробно рассказывает о его карьере, победах и поражениях.', N'napoleon.jpg', N'napoleon.pdf', 0, 6, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (25, N'В окопах Сталинграда', N'Виктор Некрасов', N'Историческое описание величайшего сражения Второй мировой войны, которое стало одним из ключевых моментов в Великой Отечественной войне. Книга подробно рассказывает о боях, личностях участников и последствиях сражения.', N'v_okopax.jpg', N'stalingrad.pdf', 0, 1, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (26, N'Внешняя политика древнего Рима', N'А.Л. Панищев', N'Историческое исследование политических процессов и институтов в древнем Риме. Панищев подробно рассказывает о римских политических деятелях, законодательстве и влиянии политики на развитие города.', N'vneshnyaya_politika.jpg', N'rome.pdf', 0, 2, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (27, N'Смысл жизни и цена человека', N'Владимир Соловьев', N'Философское исследование вопроса смысла жизни, основанное на учении Владимира Соловьева. Книга рассматривает философские и религиозные аспекты смысла человеческой жизни и её место в мире.', N'smisl_zizni.jpg', N'smysl_zhizni.pdf', 0, 3, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (28, N'Убийства в белом монастыре', N'Джон Диксон Карр', N'Золотой век детектива оставил немало звездных имен – А. Кристи, Г. К. Честертон, Г. Митчелл и др. В этой яркой плеяде Джон Диксон Карр (1906–1977) занимает самое почетное место. «Убийство в запертой комнате», где нет места бешеным погоням и перестрелкам, а круг подозреваемых максимально ограничен, – излюбленный сюжет автора. Карр вовлекает читателя в искусную игру, заманивая в сети ловко расставленных ловушек, ложных подсказок, обманных ходов и тонких намеков, и предлагает принять участие в решении хитроумной головоломки. Роман «Убийства в чумном дворе», который был написан в 1930-е годы под псевдонимом Картер Диксон открывает серию книг о великолепном сэре Генри Мерривейле – обаятельном, эксцентричном, взбалмошном толстяке, ставшем, по признанию критиков, одним из самых неординарных сыщиков в детективной литературе.', N'ubiystvo_v_belom.jpg', N'monastery.pdf', 240, 5, 1, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (29, N'С.А. Есенин в жизни и творчистве', N'Н.И. Шубникова-Гусева', N'Книга знакомит с основными вехами жизненного и творческого пути С. А. Есенина, содержит анализ его произведений, в том числе входящих в школьную программу, а также богатый иллюстративный материал.

Книга адресована старшеклассникам, учителям- словесникам и всем любителям отечественной литературы.', N'esenin_biografiya.jpg', N'esenin_biografiya.pdf', 0, 6, 2, NULL, CAST(0.00 AS Decimal(5, 2)), NULL)
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (30, N'Как писать книги', N'Стивен Кинг', N'Это, пожалуй, самая необычная из книг Стивена Кинга. Книга, в которой автобиографические, мемуарные мотивы соседствуют не только с размышлениями о писательском искусстве вообще, но и с самыми настоящими "профессиональными советами тем, кто хочет писать как Стивен Кинг".
Как формируется писатель? Каковы главные "секреты" его нелегкого "ремесла"? Что вообще необходимо знать и уметь человеку, чтобы его творения возглавляли международные списки бестселлеров?
Вот лишь немногие из вопросов, на которые вы найдете ответы в этой книге. Вы действительно хотите писать как Стивен Кинг? Тогда не пропустите эту книгу.', N'kak_pisat_knigi.jpg', N'kak_pisat_knigi.pdf', 0, 7, 1, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T23:41:42.700' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (35, N'Кэри', N'Стивен Кинг', N'Маленький провинциальный городок в Новой Англии в одночасье становится "мертвым городом". На улицах лежат трупы, над домами бушует смертоносное пламя. И весь этот кошмар огненного Апокалипсиса — дело рук одного человека, девушки Кэрри, жалкой, запуганной дочери чудаковатой вдовы. Долгие годы дремал в Кэрри талант телекинеза, чтобы однажды проснуться.
И тогда в городок пришла смерть... ', N'kerry.jpg', N'kerry.pdf', 0, 10, 2, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T23:44:37.560' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (37, N'Оно ', N'Стивен кинг', N'Один из самых масштабных и известных романов Стивена Кинга — теперь и в популярной серии «Эксклюзивная классика»! Лето 1958 года. Загадочный убийца терроризирует маленький городок Дерри в штате Мэн, принимая самые разные облики и жестоко убивая детей. Одиннадцатилетние подростки — Билли, Беверли, Майк, Ричи, Эдди, Бен и Стэн — по очереди сталкиваются со злом и остаются в живых. Объединившись в «Клуб неудачников», ребята клянутся выследить и уничтожить монстра, получившего от них кличку «Оно»…
', N'ono.jpg', N'ono.pdf', 0, 10, 3, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T23:48:39.980' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (38, N'Придворный', N'Кастильоне Бальдассаре', N'Сочинение итальянского дипломата, писателя и поэта Бальдассаре Кастильоне (1478–1529) «Придворный», соединяющее воспоминания о придворной жизни герцогства Урбино в начале XVI века с размышлениями о морали, предназначении, стиле поведения дворянина, приближенного к государю, — одна из тех книг эпохи Возрождения, что не теряли популярности на протяжении последующих веков и были любимы самыми блестящими умами своего и будущих столетий. Для истории культуры труд Кастильоне явился подлинной сокровищницей, и трудно представить, насколько более скудными оказались бы знания потомков об эпохе Возрождения, не будь он создан. Составленное в виде сборника занимательных и остроумных бесед, это ярко и непринужденно написанное произведение выходит за рамки источника сведений о придворных развлечениях своего времени и перечня достоинств совершенного придворного как всесторонне образованного и утончённо воспитанного человека, идеального с точки зрения гуманистических представлений.', N'pridvorniy.jpg', N'pridvorniy.pdf', 0, 7, 3, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T23:51:11.567' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (39, N'Дракула', N'Брэм Стокер', N'Молодой лондонский адвокат по поручению своего патрона едет в загадочную Трансильванию в замок таинственного графа Дракулы, совершенно не подозревая, что ждет его там...
Культовый роман о вампирах, супербестселлер всех времен и народов.', N'drakula.jpg', N'drakula.pdf', 0, 10, 1, 1, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-04-30T23:59:48.100' AS DateTime))
INSERT [dbo].[Books] ([BookID], [Title], [Author], [Description], [ImagePath], [PdfPath], [TotalPages], [GenreID], [CategoryID], [OftenSearched], [AverageRating], [AddedDate]) VALUES (41, N'Кладбище домашних животных', N'Стивен Кинг', N'Роман, который сам Кинг, считая «слишком страшным», долго не хотел отдавать в печать, но только за первый год было продано 657 000 экземпляров! Роман лег в основу одноименного фильма Мэри Ламберт (где Кинг, кстати, сыграл небольшую роль). Казалось бы, семейство Крид  это настоящее воплощение «американской мечты»: отец  преуспевающий врач, красавица мать, прелестные дети. Для полной идиллии им не хватает лишь большого старинного дома, куда они вскоре и переезжают. 

Но идиллия вдруг стала превращаться в кошмар. Потому что в окружающих их новое жилище вековых лесах скрывается НЕЧТО, более ужасное, чем сама смерть и... более могущественное.', N'klatbishe.jpg', N'klatbishe.pdf', 0, 10, 1, NULL, CAST(0.00 AS Decimal(5, 2)), CAST(N'2025-05-01T00:03:51.400' AS DateTime))
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Главная')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Популярное')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Новинки')
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (6, N'Биография')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (1, N'Военное дело')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (5, N'Детектив')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (7, N'Научная литература')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (2, N'Политика')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (9, N'Роман')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (10, N'Ужасы')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (4, N'Фантастика')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (3, N'Философия')
INSERT [dbo].[Genres] ([GenreID], [GenreName]) VALUES (8, N'Художественная литература')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Rating] ON 

INSERT [dbo].[Rating] ([RatingID], [UserID], [BookID], [Rating]) VALUES (2, 2, 1, 10)
INSERT [dbo].[Rating] ([RatingID], [UserID], [BookID], [Rating]) VALUES (3, 2, 2, 10)
INSERT [dbo].[Rating] ([RatingID], [UserID], [BookID], [Rating]) VALUES (4, 1, 1, 9)
INSERT [dbo].[Rating] ([RatingID], [UserID], [BookID], [Rating]) VALUES (7, 1, 4, 9)
SET IDENTITY_INSERT [dbo].[Rating] OFF
GO
SET IDENTITY_INSERT [dbo].[ReportCategory] ON 

INSERT [dbo].[ReportCategory] ([ReportCategoryID], [ReportCategoryName]) VALUES (3, N'Другое')
INSERT [dbo].[ReportCategory] ([ReportCategoryID], [ReportCategoryName]) VALUES (1, N'Дубль')
INSERT [dbo].[ReportCategory] ([ReportCategoryID], [ReportCategoryName]) VALUES (2, N'Несоответствие жанра')
SET IDENTITY_INSERT [dbo].[ReportCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 

INSERT [dbo].[Reviews] ([ReviewID], [UserID], [BookID], [Comment], [LikesCount], [ReviewDate]) VALUES (1, 2, 1, N'Отличная книга!', 0, CAST(N'2023-05-10T12:10:00.000' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [UserID], [BookID], [Comment], [LikesCount], [ReviewDate]) VALUES (2, 2, 2, N'Восхитительная работа!', 0, CAST(N'2023-06-10T13:10:00.000' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [UserID], [BookID], [Comment], [LikesCount], [ReviewDate]) VALUES (3, 1, 1, N'Интересная книга!', 0, CAST(N'2023-05-10T12:10:00.000' AS DateTime))
INSERT [dbo].[Reviews] ([ReviewID], [UserID], [BookID], [Comment], [LikesCount], [ReviewDate]) VALUES (4, 1, 4, N'Интересный роман.', 0, CAST(N'2023-03-10T12:15:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
SET IDENTITY_INSERT [dbo].[UserBookmarks] ON 

INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (1, 2, 1, 0, 1, CAST(N'2023-01-10T10:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (2, 2, 2, 0, 1, CAST(N'2023-04-10T11:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (3, 2, 3, 0, 2, CAST(N'2023-04-10T11:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (4, 1, 4, 0, 1, CAST(N'2023-05-10T14:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (5, 1, 2, 0, 1, CAST(N'2023-05-10T14:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (6, 1, 5, 0, 4, CAST(N'2023-05-10T14:00:00.000' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (7, 29, 19, 30, 2, CAST(N'2025-05-26T23:21:12.557' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (8, 29, 28, 1, 2, CAST(N'2025-05-25T01:15:55.967' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (9, 29, 14, 1, 2, CAST(N'2025-05-02T00:17:12.570' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (10, 29, 12, 1, 2, CAST(N'2025-05-02T00:17:20.313' AS DateTime))
INSERT [dbo].[UserBookmarks] ([UserBookID], [UserID], [BookID], [CurrentPage], [CategoryID], [LastReadDate]) VALUES (11, 29, 15, 1, 2, CAST(N'2025-05-02T00:18:05.883' AS DateTime))
SET IDENTITY_INSERT [dbo].[UserBookmarks] OFF
GO
SET IDENTITY_INSERT [dbo].[UserCategories] ON 

INSERT [dbo].[UserCategories] ([CategoryID], [CategoryName]) VALUES (5, N'Брошено')
INSERT [dbo].[UserCategories] ([CategoryID], [CategoryName]) VALUES (3, N'Буду читать')
INSERT [dbo].[UserCategories] ([CategoryID], [CategoryName]) VALUES (4, N'Отложено')
INSERT [dbo].[UserCategories] ([CategoryID], [CategoryName]) VALUES (1, N'Прочитано')
INSERT [dbo].[UserCategories] ([CategoryID], [CategoryName]) VALUES (2, N'Читаю')
SET IDENTITY_INSERT [dbo].[UserCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([UserRoleID], [RoleName]) VALUES (2, N'Admin')
INSERT [dbo].[UserRoles] ([UserRoleID], [RoleName]) VALUES (1, N'User')
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [CoinsNumber], [Descriotion], [Email], [PasswordHash], [UserRoleID], [RegistrationDate], [ConfirmationCode], [ConfirmationCodeExpiration], [AvatarPath]) VALUES (1, N'Denis', 0, NULL, N'den@gmail.com', N'$2b$10$GE8vI4d8eirZt/LPZBab3.au.u3kATg1Jd1cuWDUPDG6T3d4uDfWC', 1, CAST(N'2025-04-08T05:33:10.700' AS DateTime), NULL, NULL, N'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')
INSERT [dbo].[Users] ([UserID], [Username], [CoinsNumber], [Descriotion], [Email], [PasswordHash], [UserRoleID], [RegistrationDate], [ConfirmationCode], [ConfirmationCodeExpiration], [AvatarPath]) VALUES (2, N'User1', 0, NULL, N'user2@example.com', N'$2b$10$GE8vI4d8eirZt/LPZBab3.au.u3kATg1Jd1cuWDUPDG6T3d4uDfWC', 1, CAST(N'2025-04-08T05:33:10.700' AS DateTime), NULL, NULL, N'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')
INSERT [dbo].[Users] ([UserID], [Username], [CoinsNumber], [Descriotion], [Email], [PasswordHash], [UserRoleID], [RegistrationDate], [ConfirmationCode], [ConfirmationCodeExpiration], [AvatarPath]) VALUES (29, N'DenisTest', 10000, NULL, N'lamkindenis127@gmail.com', N'$2b$10$GE8vI4d8eirZt/LPZBab3.au.u3kATg1Jd1cuWDUPDG6T3d4uDfWC', 2, CAST(N'2025-04-16T17:47:59.417' AS DateTime), NULL, NULL, N'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')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Genres__BBE1C33957BB6520]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[Genres] ADD UNIQUE NONCLUSTERED 
(
	[GenreName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ReportCa__8517B2E05C3F0C82]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[ReportCategory] ADD UNIQUE NONCLUSTERED 
(
	[ReportCategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Categori__8517B2E0F380C553]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[UserCategories] ADD UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__UserRole__8A2B6160BF8D1535]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[UserRoles] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__536C85E478041D67]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ__Users__536C85E478041D67] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D10534D6612A9D]    Script Date: 27.05.2025 5:37:39 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ__Users__A9D10534D6612A9D] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_TotalPages]  DEFAULT ((0)) FOR [TotalPages]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF__Books__AverageRa__300424B4]  DEFAULT ((0.00)) FOR [AverageRating]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF__Books__AddedDate__19AACF41]  DEFAULT (getdate()) FOR [AddedDate]
GO
ALTER TABLE [dbo].[Reviews] ADD  CONSTRAINT [DF__Reviews__LikesCo__324172E1]  DEFAULT ((0)) FOR [LikesCount]
GO
ALTER TABLE [dbo].[UserBookmarks] ADD  CONSTRAINT [DF_UserBooks_CurrentPage]  DEFAULT ((0)) FOR [CurrentPage]
GO
ALTER TABLE [dbo].[UserBookmarks] ADD  CONSTRAINT [DF__UserBooks__Added__36B12243]  DEFAULT (getdate()) FOR [LastReadDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_CoinsNumber]  DEFAULT ((0)) FOR [CoinsNumber]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Registrat__29572725]  DEFAULT (getdate()) FOR [RegistrationDate]
GO
ALTER TABLE [dbo].[BookReports]  WITH CHECK ADD FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[BookReports]  WITH CHECK ADD FOREIGN KEY([ReportCategoryID])
REFERENCES [dbo].[ReportCategory] ([ReportCategoryID])
GO
ALTER TABLE [dbo].[BookReports]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK__Books__GenreID__30F848ED] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genres] ([GenreID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK__Books__GenreID__30F848ED]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Category]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Books]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_Users]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Books]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Users]
GO
ALTER TABLE [dbo].[UserBookmarks]  WITH CHECK ADD  CONSTRAINT [FK__UserBooks__BookI__38996AB5] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([BookID])
GO
ALTER TABLE [dbo].[UserBookmarks] CHECK CONSTRAINT [FK__UserBooks__BookI__38996AB5]
GO
ALTER TABLE [dbo].[UserBookmarks]  WITH CHECK ADD  CONSTRAINT [FK__UserBooks__Categ__398D8EEE] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[UserCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[UserBookmarks] CHECK CONSTRAINT [FK__UserBooks__Categ__398D8EEE]
GO
ALTER TABLE [dbo].[UserBookmarks]  WITH CHECK ADD  CONSTRAINT [FK__UserBooks__UserI__37A5467C] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[UserBookmarks] CHECK CONSTRAINT [FK__UserBooks__UserI__37A5467C]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserRoles] FOREIGN KEY([UserRoleID])
REFERENCES [dbo].[UserRoles] ([UserRoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserRoles]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [CK_Rating_Rating] CHECK  (([Rating]>=(1) AND [Rating]<=(10)))
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [CK_Rating_Rating]
GO
USE [master]
GO
ALTER DATABASE [Biblio_Liamkin] SET  READ_WRITE 
GO
