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
	PeopleSex nvarchar(1) default('男') check(PeopleSex = '男' or PeopleSex = '女'),
	PeopleBirth smalldatetime not null,
	PeopleSalary decimal(12,2) check(PeopleSalary >= 1000 and PeopleSalary <= 1000000),
	PeoplePhone varchar(20) unique,
	PeopleAddress varchar(300),
	PeopleAddTime smalldatetime default(getdate())

)

insert into Department(DepartmentName,DepartmentRemark)
values('软件部','......')
insert into Department(DepartmentName,DepartmentRemark)
values('硬件部','......')
insert into Department(DepartmentName,DepartmentRemark)
values('市场部','......')

insert into [Rank](RankName,RankRemark)
values('初级','辅助他人完成任务')
insert into [Rank](RankName,RankRemark)
values('中级','具备上单中单能力')
insert into [Rank](RankName,RankRemark)
values('高级','可以带动全场节奏')

insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,3,'刘备','男','1988-8-8',20000,'13358598468','成都',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'孙尚香','女','1978-8-8',20050,'13345598468','荆州',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'貂蝉','女','1998-8-8',20790,'13359298468','荆州',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'张飞','男','1988-9-8',20780,'17958598468','宜昌',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'赵云','男','1978-4-8',27840,'15145598468','宜昌',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'马超','男','1998-12-8',21790,'17359298468','香港',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,2,'黄盖','男','2001-9-8',29780,'17957398468','武汉',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,1,'西施','女','2002-4-8',17840,'15146598468','武汉',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,2,'曹操','男','1938-12-8',21740,'17359848468','北京',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'许诸','男','2003-4-8',17849,'15895598468','北京',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'典韦','男','2038-12-8',21450,'17619848468','上海',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'曹仁','男','2002-6-8',27880,'15419848468','深圳',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,3,'孙坚','男','2004-4-9',11000,'15895598460','广州',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'孙策','男','2038-12-10',12450,'17619848461','深圳',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,2,'孙权','男','2002-6-11',13080,'15419848462','深圳',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,1,'大乔','女','2005-4-9',11400,'15895598560','北京',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'小乔','女','2030-12-10',12550,'17619846461','武汉',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'周瑜','男','2001-6-11',13680,'15419848762','成都',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(2,3,'鲁肃','男','2012-6-11',13088,'15417548462','成都',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(3,3,'吕蒙','男','2006-4-9',11409,'15895768560','南京',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'陆逊','男','2034-12-10',12551,'17677846461','上海',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'太史慈','男','2041-6-11',13682,'15759848762','上海',getdate())
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,2,'aaaa','男','1983-6-1',7500,'13077778888','上海',getdate())

--查询
select* from Department
select* from [Rank]
select* from People


insert into Department values('软件研发部','公司核心部门')
insert into Department(DepartmentName,DepartmentRemark)
select '市场部','什么都不懂，只知道吹牛'union
select '产品部','.....'union
select '总经办','都是领导'




