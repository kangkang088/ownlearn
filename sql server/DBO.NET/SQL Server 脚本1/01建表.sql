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
values('liubei','123456','刘备','4659874564')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('guanyu','123456','关羽','42354234124')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('zhangfei','123456','张飞','41253445')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('zhaoyun','123456','赵云','75675676547')
insert into Member(MemberAccount,MemberPwd,MemberName,MemberPhone)
values('machao','123456','马超','532523523')

SELECT* FROM Member
select COUNT(*) from Member
select* from Member where MemberAccount = '' or '1' = '1' and MemberPwd = '' or '1' = '1'

--专业
create table ProfessionInfo
(
	ProfessionID int primary key identity(1,1), --专业编号
	professionName varchar(50) not null unique --专业名称
)
--学生
create table StudentInfo
(
	StuID varchar(20) primary key,  --学生学号
	StuName varchar(50) not null,		--学生姓名
	StuAge int not null check(StuAge > 0 and StuAge < 130), --学生年龄
	StuSex char(2) not null check(StuSex in('男','女')),  --学生性别
	StuHobby nvarchar(100), --爱好
	ProfessionID int not null references ProfessionInfo(ProfessionID), --所属专业编号
)
--添加专业信息
insert into ProfessionInfo(professionName) values('电子竞技')
insert into ProfessionInfo(professionName) values('软件开发')
insert into ProfessionInfo(professionName) values('医疗护理')
--插入学生信息
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('001','刘备',18,'男','',1)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('002','关羽',20,'男','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('003','张飞',19,'男','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('004','孙尚香',17,'女','',3)

select* from ProfessionInfo
select* from StudentInfo
select* from StudentInfo inner join ProfessionInfo on StudentInfo.ProfessionID = ProfessionInfo.ProfessionID
