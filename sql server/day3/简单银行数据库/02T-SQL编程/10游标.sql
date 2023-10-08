create table Member
(
	MemberId int primary key identity(1,1),
	MemberAccount nvarchar(20) unique check(len(MemberAccount) between 6 and 12),
	MemberPwd nvarchar(20),
	MemberNickName nvarchar(20),
	MemberPhone nvarchar(20)
)
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('liubei','123456','刘备','4659874564')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('guanyu','123456','关羽','42354234124')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('zhangfei','123456','张飞','41253445')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('zhaoyun','123456','赵云','75675676547')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('machao','123456','马超','532523523')

select* from Member

--1.创建游标(scroll-滚动游标,没有scroll，游标是只进的（只能向下一行移动）)
declare myCur cursor scroll 
for select MemberAccount from Member --创建一个游标，叫myCur，它是滚动游标，它是创建在表Member里面的，在Member表的MemberAccount字段上进行移动
--2.游标打开
open myCur

--3.使用游标
--提取某行的数据
fetch first from myCur --提取第一行
fetch last from myCur --提取最后一行
fetch absolute 2 from myCur --提取第二行(绝对第二行，绝对值为2的行)
fetch relative 2 from myCur --提取第二行（相对第二行，当前行下移二行）
fetch next from myCur --下移一行
fetch prior from myCur --上移一行

--提取游标数据，存入变量，进行查询所有列信息
declare @acc varchar(20)
fetch absolute 2 from myCur into @acc
select* from Member where MemberAccount = @acc
go

--遍历游标
declare @acc varchar(20)
fetch absolute 1 from myCur into @acc
--@@fetch_status:0 提取成功  -1:提取失败, -2提取内容不存在
while @@FETCH_STATUS = 0
	begin
	print '提取成功' + @acc
	fetch next from myCur into @acc
	end

--利用游标进行数据的修改和删除
select* from Member
fetch absolute 2 from myCur
update Member set MemberPwd = '654321' where current of myCur --修改当前游标所在行的密码

fetch absolute 2 from myCur
delete from Member where current of myCur --删除当前游标所在行



--4.游标关闭（可以再打开）
close myCur
--5.删除游标（无法再打开）
deallocate myCur

go

select* from Member
--创建指向某行多列的游标，并且循环显示多列数据
declare myCur cursor scroll 
for select MemberAccount,MemberPwd,MemberNickName from Member

open myCur

declare @acc varchar(20)
declare @pwd varchar(20)
declare @nickName varchar(20)
fetch absolute 1 from myCur into @acc,@pwd,@nickName
--@@fetch_status:0 提取成功  -1:提取失败, -2提取内容不存在
while @@FETCH_STATUS = 0
	begin
	print '用户名：'+ @acc +'密码：' +  @pwd +'昵称：' + @nickName
	fetch next from myCur into @acc,@pwd,@nickName
	end



close myCur
deallocate myCur