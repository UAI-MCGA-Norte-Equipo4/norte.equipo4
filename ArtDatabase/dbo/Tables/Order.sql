CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[ItemCount] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_REFERENCE_USER] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_ORDER_REFERENCE_USER]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((0)) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((0)) FOR [OrderNumber]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((0)) FOR [ItemCount]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT (getdate()) FOR [ChangedOn]