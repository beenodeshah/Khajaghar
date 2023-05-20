create table userTable
(
userId int identity(1,1) primary key,
userName varchar(100) not null unique,
password varchar(100) not null,
role varchar(100)
)

Create procedure sp_manageusers
(
@userId int,
@userName varchar(100),
@password varchar(100),
@role varchar(100),
@mode int
)
as
begin
if(@mode=1)
insert into userTable(userName,password) values(@username,@password)
if(@mode=2)
update userTable set userName=@userName,password=@password where userId=@userId
if(@mode=3)
delete from userTable where userId=@userId
end

create table categoryTable
(
categoryId int identity(1,1) primary key,
categoryName varchar(100) not null unique,
description varchar(max)
)

create procedure sp_managecategory
(
@categoryId int,
@categoryName varchar(100),
@description varchar(max),
@mode int
)
as
begin
if(@mode=1)
insert into categoryTable(categoryName,description) values(@categoryName,@description)
if(@mode=2)
update categoryTable set categoryName=@categoryName,description=@description 
where categoryId=@categoryId
if(@mode=3)
delete from categoryTable where categoryId=@categoryId
end


create table menuItemTable
(
menuItemId int identity(1,1) primary key,
category int foreign key references categoryTable(categoryId) on update cascade on delete cascade,
itemName varchar(100) not null unique,
rate numeric(18,2) not null,
remarks varchar(max)
)

create procedure sp_managemenuItems
(
@menuItemId int,
@categoryId int,
@itemName varchar(100),
@rate numeric(18,2),
@remarks varchar(max),
@mode int
)
as
begin
if(@mode=1)
insert into menuItemTable(category,itemName,rate,remarks) 
				  values (@categoryId,@itemName,@rate,@remarks)
if(@mode=2)
update menuItemTable set category=@categoryId,itemName=@itemName,rate=@rate,remarks=@remarks
       where menuItemId=@menuItemId
if(@mode=2)
delete from menuItemTable where menuItemId=@menuItemId
end

Create table kotTable
(
KOTId int identity(1,1) primary key,
KOTDate date,
KOTBy varchar(100)
)

Create procedure sp_managekots
(
@KOTId int,
@KOTDate date,
@KOTBy varchar(100),
@Mode int
)
as
begin
if(@Mode=1)
insert into kotTable(KOTDate,KOTBy) values (@KOTDate,@KOTBy)
if(@Mode=2)
update kotTable set KOTDate=@KOTDate,KOTBy=@KOTBy where KOTId=@KOTId
if(@Mode=3)
Delete from KOTTable where KOTId=@KOTId
end

Create table orderTable
(
orderId int identity(1,1) primary key,
KOTId int foreign key references kotTable(KOTId) on update cascade on delete cascade,
menuItemId int foreign key references menuItemTable(menuItemId),
quantity float,
remarks varchar(max)
)

create procedure sp_manageorders
(
@orderId int,
@KOTId int,
@menuItemId int,
@quantity float,
@remarks varchar(max),
@mode int
)
as 
begin
if(@mode=1)
insert into orderTable(KOTId,menuItemId,quantity,remarks) 
values(@KOTId,@menuItemId,@quantity,@remarks)
if(@mode=2)
update orderTable set KOTId=@KOTId,menuItemId=@menuItemId,quantity=@quantity,remarks=@remarks
where orderId=@orderId
if(@mode=3)
delete from orderTable where orderId=@orderId
end