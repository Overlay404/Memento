USE [memento_pro]
GO
ALTER DATABASE [memento_pro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [memento_pro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [memento_pro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [memento_pro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [memento_pro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [memento_pro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [memento_pro] SET ARITHABORT OFF 
GO
ALTER DATABASE [memento_pro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [memento_pro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [memento_pro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [memento_pro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [memento_pro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [memento_pro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [memento_pro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [memento_pro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [memento_pro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [memento_pro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [memento_pro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [memento_pro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [memento_pro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [memento_pro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [memento_pro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [memento_pro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [memento_pro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [memento_pro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [memento_pro] SET  MULTI_USER 
GO
ALTER DATABASE [memento_pro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [memento_pro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [memento_pro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [memento_pro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [memento_pro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [memento_pro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [memento_pro] SET QUERY_STORE = OFF
GO
USE [memento_pro]
GO
/****** Object:  Table [dbo].[Division]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Division](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Division] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_Division]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Division](
	[EmployeeId] [int] NOT NULL,
	[DivisionId] [int] NOT NULL,
 CONSTRAINT [PK_Employee_Division] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC,
	[DivisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Id] [int] NOT NULL,
	[RequestTypeId] [int] NOT NULL,
	[RequestStatusId] [int] NOT NULL,
	[DivisionId] [int] NOT NULL,
	[DesiredStartDate] [date] NOT NULL,
	[DesiredExpirationDate] [date] NOT NULL,
	[VisitPurposeId] [int] NOT NULL,
	[UserId] [int] NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Request_Visitor]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request_Visitor](
	[RequestId] [int] NOT NULL,
	[VisitorId] [int] NOT NULL,
 CONSTRAINT [PK_Request_Visitor] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC,
	[VisitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestRejectionReason]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestRejectionReason](
	[Id] [int] NOT NULL,
	[RequestId] [int] NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RequestRejectionReason] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestStatus]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestStatus](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RequestStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestType]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RequestType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](64) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitor]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitor](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[Phone] [char](20) NULL,
	[Email] [nvarchar](320) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[PassportSeries] [char](4) NOT NULL,
	[PassportNumber] [char](6) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[OrganizationId] [int] NULL,
	[Note] [nvarchar](max) NOT NULL,
	[Photo] [varbinary](max) NULL,
	[PassportScan] [varbinary](max) NOT NULL,
	[PassportScanFileName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitPurpose]    Script Date: 13.05.2023 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitPurpose](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_VisitPurpose] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Division] ([Id], [Name]) VALUES (1, N'Подразделение 1')
INSERT [dbo].[Division] ([Id], [Name]) VALUES (2, N'Подразделение 2')
INSERT [dbo].[Division] ([Id], [Name]) VALUES (3, N'Подразделение 3')
INSERT [dbo].[Division] ([Id], [Name]) VALUES (4, N'Подразделение 4')
INSERT [dbo].[Division] ([Id], [Name]) VALUES (5, N'Подразделение 5')
GO
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [UserId]) VALUES (1, N'Иван', N'Иванов', N'Иванович', 3002)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [UserId]) VALUES (2, N'Михаил', N'Михайлов', N'Михаилович', 3003)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [UserId]) VALUES (3, N'Станислав', N'Станиславов', N'Станиславович', 3004)
GO
INSERT [dbo].[Organization] ([Id], [Name]) VALUES (1, N'Организация 1')
INSERT [dbo].[Organization] ([Id], [Name]) VALUES (2, N'Организация 2')
INSERT [dbo].[Organization] ([Id], [Name]) VALUES (3, N'Организация 3')
INSERT [dbo].[Organization] ([Id], [Name]) VALUES (4, N'Организация 4')
INSERT [dbo].[Organization] ([Id], [Name]) VALUES (5, N'Организация 5')
GO
INSERT [dbo].[RequestStatus] ([Id], [Name]) VALUES (1, N'Проверка')
INSERT [dbo].[RequestStatus] ([Id], [Name]) VALUES (2, N'Одобрена')
INSERT [dbo].[RequestStatus] ([Id], [Name]) VALUES (3, N'Не одобрена')
GO
INSERT [dbo].[RequestType] ([Id], [Name]) VALUES (1, N'Личная')
INSERT [dbo].[RequestType] ([Id], [Name]) VALUES (2, N'Групповая')
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Login], [Password]) VALUES (2002, N'_Mazepa_', N'
��=�[�c�
��&�����"!�H>�pC��5����ȹ�R~��/��HZ1ͬ%�`$Pf4')
INSERT [dbo].[User] ([Id], [Login], [Password]) VALUES (3002, N'Ivan1234', N'�5B��M6 �.�+�:k@�~�CkM](,��@��*Gqk����)� ^�r�s&���	DT''Ğ"��e')
INSERT [dbo].[User] ([Id], [Login], [Password]) VALUES (3003, N'Michael1', N'o��	�����t��p��kPE��Ŕ��Ǆ+���{-�L&iO`�Y7I�L)�L����Xs�a^')
INSERT [dbo].[User] ([Id], [Login], [Password]) VALUES (3004, N'Stanislav', N'*[�''
sMۑ��Y���������n���>`4 G�0�BsKn!#�;s�宓�y����_�`Ϊ��')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
INSERT [dbo].[VisitPurpose] ([Id], [Name]) VALUES (1, N'Цель 1')
INSERT [dbo].[VisitPurpose] ([Id], [Name]) VALUES (2, N'Цель 2')
INSERT [dbo].[VisitPurpose] ([Id], [Name]) VALUES (3, N'Цель 3')
INSERT [dbo].[VisitPurpose] ([Id], [Name]) VALUES (4, N'Цель 4')
INSERT [dbo].[VisitPurpose] ([Id], [Name]) VALUES (5, N'Цель 5')
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_User]
GO
ALTER TABLE [dbo].[Employee_Division]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Division_Division] FOREIGN KEY([DivisionId])
REFERENCES [dbo].[Division] ([Id])
GO
ALTER TABLE [dbo].[Employee_Division] CHECK CONSTRAINT [FK_Employee_Division_Division]
GO
ALTER TABLE [dbo].[Employee_Division]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Division_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Employee_Division] CHECK CONSTRAINT [FK_Employee_Division_Employee]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Division] FOREIGN KEY([DivisionId])
REFERENCES [dbo].[Division] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Division]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Employee]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_RequestStatus] FOREIGN KEY([RequestStatusId])
REFERENCES [dbo].[RequestStatus] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_RequestStatus]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_RequestType] FOREIGN KEY([RequestTypeId])
REFERENCES [dbo].[RequestType] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_RequestType]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_User]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_VisitPurpose] FOREIGN KEY([VisitPurposeId])
REFERENCES [dbo].[VisitPurpose] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_VisitPurpose]
GO
ALTER TABLE [dbo].[Request_Visitor]  WITH CHECK ADD  CONSTRAINT [FK_Request_Visitor_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[Request_Visitor] CHECK CONSTRAINT [FK_Request_Visitor_Request]
GO
ALTER TABLE [dbo].[Request_Visitor]  WITH CHECK ADD  CONSTRAINT [FK_Request_Visitor_Visitor] FOREIGN KEY([VisitorId])
REFERENCES [dbo].[Visitor] ([Id])
GO
ALTER TABLE [dbo].[Request_Visitor] CHECK CONSTRAINT [FK_Request_Visitor_Visitor]
GO
ALTER TABLE [dbo].[RequestRejectionReason]  WITH CHECK ADD  CONSTRAINT [FK_RequestRejectionReason_Request] FOREIGN KEY([RequestId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[RequestRejectionReason] CHECK CONSTRAINT [FK_RequestRejectionReason_Request]
GO
ALTER TABLE [dbo].[Visitor]  WITH CHECK ADD  CONSTRAINT [FK_Visitor_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [dbo].[Organization] ([Id])
GO
ALTER TABLE [dbo].[Visitor] CHECK CONSTRAINT [FK_Visitor_Organization]
GO
USE [master]
GO
ALTER DATABASE [memento_pro] SET  READ_WRITE 
GO
