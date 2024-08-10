USE [Office_Automation_Daily_Activity_Tracker]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 10/08/2024 09:02:34 ã ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[message_id] [int] IDENTITY(1,1) NOT NULL,
	[sender_id] [int] NOT NULL,
	[receiver_id] [int] NOT NULL,
	[message_text] [nvarchar](max) NOT NULL,
	[timestamp] [datetime] NULL,
	[is_read] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[message_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Messages] ADD  DEFAULT (getdate()) FOR [timestamp]
GO

ALTER TABLE [dbo].[Messages] ADD  DEFAULT ((0)) FOR [is_read]
GO

ALTER TABLE [dbo].[Messages]  WITH CHECK ADD FOREIGN KEY([receiver_id])
REFERENCES [dbo].[users] ([user_id])
GO

ALTER TABLE [dbo].[Messages]  WITH CHECK ADD FOREIGN KEY([sender_id])
REFERENCES [dbo].[users] ([user_id])
GO


