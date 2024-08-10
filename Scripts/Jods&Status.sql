USE [Office_Automation_Daily_Activity_Tracker]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 10/08/2024 09:04:51 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[job_id] [int] NOT NULL,
	[job_name_ar] [nvarchar](100) NULL,
	[job_name_en] [varchar](100) NULL,
	[sec_insert_uid] [int] NULL,
	[sec_update_uid] [int] NULL,
	[sec_insert_date] [datetime] NULL,
	[sec_update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 10/08/2024 09:04:51 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[status_id] [int] NOT NULL,
	[status_name] [varchar](100) NULL,
	[sec_insert_uid] [int] NULL,
	[sec_update_uid] [int] NULL,
	[sec_insert_date] [datetime] NULL,
	[sec_update_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (1, N'مدير', N'Admin', 1, NULL, CAST(N'2024-07-31T12:22:31.710' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (2, N'مدير مالي', N'Finance Manager', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (3, N'مطور برمجيات', N'Software Developer', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (4, N'مهندس نظم', N'Systems Engineer', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (5, N'محلل أعمال', N'Business Analyst', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (6, N'مسؤول الموارد البشرية', N'HR Officer', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (7, N'مدير تسويق', N'Marketing Manager', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (8, N'محاسب', N'Accountant', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (9, N'مدير مشروع', N'Project Manager', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Jobs] ([job_id], [job_name_ar], [job_name_en], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (10, N'مهندس شبكات', N'Network Engineer', 1, NULL, CAST(N'2024-07-31T12:06:43.500' AS DateTime), NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (1, N'Complete', 1, NULL, CAST(N'2024-07-31T12:29:50.813' AS DateTime), NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (2, N'InProgress', 1, NULL, CAST(N'2024-07-31T12:29:50.813' AS DateTime), NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (3, N'NotStated', 1, NULL, CAST(N'2024-07-31T12:29:50.813' AS DateTime), NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (4, N'Review', 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (5, N'NeedChanges', 1, NULL, NULL, NULL)
GO
INSERT [dbo].[Status] ([status_id], [status_name], [sec_insert_uid], [sec_update_uid], [sec_insert_date], [sec_update_date]) VALUES (6, N'PendingReview', 1, NULL, NULL, NULL)
GO
