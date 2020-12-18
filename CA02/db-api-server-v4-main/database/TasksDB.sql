/****** Object:  Table [dbo].[Status]    Script Date: 17/12/2020 23:21:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
    [StatusId] [int] IDENTITY(1,1) NOT NULL,
    [StatusName] [nvarchar](255) NOT NULL,
    [StatusDescription] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
    [StatusId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Task]    Script Date: 17/12/2020 23:21:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
    [TaskId] [int] IDENTITY(1,1) NOT NULL,
    [StatusId] [int] NULL,
    [TaskDescription] [nvarchar](255) NULL,
    [TaskPriority] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [TaskId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusDescription]) VALUES (1, N'Waiting', N'Tasks waiting to be executed')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusDescription]) VALUES (2, N'In Progress', N'Tasks in Progress')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusDescription]) VALUES (3, N'Closed', N'Tasks already closed')
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Task] ON 
GO
INSERT [dbo].[Task] ([TaskId], [StatusId], [TaskDescription], [TaskPriority]) VALUES (1, 1, N'Exemple of task in the Waiting list', 1)
GO
INSERT [dbo].[Task] ([TaskId], [StatusId], [TaskDescription], [TaskPriority])  VALUES (2, 2, N'Exemple of task in the In Progress list', 1)
GO
INSERT [dbo].[Task] ([TaskId], [StatusId], [TaskDescription], [TaskPriority])  VALUES (3, 3, N'Exemple of task in the Closed list', 1)
GO
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
ALTER TABLE [dbo].[Task] ADD  DEFAULT ((1)) FOR [TaskPriority]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
