USE [MyMVC_DB]
GO
CREATE USER [AdminMVC] FOR LOGIN [AdminMVC] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [AdminMVC]
GO
ALTER ROLE [db_datareader] ADD MEMBER [AdminMVC]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Quantity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [Name], [Quantity]) VALUES (1, N'Silla', N'6')
INSERT [dbo].[Product] ([id], [Name], [Quantity]) VALUES (2, N'Mesa', N'1')
INSERT [dbo].[Product] ([id], [Name], [Quantity]) VALUES (4, N'Lápiz', N'1000')
SET IDENTITY_INSERT [dbo].[Product] OFF
