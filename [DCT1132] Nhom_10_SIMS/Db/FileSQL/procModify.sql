--Tao proc SP_modifyquantity--
create procedure SP_modifyquantity
@iditem nvarchar(50),
@quantity int
as
begin
	update item set quantity=@quantity where iditem=@iditem
end