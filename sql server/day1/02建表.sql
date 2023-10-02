--�л����ݿ�
use DBTEST

--������Ļ����﷨
--create table ����
--(
--	�ֶ���1 �������� 
--	�ֶ���2 �������� 
--	�ֶ���3 �������� 
--)
if exists(select* from sys.objects where name = 'Department' and type = 'U')
drop table Department
--����(���ţ�ְ����Ա��)
create table Department
(
    --���ű�� �������� �Զ���������ʼֵΪ1������Ϊ1
	DepartmentId int primary key identity(1,1),
	--�������� ����Ϊ��
	DepartmentName nvarchar(50) not null, 
	--��������
	DepartmentRemark text
)

--char������,char(10),������Դ洢10���ֽڣ����۴洢�������Ƿ���ĵ���10���ֽڣ���Ҫռ��ʮ���ֽ�
--varchar:�䳤��varchar(10),���ռ��10���ֽ�
--text:���ı�����ǧ�����ֽ�  ��������Ϊtext�����ݽ��в�ѯ��Ч�ʽϵ�

--nchar,nvarcahr,ntext:�洢Unicode�ַ����������Ѻ�
--varchar(100) :100����ĸ��50������
--nvarchar(100) :100����ĸ��100������
if exists(select* from sys.objects where name = 'Rank' and type = 'U')
drop table [Rank]
create table [Rank]
(
	RankId int primary key identity(1,1),
	RandName nvarchar(50) not null,
	RandRemark text
)
if exists(select* from sys.objects where name = 'People' and type = 'U')
drop table People
create table People
(
	PeopleId int primary key identity(1,1),--���
	--����(�������)
	DepartmentId int references Department(DepartmentId)not null,
	--ְ��(�������	)
	RankId int references [Rank](RankId)not null,
	PeopleName nvarchar(50) not null,--����
	PeopleRemark text,--���ҽ���
	PeopleGender nvarchar(1) default('��') check(PeopleGender = '��' or PeopleGender = 'Ů') not null,--�Ա�--Ĭ��ֵΪ�У�Լ��Ϊ�л�Ů������Ϊ��
	PeopleBirth smalldatetime not null,--����--�����һ��ʱ��small����ΧС��datetime��ռ�ÿռ�ҲС��Ч�ʸ�	
	PeopleSalary decimal(12,2) check(PeopleSalary >= 1000 and PeopleSalary <= 1000000) not null,--����--С���������λ���ܳ���Ϊ12
	PeoplePhone varchar(20) unique not null,--�绰--������Ψһ�� unique
	PeopleAddress varchar(300),--��ַ
	PeopleAddTime smalldatetime default(getdate())--��ְʱ��--��ӽ���ϵͳ��ʱ�� Ĭ���Զ����뵱ǰʱ��
)
--date ������
--datetime ������ʱ����
