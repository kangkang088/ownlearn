create database DBTEST3
on
(
	name = 'DBTEST3',
	filename = 'E:\DATA\DBTEST3.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'DBTEST3_log',
	filename = 'E:\DATA\DBTEST3_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use DBTEST3
--表关系
--1.一对多(专业表，学生表)
create table Profession
(
	ProId int primary key identity(1,1),--专业编号
	ProName varchar(50) not null--专业名称
)
create table Student
(
	StuId int primary key identity(1,1),--学生编号
	ProId int not null,--此字段用于关联专业表
	StuName varchar(50) not null,--学生名称
	StuSex varchar(2) not null--学生性别
)
insert into Profession(ProName) values('语文')
insert into Profession(ProName) values('计算机')
select* from Profession

insert into Student(ProId,StuName,StuSex) values(1,'刘备','男')
insert into Student(ProId,StuName,StuSex) values(1,'关羽','男')
insert into Student(ProId,StuName,StuSex) values(2,'赵云','男')
insert into Student(ProId,StuName,StuSex) values(2,'张飞','男')
select* from Student

--其实把刘备或关羽删除一个，赵云或张飞删除一个，然后不再添加了，就是一对一
--一对多中包含着一对一。

--一对一（学生基本信息表(学号，姓名，性别)，学生详细信息表（电话，邮箱，地址）)
create table StudentBaseInfo
(
	StuNum varchar(20) primary key not null,--学生编号
	StuName varchar(20) not null,--学生名称
	StuSex nvarchar(1) not null--学生性别
)
create table StudentDetailInfo
(
	StuNum varchar(20) primary key not null,--学生编号
	StuQQ varchar(50) not null,--学生QQ
	StuPhone varchar(50) not null,--学生电话
	StuMail varchar(100) not null,--学生邮箱
	StuBirth date not null,--学生生日
)

--多对多(学生信息表,课程信息表)(添加一张表表示关系)
create table StudentMany
(
	StuId int primary key identity(1,1),--学生编号
	StuName varchar(50) not null,--学生名称
	StuSex varchar(2) not null--学生性别
)
create table Course
(
	CourseId int primary key identity(1,1), --课程编号
	CourseName varchar(30) not null, --课程名称
	CourseContent text --课程介绍
)
create table  Exam --考试信息表
(
	ExamId int primary key identity(1,1), --选课成绩编号
	StuId int not null, --学生编号
	CourseId int not null, --课程编号
	Score int not null --考试成绩
)
insert into Exam(StuId,CourseId,Score) values(1,1,90)
insert into Exam(StuId,CourseId,Score) values(1,2,80)
insert into Exam(StuId,CourseId,Score) values(2,2,85)