---------------------存储过程-----------------
use DBONET
go
--(1)查询所有数据
create proc proc_SelectMember
as
	select* from Member
go

exec proc_SelectMember
GO
--(2)新增会员
create proc proc_InsertMember
@ACC varchar(20),
@PWD varchar(20),
@MMNAME varchar(20),
@MMPHONE varchar(20)
as
	insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
	values(@ACC,@PWD,@MMNAME,@MMPHONE)
go
exec proc_InsertMember 'sunwukong','123456','孙悟空','1388888888'
select* from Member
go
--(3)根据账户求姓名和电话
create proc proc_GetInfoBYAcc
	@ACC varchar(20),
	@MEMNAME varchar(20) OUTPUT,
	@MEMPHONE varchar(20) OUTPUT
as
	select @MEMNAME = (select MemberName from Member where MemberAccount = @ACC)
	select @MEMPHONE = (select MemberPhone from Member where MemberAccount = @ACC)
go
declare @name varchar(20)
declare @phone varchar(20)
exec proc_GetInfoBYAcc 'zhangfei',@name output,@phone output
select @name,@phone
go
--(4)密码升级，传入用户名和密码，如果用户名和密码正确，密码小于九位则升级为九位
create proc proc_PwdUpdate
	@acc varchar(20),
	@pwd varchar(20) output
as
	if not exists(select* from Member where MemberAccount = @acc and @pwd = MemberPwd)
	begin
		set @pwd = ''
	end
	else
	begin
		if LEN(@pwd) < 9
		begin
			declare @count int = 9 - len(@pwd)
			declare @i int = 1
			while @i <= @count
			begin
				set @pwd = @pwd + cast(floor(rand()*10) as varchar(1))
				set @i = @i + 1
			end
			update Member set MemberPwd = @pwd where MemberAccount = @acc
		end
	end
go

declare @pwdout varchar(20) = '12345634'
exec proc_PwdUpdate 'liubei',@pwdout output
select* from Member
go
--(5)实现数据的新增，并返回执行的状态值
create proc proc_NewInsertMember
	@acc varchar(20),
	@pwd varchar(20),
	@name varchar(20),
	@phone varchar(20)
as
	insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone) values(@acc,@pwd,@name,@phone)
	declare @state int = @@error
	if @state = 0
	return 1
	else if @state = 2627 --违反unique约束
	return -1
	else
	return -100
go
declare @state int
exec @state = proc_NewInsertMember 'caocao','123456','曹操','13845698745'
print @state
