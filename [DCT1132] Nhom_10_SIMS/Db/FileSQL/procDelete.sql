--Tao proc SP_cancelreceipt--
create procedure SP_cancelreceipt
@idreceipt nvarchar(50)
as
begin
	update receipt set status = 0 where idreceipt=@idreceipt
	update receiptdetail set status = 0 where idreceipt=@idreceipt
end

--Tao proc SP_confirmmail--
create procedure SP_confirmmail
@idmail nvarchar(50)
as
begin
	update mail set status = N'Đã đọc' where idmail=@idmail
end

--Tao proc SP_deletemail--
create procedure SP_deletemail
@idmail nvarchar(50)
as
begin
	update mail set status = N'Đã xoá' where idmail=@idmail
end