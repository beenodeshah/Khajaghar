Create table billTable
(
billId int identity(1,1) primary key,
KOTId int foreign key references KOTTable(KOTId),
transactionType varchar(100),
grandTotal numeric(18,2),
discount numeric(18,2)
)

alter procedure sp_managebills
(
@billId int,
@KOTId int,
@transactionType varchar(200),
@grandTotal numeric(18,2),
@discount numeric(18,2),
@mode int
)
as
begin
if(@mode=1)
insert into billTable(KOTId,transactionType,grandTotal,discount) values (@KOTId,@transactionType,@grandTotal,@discount)
if(@mode=2)
update billTable set KOTId=@KOTId,transactionType=@transactionType,grandTotal=@grandTotal,discount=@discount
where billId=@billId
if(@mode=3)
delete from billTable where billId=@billId
end


Create table transactionTable
(
transactionId int identity(1,1) primary key,
accountNumber varchar(200),
transactionType varchar(30),
amount numeric(18,2),
remarks varchar(200)
)

create procedure sp_manageTransactions
(
@transactionId int,
@accountNumber varchar(200),
@transactionType varchar(30),
@amount numeric(18,2),
@remarks varchar(200),
@mode int
)
as
begin
if(@mode=1)
insert into transactionTable(accountNumber,transactionType,amount,remarks) 
values (@accountNumber,@transactionType,@amount,@remarks)
if(@mode=2)
update transactionTable set accountNumber=@accountNumber,
transactionType=@transactionType,
amount=@amount,
remarks=@remarks where transactionId=@transactionId
if(@mode=3)
delete from transactionTable where transactionId=@transactionId
end


