USE [InternetSalesDB]
GO
/****** Object:  Table [dbo].[InternetSales]    Script Date: 10/19/2023 1:29:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InternetSales](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[BusinessOwner] [nvarchar](max) NULL,
	[BusinessName] [nvarchar](max) NOT NULL,
	[BusinessAddress] [nvarchar](max) NOT NULL,
	[PurchasedInternet] [bit] NOT NULL,
	[PurchasedPhone] [bit] NOT NULL,
	[PurchasedCellService] [bit] NOT NULL,
	[TvService] [bit] NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InternetSales] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[InternetSales] ADD  CONSTRAINT [DF__InternetS__Phone__398D8EEE]  DEFAULT ((0)) FOR [PhoneNumber]
GO
