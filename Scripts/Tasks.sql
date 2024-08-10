USE [Office_Automation_Daily_Activity_Tracker]
GO

/****** Object:  Table [dbo].[Tasks]    Script Date: 10/08/2024 09:02:55 ã ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks](
	[task_id] [int] IDENTITY(1,1) NOT NULL,
	[task_start_date] [datetime] NULL,
	[task_end_date] [datetime] NULL,
	[task_description] [nvarchar](500) NULL,
	[task_name] [nvarchar](100) NULL,
	[status_id] [int] NULL,
	[user_id] [int] NULL,
	[sec_insert_uid] [int] NULL,
	[sec_update_uid] [int] NULL,
	[sec_insert_date] [datetime] NULL,
	[sec_update_date] [datetime] NULL,
 CONSTRAINT [PK__Tasks__0492148D054D133D] PRIMARY KEY CLUSTERED 
(
	[task_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK__Tasks__status_id__2B3F6F97] FOREIGN KEY([status_id])
REFERENCES [dbo].[Status] ([status_id])
GO

ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK__Tasks__status_id__2B3F6F97]
GO

ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [FK__Tasks__user_id__2C3393D0] FOREIGN KEY([user_id])
REFERENCES [dbo].[Employees] ([e_id])
GO

ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [FK__Tasks__user_id__2C3393D0]
GO


