--Tao proc SP_verifyuser--
create procedure SP_verifyuser
@iduser nvarchar(50),
@result tinyint output
as
begin
	if(exists (select*from useraccount where iduser=@iduser and status=0))
	begin
		set @result=1
	end
	else
	begin
		set @result=0
	end
end

--Tao proc Sp_verifyitem--
create procedure SP_verifyitem
@iditem nvarchar(50)
as
begin
	select*from item where iditem=@iditem
end

--Tao proc SP_verifylogin--
create procedure SP_verifylogin
@iduser nvarchar(50)
as
begin
	select*from useraccount where iduser=@iduser
end

--Tao proc SP_changepassword--
create procedure SP_changepassword
@iduser nvarchar(50),
@newpassword nvarchar(50)
as
begin
	update useraccount set password=@newpassword where iduser=@iduser
end