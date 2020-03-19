create table Article
(
ID int primary key,
Name nvarchar(50)
)

create table Location
(
ID int primary key,
Location nvarchar(50)
)

create table StockItem
(
ID int primary key,
Aid int foreign key references Article(ID),
Lid int foreign key references Location(ID),
Amount int
)