--Tao proc SP_loaduser--
create procedure SP_loaduser
as
begin
	select iduser,username,useraccount.idrole,role.rolename from useraccount,role where useraccount.idrole=role.idrole and status=0 and useraccount.idrole!=4
end

--create proc SP_loaditem--
create procedure SP_loaditem
@nameitem nvarchar(50),
@idcategory nvarchar(50)
as
begin
	if(@idcategory='0')
	begin
		select iditem,nameitem,namecategory,quantity,importprice,exportprice from item,category where item.idcategory=category.idcategory and nameitem like '%'+@nameitem+'%'
	end
	else
	begin
		select iditem,nameitem,namecategory,quantity,importprice,exportprice from item,category where item.idcategory=category.idcategory and nameitem like '%'+@nameitem+'%' and item.idcategory = @idcategory
	end
end

--create proc SP_loadreceipt--
create procedure SP_loadreceipt
as
begin
	select idreceipt,date,nametype,total from receipt,receipttype where receipt.idtype=receipttype.idtype and status=1
end

--Tao proc SP_loadreceipttype--
create procedure SP_loadreceipttype
as
begin
	select*from receipttype
end

--Tao proc SP_loadlistmail--
create procedure SP_loadlistmail
@receiver nvarchar(50)
as
begin
	select idmail,sender,subject,content,status from mail where receiver=@receiver and (status=N'Chưa đọc' or status=N'Đã đọc') 
end

--Tao proc SP_loadcategory--
create procedure SP_loadcategory
as
begin
	select*from category
end
