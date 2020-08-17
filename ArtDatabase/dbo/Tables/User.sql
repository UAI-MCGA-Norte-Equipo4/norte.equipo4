CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[City] [nvarchar](30) NULL,
	[Country] [nvarchar](30) NULL,
	[SignupDate] [datetime] NOT NULL,
	[OrderCount] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [SignupDate]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((0)) FOR [OrderCount]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT (getdate()) FOR [ChangedOn]