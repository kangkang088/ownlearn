create database DBTEST2
on
(
	name = 'DBTEST2',
	filename = 'E:\DATA\DBTEST2.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'DBTEST2_log',
	filename = 'E:\DATA\DBTEST2_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use DBTEST2

create table Student
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null,
	StuAddress varchar(50) not null
)
alter table Student alter column StuAddress varchar(100) not null

--第一范式：要求属性具有原子性，不可再分解
--明显联系方式这一块不符合第一范式
insert into Student(StuId,StuName,StuAddress)
values('001','刘备','QQ:1808131858;Tel:17338597569')
select* from Student
--解决
create table StudentCourse
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null,
	Tel varchar(50) not null,
	QQ varchar(50) not null
)
insert into StudentCourse(StuId,StuName,Tel,QQ)
values('001','刘备','17338597569','1808131858')
select* from StudentCourse

--第二范式：对记录的唯一性，要求记录要有唯一标识，即实体的唯一性，即不存在部分依赖
create table StudentCourse1
(
	StuId varchar(20), --学生编号
	StuName varchar(20) not null, --学生姓名
	CourseId varchar(20) not null, --课程编号
	CourseName varchar(20) not null, --课程名称
	CourseScore int not null --考试成绩
)
--不具备实体唯一性，课程英语和学生刘备都有两个实体。在表里冗余
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('001','刘备','001','语文',80)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('001','刘备','002','数学',70)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('002','关羽','003','英语',80)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('003','张飞','003','英语',90)
select* from StudentCourse1
--解决
create table Course
(
	CourseId int primary key identity(1,1), --课程编号
	CourseName varchar(30) not null, --课程名称
	CourseContent text --课程介绍
)
insert into Course(CourseName,CourseContent) values('HTML','静态网页的制作')
insert into Course(CourseName,CourseContent) values('WinForm','Windows应用程序开发')
create table Student1
(
	StuId int primary key identity(1,1),
	StuName varchar(50) not null,
	StuSex char(2) not null
)
insert into Student1(StuName,StuSex) values('刘备','男')
insert into Student1(StuName,StuSex) values('关羽','男')

create table Exam
(
	ExamId int primary key identity(1,1),
	StuId int not null,
	CourseId int not null,
	Score int not null
)

insert into Exam(StuId,CourseId,Score) values(1,1,90)
insert into Exam(StuId,CourseId,Score) values(1,2,80)
insert into Exam(StuId,CourseId,Score) values(2,2,85)

select* from Course
select* from Student1
select* from Exam

select StuName,CourseName,Score from Student1 inner join Exam on Student1.StuId = Exam.StuId
inner join Course on Course.CourseId = Exam.CourseId

--第三范式:要求任何字段不能由其他字段派生出来，它要求字段没有冗余，即不存在传递依赖
create table Student2
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null, --学生姓名
	ProfessionalId int not null, --专业编号
	ProfessionalName varchar(50), --专业名称
	ProfessionalRemark varchar(200), --专业介绍
)
--明显计算机和最牛的专业出现两次，数据冗余
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('001','刘备',1,'计算机','最牛的专业')
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('002','关羽',2,'工商管理','管理学的基础专业')
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('003','张飞',1,'计算机','最牛的专业')
select* from Student2
--表中也出现了专业编号的冗余
--同时，学生编号和学生姓名是直接关系，可以通过学生编号找到学生姓名。学生编号和专业编号也是直接关系，可以通过学生编号找到专业编号
--但是学生编号和专业名称和专业介绍为间接关系，通过学生编号无法直接找到专业名称和专业介绍，要通过学生名称先找到专业编号，再通过专业编号找到专业名称和专业介绍,也不符合第三范式.

--解决
create table Professional1
(
	ProfessionalId int primary key identity(1,1), --专业编号
	ProfessionalName varchar(50), --专业名称
	ProfessionalRemark varchar(200), --专业介绍
)
create table Student3
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null, --学生姓名
	ProfessionalId int not null, --专业编号
)
insert into Professional1(ProfessionalName,ProfessionalRemark) values('计算机','最牛叉的专业')
insert into Professional1(ProfessionalName,ProfessionalRemark) values('工商管理','管理学的基础专业')
insert into Student3(StuId,StuName,ProfessionalId) values('001','刘备',1)
insert into Student3(StuId,StuName,ProfessionalId) values('002','关羽',2)
insert into Student3(StuId,StuName,ProfessionalId) values('003','张飞',1)
select* from Professional1
select* from Student3
select ProfessionalName 专业名称,ProfessionalRemark 专业介绍,StuName 学生姓名 from Student3 inner join Professional1 on Student3.ProfessionalId = Professional1.ProfessionalId