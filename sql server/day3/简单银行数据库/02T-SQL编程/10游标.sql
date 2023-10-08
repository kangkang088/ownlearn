create table Member
(
	MemberId int primary key identity(1,1),
	MemberAccount nvarchar(20) unique check(len(MemberAccount) between 6 and 12),
	MemberPwd nvarchar(20),
	MemberNickName nvarchar(20),
	MemberPhone nvarchar(20)
)
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('liubei','123456','����','4659874564')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('guanyu','123456','����','42354234124')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('zhangfei','123456','�ŷ�','41253445')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('zhaoyun','123456','����','75675676547')
insert into Member(MemberAccount,MemberPwd,MemberNickName,MemberPhone)
values('machao','123456','��','532523523')

select* from Member

--1.�����α�(scroll-�����α�,û��scroll���α���ֻ���ģ�ֻ������һ���ƶ���)
declare myCur cursor scroll 
for select MemberAccount from Member --����һ���α꣬��myCur�����ǹ����α꣬���Ǵ����ڱ�Member����ģ���Member���MemberAccount�ֶ��Ͻ����ƶ�
--2.�α��
open myCur

--3.ʹ���α�
--��ȡĳ�е�����
fetch first from myCur --��ȡ��һ��
fetch last from myCur --��ȡ���һ��
fetch absolute 2 from myCur --��ȡ�ڶ���(���Եڶ��У�����ֵΪ2����)
fetch relative 2 from myCur --��ȡ�ڶ��У���Եڶ��У���ǰ�����ƶ��У�
fetch next from myCur --����һ��
fetch prior from myCur --����һ��

--��ȡ�α����ݣ�������������в�ѯ��������Ϣ
declare @acc varchar(20)
fetch absolute 2 from myCur into @acc
select* from Member where MemberAccount = @acc
go

--�����α�
declare @acc varchar(20)
fetch absolute 1 from myCur into @acc
--@@fetch_status:0 ��ȡ�ɹ�  -1:��ȡʧ��, -2��ȡ���ݲ�����
while @@FETCH_STATUS = 0
	begin
	print '��ȡ�ɹ�' + @acc
	fetch next from myCur into @acc
	end

--�����α�������ݵ��޸ĺ�ɾ��
select* from Member
fetch absolute 2 from myCur
update Member set MemberPwd = '654321' where current of myCur --�޸ĵ�ǰ�α������е�����

fetch absolute 2 from myCur
delete from Member where current of myCur --ɾ����ǰ�α�������



--4.�α�رգ������ٴ򿪣�
close myCur
--5.ɾ���α꣨�޷��ٴ򿪣�
deallocate myCur

go

select* from Member
--����ָ��ĳ�ж��е��α꣬����ѭ����ʾ��������
declare myCur cursor scroll 
for select MemberAccount,MemberPwd,MemberNickName from Member

open myCur

declare @acc varchar(20)
declare @pwd varchar(20)
declare @nickName varchar(20)
fetch absolute 1 from myCur into @acc,@pwd,@nickName
--@@fetch_status:0 ��ȡ�ɹ�  -1:��ȡʧ��, -2��ȡ���ݲ�����
while @@FETCH_STATUS = 0
	begin
	print '�û�����'+ @acc +'���룺' +  @pwd +'�ǳƣ�' + @nickName
	fetch next from myCur into @acc,@pwd,@nickName
	end



close myCur
deallocate myCur