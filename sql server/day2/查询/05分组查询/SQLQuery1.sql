use DBTEST1
select* from People
--ͳ��Ա�������������ܺͣ�ƽ�����ʣ������͹���
select COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People
--(1)����Ա�����ڵ������з��飬ͳ��Ա�������������ܺͣ�ƽ�����ʣ������͹���
--����һ��unionʵ��
select '�人' ����,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People where PeopleAddress = '�人'
union
select '����' ����,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People where PeopleAddress = '����'
--������������
select PeopleAddress ����,COUNT(*) Ա������,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People group by PeopleAddress

--(2)����Ա�����ڵ������з��飬ͳ��Ա�������������ܺͣ�ƽ�����ʣ������͹���,1990���Ժ��Ա��������ͳ��
select PeopleAddress ����,COUNT(*) ����,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People where PeopleBirth < '2000-1-1' group by PeopleAddress 

--(3)����Ա�����ڵ������з��飬ͳ��Ա�������������ܺͣ�ƽ�����ʣ������͹���.
--Ҫ��ɸѡ��Ա�������������������ϵļ�¼��������2010��֮�������Ա��������ͳ��.
select PeopleAddress ����,COUNT(*) ����,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹��� from People where PeopleBirth < '2010-1-1' group by PeopleAddress having COUNT(*) >= 2