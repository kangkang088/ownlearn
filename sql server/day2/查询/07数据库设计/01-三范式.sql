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

--��һ��ʽ��Ҫ�����Ծ���ԭ���ԣ������ٷֽ�
--������ϵ��ʽ��һ�鲻���ϵ�һ��ʽ
insert into Student(StuId,StuName,StuAddress)
values('001','����','QQ:1808131858;Tel:17338597569')
select* from Student
--���
create table StudentCourse
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null,
	Tel varchar(50) not null,
	QQ varchar(50) not null
)
insert into StudentCourse(StuId,StuName,Tel,QQ)
values('001','����','17338597569','1808131858')
select* from StudentCourse

--�ڶ���ʽ���Լ�¼��Ψһ�ԣ�Ҫ���¼Ҫ��Ψһ��ʶ����ʵ���Ψһ�ԣ��������ڲ�������
create table StudentCourse1
(
	StuId varchar(20), --ѧ�����
	StuName varchar(20) not null, --ѧ������
	CourseId varchar(20) not null, --�γ̱��
	CourseName varchar(20) not null, --�γ�����
	CourseScore int not null --���Գɼ�
)
--���߱�ʵ��Ψһ�ԣ��γ�Ӣ���ѧ��������������ʵ�塣�ڱ�������
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('001','����','001','����',80)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('001','����','002','��ѧ',70)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('002','����','003','Ӣ��',80)
insert into StudentCourse1(StuId,StuName,CourseId,CourseName,CourseScore)
values('003','�ŷ�','003','Ӣ��',90)
select* from StudentCourse1
--���
create table Course
(
	CourseId int primary key identity(1,1), --�γ̱��
	CourseName varchar(30) not null, --�γ�����
	CourseContent text --�γ̽���
)
insert into Course(CourseName,CourseContent) values('HTML','��̬��ҳ������')
insert into Course(CourseName,CourseContent) values('WinForm','WindowsӦ�ó��򿪷�')
create table Student1
(
	StuId int primary key identity(1,1),
	StuName varchar(50) not null,
	StuSex char(2) not null
)
insert into Student1(StuName,StuSex) values('����','��')
insert into Student1(StuName,StuSex) values('����','��')

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

--������ʽ:Ҫ���κ��ֶβ����������ֶ�������������Ҫ���ֶ�û�����࣬�������ڴ�������
create table Student2
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null, --ѧ������
	ProfessionalId int not null, --רҵ���
	ProfessionalName varchar(50), --רҵ����
	ProfessionalRemark varchar(200), --רҵ����
)
--���Լ��������ţ��רҵ�������Σ���������
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('001','����',1,'�����','��ţ��רҵ')
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('002','����',2,'���̹���','����ѧ�Ļ���רҵ')
insert into Student2(StuId,StuName,ProfessionalId,ProfessionalName,ProfessionalRemark) values('003','�ŷ�',1,'�����','��ţ��רҵ')
select* from Student2
--����Ҳ������רҵ��ŵ�����
--ͬʱ��ѧ����ź�ѧ��������ֱ�ӹ�ϵ������ͨ��ѧ������ҵ�ѧ��������ѧ����ź�רҵ���Ҳ��ֱ�ӹ�ϵ������ͨ��ѧ������ҵ�רҵ���
--����ѧ����ź�רҵ���ƺ�רҵ����Ϊ��ӹ�ϵ��ͨ��ѧ������޷�ֱ���ҵ�רҵ���ƺ�רҵ���ܣ�Ҫͨ��ѧ���������ҵ�רҵ��ţ���ͨ��רҵ����ҵ�רҵ���ƺ�רҵ����,Ҳ�����ϵ�����ʽ.

--���
create table Professional1
(
	ProfessionalId int primary key identity(1,1), --רҵ���
	ProfessionalName varchar(50), --רҵ����
	ProfessionalRemark varchar(200), --רҵ����
)
create table Student3
(
	StuId varchar(20) primary key,
	StuName varchar(20) not null, --ѧ������
	ProfessionalId int not null, --רҵ���
)
insert into Professional1(ProfessionalName,ProfessionalRemark) values('�����','��ţ���רҵ')
insert into Professional1(ProfessionalName,ProfessionalRemark) values('���̹���','����ѧ�Ļ���רҵ')
insert into Student3(StuId,StuName,ProfessionalId) values('001','����',1)
insert into Student3(StuId,StuName,ProfessionalId) values('002','����',2)
insert into Student3(StuId,StuName,ProfessionalId) values('003','�ŷ�',1)
select* from Professional1
select* from Student3
select ProfessionalName רҵ����,ProfessionalRemark רҵ����,StuName ѧ������ from Student3 inner join Professional1 on Student3.ProfessionalId = Professional1.ProfessionalId