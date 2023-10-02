create database DBTEST1
on
(
	name = 'DBTEST1',
	filename = 'E:\DATA\DBTEST1.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'DBTEST1_log',
	filename = 'E:\DATA\DBTEST1.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use DBTEST1
create table Department
(
	DepartmentId int primary key identity(1,1),
	DepartmentName nvarchar(50)not null,
	DepartmentRemark text 
)
create table [Rank]
(
	RankId int primary key identity(1,1),
	RankName nvarchar(50)not null,
	RankRemark text
)
create table People
(
	PeopleId int primary key identity(1,1),
	DepartmentId int references Department(DepartmentId)not null,
	RanKId int references [Rank](RankId)not null,
	PeopleName nvarchar(50)not null,
	PeopleSex nvarchar(1) default('��') check(PeopleSex = '��' or PeopleSex = 'Ů'),
	PeopleBirth smalldatetime not null,
	PeopleSalary decimal(12,2) check(PeopleSalary >= 1000 and PeopleSalary <= 1000000),
	PeoplePhone varchar(20) unique,
	PeopleAddress varchar(300),
	PeopleAddTime smalldatetime default(getdate())

)

insert into Department(DepartmentName,DepartmentRemark)
values('�����','......')
insert into Department(DepartmentName,DepartmentRemark)
values('Ӳ����','......')
insert into Department(DepartmentName,DepartmentRemark)
values('�г���','......')

insert into [Rank](RankName,RankRemark)
values('����','���������������')
insert into [Rank](RankName,RankRemark)
values('�м�','�߱��ϵ��е�����')
insert into [Rank](RankName,RankRemark)
values('�߼�','���Դ���ȫ������')

insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,3,'����','��','1988-8-8',20000,'13358598468','�ɶ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'������','Ů','1978-8-8',20050,'13345598468','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'����','Ů','1998-8-8',20790,'13359298468','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'�ŷ�','��','1988-9-8',20780,'17958598468','�˲�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'����','��','1978-4-8',27840,'15145598468','�˲�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'��','��','1998-12-8',21790,'17359298468','���',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,2,'�Ƹ�','��','2001-9-8',29780,'17957398468','�人',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,1,'��ʩ','Ů','2002-4-8',17840,'15146598468','�人',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,2,'�ܲ�','��','1938-12-8',21740,'17359848468','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'����','��','2003-4-8',17849,'15895598468','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'��Τ','��','2038-12-8',21450,'17619848468','�Ϻ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'����','��','2002-6-8',27880,'15419848468','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,3,'���','��','2004-4-9',11000,'15895598460','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'���','��','2038-12-10',12450,'17619848461','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,2,'��Ȩ','��','2002-6-11',13080,'15419848462','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'����','Ů','2005-4-9',11400,'15895598560','����',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'С��','Ů','2030-12-10',12550,'17619846461','�人',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'���','��','2001-6-11',13680,'15419848762','�ɶ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'³��','��','2012-6-11',13088,'15417548462','�ɶ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'����','��','2006-4-9',11409,'15895768560','�Ͼ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'½ѷ','��','2034-12-10',12551,'17677846461','�Ϻ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'̫ʷ��','��','2041-6-11',13682,'15759848762','�Ϻ�',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'aaaa','��','1983-6-1',7500,'13077778888','�Ϻ�',getdate())

--��ѯ
select* from Department
select* from [Rank]
select* from People


insert into Department values('����з���','��˾���Ĳ���')
insert into Department(DepartmentName,DepartmentRemark)
select '�г���','ʲô��������ֻ֪����ţ'union
select '��Ʒ��','.....'union
select '�ܾ���','�����쵼'




