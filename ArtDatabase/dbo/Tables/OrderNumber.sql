CREATE TABLE [dbo].[OrderNumber](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_ORDERNUMBER] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderNumber] ADD  DEFAULT ((203317)) FOR [Number]
GO
ALTER TABLE [dbo].[OrderNumber] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[OrderNumber] ADD  DEFAULT (getdate()) FOR [ChangedOn]