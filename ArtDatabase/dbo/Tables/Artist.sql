CREATE TABLE [dbo].[Artist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[LifeSpan] [nvarchar](30) NULL,
	[Country] [nvarchar](30) NULL,
	[Description] [nvarchar](2000) NULL,
	[TotalProducts] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ChangedOn] [datetime] NOT NULL,
	[ChangedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_ARTIST] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Artist] ADD  CONSTRAINT [DF__Artist__TotalPro__108B795B]  DEFAULT ((0)) FOR [TotalProducts]
GO
ALTER TABLE [dbo].[Artist] ADD  CONSTRAINT [DF__Artist__CreatedO__117F9D94]  DEFAULT (getdate()) FOR [CreatedOn]
GO
ALTER TABLE [dbo].[Artist] ADD  CONSTRAINT [DF__Artist__ChangedO__1273C1CD]  DEFAULT (getdate()) FOR [ChangedOn]