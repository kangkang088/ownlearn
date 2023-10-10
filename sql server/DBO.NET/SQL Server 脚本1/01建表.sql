create database DBONET
on
(
	name = 'DBONET',
	filename = 'E:\DATA\DBONET.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'DBONET_log',
	filename = 'E:\DATA\DBONET_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use DBONET
create table Member
(
	MemberId int primary key identity(1,1),
	MemberAccount nvarchar(20) unique check(len(MemberAccount) between 6 and 12),
	MemberPwd nvarchar(20),
	MemberName nvarchar(20),
	MemberPhone nvarchar(20)
)
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('liubei','123456','����','4659874564')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('guanyu','123456','����','42354234124')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('zhangfei','123456','�ŷ�','41253445')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('zhaoyun','123456','����','75675676547')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('machao','123456','��','532523523')

SELECT* FROM Member
select COUNT(*) from Member
select* from Member where MemberAccount = '' or '1' = '1' and MemberPwd = '' or '1' = '1'

--רҵ
create table ProfessionInfo
(
	ProfessionID int primary key identity(1,1), --רҵ���
	professionName varchar(50) not null unique --רҵ����
)
--ѧ��
create table StudentInfo
(
	StuID varchar(20) primary key,  --ѧ��ѧ��
	StuName varchar(50) not null,		--ѧ������
	StuAge int not null check(StuAge > 0 and StuAge < 130), --ѧ������
	StuSex char(2) not null check(StuSex in('��','Ů')),  --ѧ���Ա�
	StuHobby nvarchar(100), --����
	ProfessionID int not null references ProfessionInfo(ProfessionID), --����רҵ���
)
--���רҵ��Ϣ
insert into ProfessionInfo(professionName) values('���Ӿ���')
insert into ProfessionInfo(professionName) values('�������')
insert into ProfessionInfo(professionName) values('ҽ�ƻ���')
--����ѧ����Ϣ
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('001','����',18,'��','',1)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('002','����',20,'��','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('003','�ŷ�',19,'��','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('004','������',17,'Ů','',3)

select* from ProfessionInfo
select* from StudentInfo
select* from StudentInfo inner join ProfessionInfo on StudentInfo.ProfessionID = ProfessionInfo.ProfessionID
