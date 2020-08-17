CREATE TABLE [dbo].[Error](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[ErrorDate] [datetime] NULL,
	[IpAddress] [nvarchar](40) NULL,
	[UserAgent] [nvarchar](max) NULL,
	[Exception] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[Everything] [nvarchar](max) NULL,
	[HttpReferer] [nvarchar](500) NULL,
	[PathAndQuery] [nvarchar](500) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_ERROR] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Error] ADD  DEFAULT (getdate()) FOR [ErrorDate]
GO
ALTER TABLE [dbo].[Error] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Error] ADD  DEFAULT (getdate()) FOR [ChangedOn]