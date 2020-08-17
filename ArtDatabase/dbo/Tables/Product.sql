CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[ArtistId] [int] NOT NULL,
	[Image] [nvarchar](30) NOT NULL,
	[Price] [float] NOT NULL,
	[QuantitySold] [int] NOT NULL,
	[AvgStars] [float] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_REFERENCE_ARTIST] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artist] ([Id])
GO

ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_PRODUCT_REFERENCE_ARTIST]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [QuantitySold]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [AvgStars]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [ChangedOn]