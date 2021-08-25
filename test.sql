
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 

CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 

CREATE TABLE [dbo].[ProductCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 


SELECT 
	dbo.Products.Name as Product,
	dbo.Category.Name as Category
FROM dbo.Products

LEFT JOIN dbo.ProductCategory ON dbo.Products.Id = dbo.ProductCategory.ProductId
LEFT JOIN dbo.Category ON dbo.Category.Id = dbo.ProductCategory.CategoryId