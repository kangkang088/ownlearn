use DBTEST1
select* from People

--��ѯ�Ա�ΪŮ��Ա����������Ϣ
select* from People where PeopleSex = 'Ů'

--��ѯ���ʴ��ڵ���15000��Ա����Ϣ
select* from People where PeopleSalary >= 15000

--�Ա�ΪŮ�����ʴ��ڵ���15000
select* from People where PeopleSalary >= 15000 and PeopleSex = 'Ů'

--��н���ڵ���15000����н���ڵ���8000��ŮԱ��
select* from People where PeopleSalary >=15000 or (PeopleSalary >=8000 and PeopleSex = 'Ů')

--������2000-1-1֮�󣬲�����н���ڵ���15000��ŮԱ��
select* from People where PeopleBirth >= '2000-1-1' and PeopleSalary >=15000 and PeopleSex = 'Ů'

--��н10000-20000֮���Ա����Ϣ����
select* from People where PeopleSalary >=10000 and PeopleSalary <=20000 
select* from People where PeopleSalary between 10000 and 20000

--��ַ���人���߱�����Ա����Ϣ
select* from People where PeopleAddress = '�人' or PeopleAddress = '����'
select* from People where PeopleAddress in('�人','����')

--����
--��ѯ����Ա����Ϣ�����ݹ��ʽ��н�������
--asc������Ĭ��ֵ�� desc������
select* from People order by PeopleSalary desc

--�������ֳ������򣨽���
select* from People order by LEN(PeopleName) desc

--��ѯ��������ߵ�����˵���Ϣ
select top 5 * from People order by PeopleSalary desc

--��ѯ������ߵİٷ�֮ʮ��Ա����Ϣ
select top 10 percent * from People order by PeopleSalary desc

--null����ֵ
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddTime)
values(1,1,'����','��','1977-7-7',500000,'138585858',GETDATE())
--��ѯ����ַû����д��Ա����Ϣ
select* from People where PeopleAddress is null
--��ѯ����ַ�Ѿ���д��Ա����Ϣ
select* from People where PeopleAddress is not null

insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'���ƶ���','��','1977-7-7',500000,'1385875858','',GETDATE())
select* from People where PeopleAddress = ''

--��ϰ
--Ա�����в�ѯ��80��Ա����Ϣ
select * from People where PeopleBirth >= '1980-1-1' and PeopleBirth <= '1989-12-31'
select * from People where PeopleBirth between '1980-1-1' and  '1989-12-31'
select * from People where YEAR(PeopleBirth) between '1980' and '1989'
--30-40֮�䣬���ҹ�����15000-30000֮���Ա����Ϣ
--��������=��ǰ���-�������
select* from People where (YEAR(GETDATE())-YEAR(PeopleBirth) >= 30 and YEAR(GETDATE())-YEAR(PeopleBirth) <= 40) and (PeopleSalary >= 15000 and PeopleSalary <= 30000)
select* from People where (YEAR(GETDATE())-YEAR(PeopleBirth) between 30 and 40) and (PeopleSalary between 15000 and 30000)
--��з��Ա����Ϣ
--��з����6.22-7.22��
select* from People where (MONTH(PeopleBirth)=6 and DAY(PeopleBirth) >=22) or (MONTH(PeopleBirth)=7 and DAY(PeopleBirth) <=22)
--���ʱ����Ƹߵ��˵���Ϣ���Ӳ�ѯ����ѯ�����������
select* from People where PeopleSalary > (select PeopleSalary from People where PeopleName = '����')
--��ѯ��������һ�����е��˵���Ϣ
select* from People where PeopleAddress in (select PeopleAddress from People where PeopleAddress = '�˲�')

--��ѯ����Ч�ǻ�����Ա��Ϣ
--��ţ�������á������ߡ����򡢺����������
--4   5   6  7   8   9  10  11  0  1   2  3
select* from People where YEAR(PeopleBirth) % 12 = 6
--��ѯ���е�Ա����Ϣ�����һ�У���ʾ��Ф
select*,
case YEAR(PeopleBirth) % 12
	when 4 then '��'
	when 5 then 'ţ'
	when 6 then '��'
	when 7 then '��'
	when 8 then '��'
	when 9 then '��'
	when 10 then '��'
	when 11 then '��'
	when 0 then '��'
	when 1 then '��'
	when 2 then '��'
	when 3 then '��'
	else ''
end ��Ф
from People 

