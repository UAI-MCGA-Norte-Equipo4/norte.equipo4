CREATE TABLE [dbo].[CartItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CartId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_CARTITEM] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CartItem]  WITH CHECK ADD  CONSTRAINT [FK_CARTITEM_REFERENCE_CART] FOREIGN KEY([CartId])
REFERENCES [dbo].[Cart] ([Id])
GO

ALTER TABLE [dbo].[CartItem] CHECK CONSTRAINT [FK_CARTITEM_REFERENCE_CART]
GO
ALTER TABLE [dbo].[CartItem] ADD  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[CartItem] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[CartItem] ADD  DEFAULT (getdate()) FOR [ChangedOn]