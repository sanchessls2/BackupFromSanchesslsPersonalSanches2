SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
    [UserId] [int] IDENTITY(1,1) NOT NULL,
    [FirstName] [nvarchar](255) NULL,
    [LastName] [nvarchar](255) NULL,
    [Email] [nvarchar](255) NOT NULL,
    [Password] [nvarchar](255) NOT NULL,
    [Role] [nvarchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [UserId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Category]    Script Date: 19/09/2019 09:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
    [CategoryId] [int] IDENTITY(1,1) NOT NULL,
    [CategoryName] [nvarchar](255) NOT NULL,
    [CategoryDescription] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
    [CategoryId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 19/09/2019 09:51:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
    [ProductId] [int] IDENTITY(1,1) NOT NULL,
    [CategoryId] [int] NULL,
    [ProductName] [nvarchar](255) NOT NULL,
    [ProductDescription] [nvarchar](255) NULL,
    [ProductStock] [int] NOT NULL,
    [ProductPrice] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [ProductId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AppUser] ON 
GO
INSERT [dbo].[AppUser] ([UserId], [FirstName], [LastName], [Email], [Password], [Role]) VALUES (1, N'Nathalia', N'Admin', N'nathalia@web.com', N'password', N'admin')
GO
INSERT [dbo].[AppUser] ([UserId], [FirstName], [LastName], [Email], [Password], [Role]) VALUES (2, N'Thais', N'Manager', N'thais@web.com', N'password', N'manager')
GO
INSERT [dbo].[AppUser] ([UserId], [FirstName], [LastName], [Email], [Password], [Role]) VALUES (3, N'Carol', N'User', N'carol@web.com', N'password', N'user')
GO
SET IDENTITY_INSERT [dbo].[AppUser] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription]) VALUES (1, N'Clothing', N'Tops, Dresses, Coats, Jackets, Joggers, Trousers, Denim, Shirts and Skirts')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription]) VALUES (2, N'Shoes', N'Boots, Trainers, Flats, Sandals and High heels')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription]) VALUES (3, N'Acessories', N'Bags, Earrings, Belts, Tights, Socks, Hair and Sunglasses')
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [CategoryDescription]) VALUES (4, N'Beauty', N'Face, Eyes, Brows, Lips, Tools, Glitter and Gems')
GO

SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (1, 1, N'Dress', N'Stone Ruched Front T Shirt Dress', 100, CAST(55.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (2, 1, N'Jacket', N'Black Cropped Faux Fur Coat', 45, CAST(79.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (3, 2, N'Trainers', N'Ecru Arch Sole Chunky Trainers', 5, CAST(80.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (4, 2, N'Heels', N'Nude Metal Heeled Boots', 45, CAST(65.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (5, 3, N'Earrings', N'Silver Diamantes Drop Earrings', 5, CAST(15.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (6, 3, N'Belts', N'Gold Butterfly Chain Belt', 12, CAST(20.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (7, 4, N'Lipstick', N'Velvet Lip Paint Angel Kiss', 50, CAST(10.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [ProductDescription], [ProductStock], [ProductPrice]) VALUES (8, 4, N'Bronzer', N'Natural Bronzer Sun Bronze', 5, CAST(16.00 AS Decimal(10, 2)))
GO

SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [ProductStock]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0.00)) FOR [ProductPrice]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
