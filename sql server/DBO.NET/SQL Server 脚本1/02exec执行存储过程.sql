---------------------�洢����-----------------
--(1)��ѯ��������
create proc proc_SelectMember
as
	select* from Member
go

exec proc_SelectMember
GO
--(2)������Ա
create proc proc_InsertMember
@ACC varchar(20),
@PWD varchar(20),
@MMNAME varchar(20),
@MMPHONE varchar(20)
as
	insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
	values(@ACC,@PWD,@MMNAME,@MMPHONE)
go
exec proc_InsertMember 'sunwukong','123456','�����','1388888888'
select* from Member
go
--(3)�����˻��������͵绰
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