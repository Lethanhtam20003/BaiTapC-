

create database CoffeManagement
go
use CoffeManagement
go
-- foot 
-- Table 
-- FoodCategory
-- Account
-- bill 
-- billInfor

create table TableFood(
id int identity primary key,
name nvarchar(100) default 'null',
status nvarchar(100) default 0 -- trống hoặc có người 
)
go
create table Account(
id int identity primary key not null,
DisplayName Nvarchar(100) not null default 'null', 
UserName Nvarchar(100) not null,
passWord Nvarchar(100) not null,
type int not null default 0 -- 0 addmint 1 staff
)
go 
create table foodCategory(
id int identity primary key,
name nvarchar(100) not null default 'null',
)
go 
create table food(
id int identity primary key,
name nvarchar(100) not null default 'null',
idCategory int not null,
price float not null,
foreign key (idCategory) references  foodCategory(id)
)
go
create table bill(
id int identity primary key,
DateChechIn Date not null,
DateChechOut Date ,
idTable int not null,
status int not null, -- 1 đã thanh toán && 0 chưa thanh toán 

foreign key (idTable) references  TableFood(id)
)
create table billInfo
(
id int identity primary key,
idBill int not null,
idFood int not null,
count int not null default 0


foreign key (idBill) references  bill(id),
foreign key (idFood) references  food(id)

)

-- go 
-- drop database CoffeManagement2;