create table Student
(
	StuId int primary key identity(1,2),
	StuName varchar(20),
	StuSex varchar(4)
)
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('�ŷ�','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('��','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('κ��','��')
insert into Student(StuName,StuSex) values('��Ӻ','��')
insert into Student(StuName,StuSex) values('�����','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('�ܲ�','��')
insert into Student(StuName,StuSex) values('��ƽ','��')
insert into Student(StuName,StuSex) values('�Ű�','��')
insert into Student(StuName,StuSex) values('�ܲ�','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('��ا','��')
insert into Student(StuName,StuSex) values('��ֲ','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('��Τ','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('�ĺ��','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('����','��')
insert into Student(StuName,StuSex) values('��ڼ','��')
insert into Student(StuName,StuSex) values('��Ȩ','��')
insert into Student(StuName,StuSex) values('���','��')
insert into Student(StuName,StuSex) values('���','��')
insert into Student(StuName,StuSex) values('̫ʷ��','��')
insert into Student(StuName,StuSex) values('����','Ů')
insert into Student(StuName,StuSex) values('С��','Ů')

select* from Student
--��ҳ
--����ÿҳ��������
--��һҳ
select top 5 * from Student where StuId not in (select top 0 StuId from Student)
--�ڶ�ҳ
select top 5 * from Student where StuId not in(select top 5 StuId from Student)
--����ҳ���Դ�����
select top 5 * from Student where StuId not in(select top 10 StuId from Student)
--����ҳ
select top 5 * from Student where StuId not in(select top 15 StuId from Student)
--����ҳ
select top 5 * from Student where StuId not in(select top 20 StuId from Student)
--����ҳ
select top 5 * from Student where StuId not in(select top 25 StuId from Student)

--���ɣ�
-------------------------------------------------------------------------------
--select top ҳ���С��ÿҳ�м�������� * from Student where StuId not in (select top ҳ���С*����ǰҳ-1�� StuId from Student)
-------------------------------------------------------------------------------

--��ҳ
--����һ���������ر���ʱ��Ч�ʲ���
declare @PageSize int = 5
declare @PageIndex int = 1 --2��3��4��5��... n
select top (@PageSize) * from Student where StuId not in(select top (@PageSize*(@PageIndex - 1)) StuId from Student)
go
--��������ʹ��row_number��ҳ 
--����idʹ��between 1 and 5 ���з�ҳʱ���������⣬��һҳ����ɾ����һ��3����ʱ��һҳ��ѯӦ����1��5��7��9��11������������betweenȴ��1��5��7��9
--��� ��row_number�����к�
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 1 and 5
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 6 and 10
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 11 and 15
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 16 and 20
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 21 and 25
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 26 and 30
--select* from (select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp where RowID between 1 and 5
--between (��ǰҳ-1)*ҳ���С + 1 and ��ǰҳ*ҳ���С

declare @PageSize int = 5
declare @PageIndex int = 3 --2��3��4��5��... n
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between (((@PageIndex - 1)*@PageSize) + 1) and (@PageIndex * @PageSize)