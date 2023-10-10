---------------------存储过程-----------------
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