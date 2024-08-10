USE [Office_Automation_Daily_Activity_Tracker]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 10/08/2024 09:02:23 ã ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[e_id] [int] NOT NULL,
	[e_name_ar] [nvarchar](100) NULL,
	[e_name_en] [varchar](100) NULL,
	[job_id] [int] NULL,
	[email] [varchar](100) NULL,
	[sec_insert_uid] [int] NULL,
	[sec_update_uid] [int] NULL,
	[sec_insert_date] [datetime] NULL,
	[sec_update_date] [datetime] NULL,
 CONSTRAINT [PK__Users__B9BE370FF62B0BEF] PRIMARY KEY CLUSTERED 
(
	[e_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK__Users__job_id__286302EC] FOREIGN KEY([job_id])
REFERENCES [dbo].[Jobs] ([job_id])
GO

ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK__Users__job_id__286302EC]
GO


