USE [Office_Automation_Daily_Activity_Tracker]
GO

/****** Object:  Table [dbo].[TaskHistory]    Script Date: 10/08/2024 09:02:45 ã ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaskHistory](
	[history_id] [int] IDENTITY(1,1) NOT NULL,
	[task_id] [int] NULL,
	[status_id] [int] NULL,
	[sec_insert_uid] [int] NULL,
	[sec_update_uid] [int] NULL,
	[sec_insert_date] [datetime] NULL,
	[sec_update_date] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TaskHistory]  WITH CHECK ADD FOREIGN KEY([status_id])
REFERENCES [dbo].[Status] ([status_id])
GO

ALTER TABLE [dbo].[TaskHistory]  WITH CHECK ADD FOREIGN KEY([task_id])
REFERENCES [dbo].[Tasks] ([task_id])
GO


