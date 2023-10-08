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