USE [Office_Automation_Daily_Activity_Tracker]
GO

/****** Object:  Table [dbo].[users]    Script Date: 10/08/2024 09:03:04 ã ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[e_id] [int] NOT NULL,
	[isadmin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[users]  WITH CHECK ADD FOREIGN KEY([e_id])
REFERENCES [dbo].[Employees] ([e_id])
GO


