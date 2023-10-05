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
--���ϵ
--1.һ�Զ�(רҵ��ѧ����)
create table Profession
(
	ProId int primary key identity(1,1),--רҵ���
	ProName varchar(50) not null--רҵ����
)
create table Student
(
	StuId int primary key identity(1,1),--ѧ�����
	ProId int not null,--���ֶ����ڹ���רҵ��
	StuName varchar(50) not null,--ѧ������
	StuSex varchar(2) not null--ѧ���Ա�
)
insert into Profession(ProName) values('����')
insert into Profession(ProName) values('�����')
select* from Profession

insert into Student(ProId,StuName,StuSex) values(1,'����','��')
insert into Student(ProId,StuName,StuSex) values(1,'����','��')
insert into Student(ProId,StuName,StuSex) values(2,'����','��')
insert into Student(ProId,StuName,StuSex) values(2,'�ŷ�','��')
select* from Student

--��ʵ�����������ɾ��һ�������ƻ��ŷ�ɾ��һ����Ȼ��������ˣ�����һ��һ
--һ�Զ��а�����һ��һ��

--һ��һ��ѧ��������Ϣ��(ѧ�ţ��������Ա�)��ѧ����ϸ��Ϣ���绰�����䣬��ַ��)
create table StudentBaseInfo
(
	StuNum varchar(20) primary key not null,--ѧ�����
	StuName varchar(20) not null,--ѧ������
	StuSex nvarchar(1) not null--ѧ���Ա�
)
create table StudentDetailInfo
(
	StuNum varchar(20) primary key not null,--ѧ�����
	StuQQ varchar(50) not null,--ѧ��QQ
	StuPhone varchar(50) not null,--ѧ���绰
	StuMail varchar(100) not null,--ѧ������
	StuBirth date not null,--ѧ������
)

--��Զ�(ѧ����Ϣ��,�γ���Ϣ��)(���һ�ű��ʾ��ϵ)
create table StudentMany
(
	StuId int primary key identity(1,1),--ѧ�����
	StuName varchar(50) not null,--ѧ������
	StuSex varchar(2) not null--ѧ���Ա�
)
create table Course
(
	CourseId int primary key identity(1,1), --�γ̱��
	CourseName varchar(30) not null, --�γ�����
	CourseContent text --�γ̽���
)
create table  Exam --������Ϣ��
(
	ExamId int primary key identity(1,1), --ѡ�γɼ����
	StuId int not null, --ѧ�����
	CourseId int not null, --�γ̱��
	Score int not null --���Գɼ�
)
insert into Exam(StuId,CourseId,Score) values(1,1,90)
insert into Exam(StuId,CourseId,Score) values(1,2,80)
insert into Exam(StuId,CourseId,Score) values(2,2,85)