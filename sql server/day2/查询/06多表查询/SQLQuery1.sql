use DBTEST1
select* from People
select* from [Rank]
select* from Department
delete from Department where DepartmentId >=4
--�ѿ����˻�
select* from People,Department

--�򵥶���ѯ
--��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������
select* from People,Department where People.DepartmentId = Department.DepartmentId
--��ѯԱ����Ϣ������ʾ��Ӧ��ְ����Ϣ
select* from People,[Rank] where People.RanKId = [Rank].RankId
----��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������,ְ����Ϣ
select* from People,[Rank],Department where People.RanKId = [Rank].RankId and People.DepartmentId = Department.DepartmentId

--�����Ӳ�ѯ
--��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������
select* from People inner join Department on People.DepartmentId = Department.DepartmentId
--��ѯԱ����Ϣ������ʾ��Ӧ��ְ����Ϣ
select* from People inner join [Rank] on [Rank].RankId = People.RanKId
--��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������,ְ����Ϣ
select* from People inner join Department on People.DepartmentId = Department.DepartmentId 
inner join [Rank] on [Rank].RankId = People.RanKId

--�򵥶���ѯ�������Ӳ�ѯ�Ĺ�ͬ�ض����������������ϵ(���ű������в���û�˻����˵Ĳ����ڲ��ű�����û��)�����ݲ��ᱻ��ʾ����
--��ȡ�����Լ�������һ�����ű��99��ְ�����99�����»�
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(99,99,'���»�','��','1999-1-1',15000,'18944448888','�Ϻ�',GETDATE())
select* from People inner join Department on People.DepartmentId = Department.DepartmentId--������ʾ���»����������������ϵ

select* from People
select* from Department

--�����ӣ����ҡ�ȫ�����ӣ�
--(1)��������
--��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������
--�ص㣺�����Ϊ�������������ʾ���������ϵ�Ҳ�����������nullȡ��
select* from People left join Department on People.DepartmentId = Department.DepartmentId

insert into Department(DepartmentName,DepartmentRemark)
values('���²�','��Ա��ϵ')
select* from Department left join People on People.DepartmentId = Department.DepartmentId

--��ѯԱ����Ϣ������ʾ��Ӧ��ְ����Ϣ
select* from People left join [Rank] on People.RanKId = [Rank].RankId

----��ѯԱ����Ϣ������ʾ��Ӧ�Ĳ�������,ְ����Ϣ
select* from People left join [Rank] on People.RanKId = [Rank].RankId 
left join Department on People.DepartmentId = Department.DepartmentId

--(2)��������
select* from People left join Department on People.DepartmentId = Department.DepartmentId
---------------------- =========== --------------------------------------------
select* from Department right join People on people.DepartmentId = Department.DepartmentId

--(3)ȫ������ ���ű������Ƿ���Ϲ�ϵ������ʾ
select* from People full join Department on People.DepartmentId = Department.DepartmentId

--����ѯ�ۺϰ���
--(1)�人��������Ա����Ϣ��Ҫ����ʾ���������Լ�Ա������ϸ����(���ı���)
select PeopleId Ա�����,DepartmentName ��������,PeopleName Ա������,PeopleSex Ա���Ա�,PeopleBirth Ա������,PeopleSalary Ա������,PeoplePhone Ա���绰,PeopleAddress Ա����ַ from People left join Department on People.DepartmentId = Department.DepartmentId where PeopleAddress = '�人'
--(2)�人��������Ա����Ϣ��Ҫ����ʾ�������ƣ�ְ�������Լ�Ա������ϸ����(���ı���)
select PeopleId Ա�����,DepartmentName ��������,RankName ְ����Ϣ,PeopleName Ա������,PeopleSex Ա���Ա�,PeopleBirth Ա������,PeopleSalary Ա������,PeoplePhone Ա���绰,PeopleAddress Ա����ַ from People left join Department on People.DepartmentId = Department.DepartmentId
left join [Rank] on People.RanKId = [Rank].RankId
where PeopleAddress = '�人'
--(3)���ݲ��ŷ���ͳ����Ա�����������ܺͣ�ƽ������ߣ���͹���
select Department.DepartmentName ��������,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People inner join Department on People.DepartmentId = Department.DepartmentId
group by Department.DepartmentId,DepartmentName
--(4)���ݲ��ŷ���ͳ����Ա�����������ܺͣ�ƽ������ߣ���͹���
--ƽ������15000���µĲ���ʾ
select Department.DepartmentName ��������,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People inner join Department on Department.DepartmentId = People.DepartmentId 
group by Department.DepartmentId,DepartmentName having AVG(PeopleSalary) >=15000 order by AVG(PeopleSalary) desc
--(5)���ݲ�������,Ȼ�����ְλ���ƣ�����ͳ����Ա�����������ܺͣ�ƽ������ߣ���͹���
select Department.DepartmentName ��������,[Rank].RankName ְ������,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People inner join Department on People.DepartmentId = Department.DepartmentId
inner join [Rank] on [Rank].RankId = People.RanKId
group by Department.DepartmentId,DepartmentName,[Rank].RankId,RankName


--������(�Լ����Լ�)
create table Dept
(
	DeptID int primary key,--���ű��
	DeptName varchar(50),--��������
	ParentId int --�ϼ����ű��
)
--һ������
insert into Dept(DeptID,DeptName,ParentId) values(1,'�����',0)
insert into Dept(DeptID,DeptName,ParentId) values(2,'Ӳ����',0)
--��������
insert into Dept(DeptID,DeptName,ParentId) values(3,'����з���',1)
insert into Dept(DeptID,DeptName,ParentId) values(4,'������Բ�',1)
insert into Dept(DeptID,DeptName,ParentId) values(5,'���ʵʩ��',1)
insert into Dept(DeptID,DeptName,ParentId) values(6,'Ӳ���з���',2)
insert into Dept(DeptID,DeptName,ParentId) values(7,'Ӳ�����Բ�',2)
insert into Dept(DeptID,DeptName,ParentId) values(8,'Ӳ��ʵʩ��',2)

select* from Dept
--���ű��   ��������   �ϼ���������
-- 3       ����з���     �����
-- 4       ������Բ�     �����
---------------------------------

select A.DeptID ���ű��,a.DeptName ��������,b.DeptName �ϼ��������� from Dept A inner join Dept B on A.ParentId = b.DeptID