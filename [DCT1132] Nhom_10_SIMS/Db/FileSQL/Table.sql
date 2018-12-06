
create database DesignSIMS
go
use DesignSIMS
go
--Tao bang useraccount--
create table useraccount
(
	iduser nvarchar(50) PRIMARY KEY,
	password nvarchar(50) not null,
	username nvarchar(50) not null,
	idrole int not null,
	status tinyint not null default '0'
)
alter table useraccount
drop column no  
--Tao bang role--
create table role
(
	idrole int not null PRIMARY KEY,
	rolename nvarchar(50) not null
)
--Tao bang category--
create table category
(
	idcategory nvarchar(50) not null primary key,
	namecategory nvarchar(50)
)

--Tao bang item--
create table item
(
	iditem nvarchar(50) not null primary key,
	idcategory nvarchar(50),
	nameitem nvarchar(50),
	quantity int,
	importprice float,
	exportprice float,
	constraint FK_idcategory foreign key (idcategory) references category(idcategory)
)
)
--Tao bang receipt--
create table receipt
(
	idreceipt nvarchar(50) primary key,
	iduser nvarchar(100),
	date datetime,
	idtype int,
	total float,
	status int,
)
--Tao bang receiptdateil--
create table receiptdetail
(
	idreceipt nvarchar(50),
	idreceiptdetail nvarchar(60),
	iditem nvarchar(50),
	quantity int,
	subtotal float,
	status int
) select*from receiptdetail
--Tao bang receipttype-- 
create table receipttype
(
	idtype int primary key,
	nametype nvarchar(50)
)
--Tao bang mail--
create table mail
(
	idmail nvarchar(50) primary key,
	sender nvarchar(50),
	receiver nvarchar(50),
	subject nvarchar(50),
	content nvarchar(1000),
	status nvarchar(50)
)