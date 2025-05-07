GO
CREATE DATABASE [Biletleme]
GO


USE [Biletleme]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[BirthDate] [datetime] NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CreatedTime] [datetime] NULL,
	[Gender] [int] NULL,
	[IsDeleted] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (1, N'karahan2', N'türker2', CAST(N'2008-12-29T00:00:00.000' AS DateTime), N'05554447898', N'karahan2@gmail.com', CAST(N'2000-01-01T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (4002, N'Hasan', N'Fil', CAST(N'2000-02-18T00:00:00.000' AS DateTime), N'05554447898', N'hasan@mail.com', CAST(N'2025-05-07T11:22:49.487' AS DateTime), 1, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (4003, N'Seray', N'Yýldýz', CAST(N'2025-05-02T00:00:00.000' AS DateTime), N'05554447898', N'seray@gmail.com', CAST(N'2025-05-07T11:23:09.110' AS DateTime), 2, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (4004, N'Ayþe', N'Turan', CAST(N'2025-05-05T00:00:00.000' AS DateTime), N'05555444444', N'ayse@gmail.com', CAST(N'2025-05-07T11:24:12.617' AS DateTime), 2, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (12, N'Semih ', N'Tanýþ', CAST(N'2025-05-04T00:00:00.000' AS DateTime), N'05555444444', N'semih@gmail.com', CAST(N'2025-05-06T16:04:35.977' AS DateTime), 1, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (4005, N'Fatih', N'Akçay', CAST(N'2025-05-09T00:00:00.000' AS DateTime), N'05555444444', N'fatih@gmail.com', CAST(N'2025-05-07T11:24:55.427' AS DateTime), 1, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (1002, N'karahan2', N'aslan', CAST(N'2025-05-04T00:00:00.000' AS DateTime), N'05555444444', N'asdsadasd@mail.com', CAST(N'2025-05-06T22:43:56.047' AS DateTime), 1, 1)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (1003, N'deneme', N'deneme', CAST(N'2025-05-07T00:00:00.000' AS DateTime), N'05554447898', N'asjdsdga@gmail.com', CAST(N'2025-05-06T22:59:28.517' AS DateTime), 1, 0)
INSERT [dbo].[Musteriler] ([Id], [FirstName], [LastName], [BirthDate], [PhoneNumber], [Email], [CreatedTime], [Gender], [IsDeleted]) VALUES (2003, N'karahan', N'türker', CAST(N'2025-05-01T00:00:00.000' AS DateTime), N'05555444444', N'karahan@mail.com', CAST(N'2025-05-07T09:39:30.953' AS DateTime), 1, 1)

SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO