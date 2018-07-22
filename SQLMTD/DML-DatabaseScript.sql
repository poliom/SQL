USE [SQLMTD]
GO
/****** Object:  Table [dbo].[Manifactures]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (1, N'Volkswagen')
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (2, N'Audi')
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (3, N'BMW')
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (4, N'Peugeot')
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (5, N'Toyota')
INSERT [dbo].[Manifactures] ([Id], [Name]) VALUES (6, N'Dodge')
SET IDENTITY_INSERT [dbo].[Manifactures] OFF
/****** Object:  Table [dbo].[Cities]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Cities] ([Id], [Name], [RegistrationCode]) VALUES (1, N'Сифия', N'СА')
INSERT [dbo].[Cities] ([Id], [Name], [RegistrationCode]) VALUES (2, N'Пловдив', N'РВ')
INSERT [dbo].[Cities] ([Id], [Name], [RegistrationCode]) VALUES (3, N'Варна', N'В')
INSERT [dbo].[Cities] ([Id], [Name], [RegistrationCode]) VALUES (4, N'Бургас', N'А')
INSERT [dbo].[Cities] ([Id], [Name], [RegistrationCode]) VALUES (5, N'Кърджали', N'К')
SET IDENTITY_INSERT [dbo].[Cities] OFF
/****** Object:  Table [dbo].[VehicleType]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[VehicleType] ([Id], [Name]) VALUES (1, N'PassangersCar')
SET IDENTITY_INSERT [dbo].[VehicleType] OFF
/****** Object:  Table [dbo].[UserStatus]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[UserStatus] ([Id], [Name]) VALUES (1, N'Activ')
INSERT [dbo].[UserStatus] ([Id], [Name]) VALUES (2, N'Blocked')
INSERT [dbo].[UserStatus] ([Id], [Name]) VALUES (3, N'Deleted')
SET IDENTITY_INSERT [dbo].[UserStatus] OFF
/****** Object:  Table [dbo].[Roles]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Official')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Director')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (3, N'Minister')
SET IDENTITY_INSERT [dbo].[Roles] OFF
/****** Object:  Table [dbo].[Models]    Script Date: 05/22/2014 14:32:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (1, 1, N'Passat')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (2, 1, N'Golf')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (3, 1, N'Jetta')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (4, 1, N'Polo')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (5, 1, N'Touran')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (6, 1, N'Touareg')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (7, 1, N'Tiguan')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (8, 1, N'Sharan')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (9, 2, N'A3')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (10, 2, N'A4')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (11, 2, N'A6')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (12, 2, N'A5')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (13, 2, N'A7')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (14, 2, N'A8')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (15, 2, N'Q7')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (16, 2, N'Q5')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (17, 2, N'Q3')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (18, 3, N'1 series')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (19, 3, N'3 series')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (20, 3, N'5 series')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (21, 3, N'6 series')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (22, 3, N'7 series')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (23, 3, N'X5')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (24, 3, N'X6')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (25, 4, N'307')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (26, 4, N'308')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (27, 4, N'309')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (28, 4, N'407')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (29, 4, N'406')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (30, 5, N'Avensis')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (31, 5, N'Corolla')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (32, 5, N'Auris')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (33, 5, N'Yaris')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (34, 5, N'Land Cruiser')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (35, 5, N'RAV 4')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (36, 6, N'Charger')
INSERT [dbo].[Models] ([Id], [ManifactureId], [Model]) VALUES (37, 6, N'Challanger')
SET IDENTITY_INSERT [dbo].[Models] OFF
/****** Object:  ForeignKey [FK_Models_Manifactures]    Script Date: 05/22/2014 14:32:02 ******/
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_Models_Manifactures] FOREIGN KEY([ManifactureId])
REFERENCES [dbo].[Manifactures] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_Models_Manifactures]
GO
