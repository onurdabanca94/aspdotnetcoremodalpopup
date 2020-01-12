USE [students]
GO

/****** Object:  Table [dbo].[students]    Script Date: 12.01.2020 21:58:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[students](
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](500) NULL,
	[surname] [varchar](500) NULL,
	[tc_no] [varchar](50) NULL,
	[email] [varchar](500) NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
