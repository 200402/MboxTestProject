DROP TABLE IF EXISTS [dbo].[Product]
DROP TABLE IF EXISTS [dbo].[Category]
DROP TABLE IF EXISTS [dbo].[ProductCategory]

CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Product_name] NCHAR(10) NULL
)

CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Category_name] NCHAR(10) NULL
)

CREATE TABLE [dbo].[ProductCategory]
(
	[ProductId] INT FOREIGN KEY REFERENCES dbo.Product(Id),
	[CategoryId] INT FOREIGN KEY REFERENCES dbo.Category(Id),
	PRIMARY KEY(ProductId, CategoryId)
)

insert into dbo.Product values(1, 'p1')
insert into dbo.Product values(2, 'p2')
insert into dbo.Product values(3, 'p1')

insert into dbo.Category values(1, 'c1')
insert into dbo.Category values(2, 'c2')
insert into dbo.Category values(3, 'c1')

insert into dbo.ProductCategory values(1, 1)
insert into dbo.ProductCategory values(2, 2)
insert into dbo.ProductCategory values(3, 1)
insert into dbo.ProductCategory values(3, 2)
insert into dbo.ProductCategory values(3, 3)