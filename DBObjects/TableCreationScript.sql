USE [EmployeeManagement]
GO

/****** Object:  Table [dbo].[Contacts]    Script Date: 7/11/2018 2:32:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Phone] [char](20) NULL,
	[Email] [varchar](50) NOT NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Contacts] ADD  CONSTRAINT [DF_Contacts_Status]  DEFAULT ((1)) FOR [Status]
GO


