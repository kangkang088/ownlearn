use DBTEST1
select* from People
--(1)��Ա��������
select COUNT(*) ���� from People
--(2)��߹���
select MAX(PeopleSalary) ��߹��� from People
--(3)��͹���
select MIN(PeopleSalary) ��͹��� from People
--(4)������Ա�������ܺ�
select SUM(PeopleSalary) �����ܺ� from People
--(5)������Ա����ƽ��ֵ
select ROUND(AVG(PeopleSalary),2) ƽ������ from People
--С����ʾ��̫����ô�죿 0:�������루Ĭ��ֵ�� ����ֵ��ֱ��ɾ��
select ROUND(25.5555,2,0)--������λС��
--(6)������Ϣһ����ʾ
select COUNT(*) ����,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹���,SUM(PeopleSalary) �����ܺ�,ROUND(AVG(PeopleSalary),2) ƽ������ from People
--(7)��ѯ�人������Ա������,�ܹ��ʣ������߹��ʣ�ƽ������
select COUNT(*) ����,MAX(PeopleSalary) ��߹���,MIN(PeopleSalary) ��͹���,SUM(PeopleSalary) �����ܺ�,AVG(PeopleSalary) ƽ������ from People where PeopleAddress = '�人'
--(8)��ѯ��ƽ�����ʸߵ�Ա����Ϣ
select* from People where PeopleSalary > (select ROUND(AVG(PeopleSalary),2) ƽ������ from People)
--(9)���������������ֵ����Сֵ��ƽ��ֵ�������ܺͣ�һ����ʾ
update People set PeopleBirth = '1985-6-28' where PeopleId = 11
update People set PeopleBirth = '1996-8-3' where PeopleId = 14
update people set PeopleBirth = '1996-7-15' where PeopleId = 17
update people set PeopleBirth = '1976-9-25' where PeopleId = 21
update people set PeopleBirth = '1986-6-15' where PeopleId = 22
--����һ��
select*,YEAR(GETDATE()) - YEAR(PeopleBirth) ���� from People
select COUNT(*) ����,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) �������ֵ,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) ������Сֵ,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) ƽ��ֵ,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) �����ܺ� from People
--��������
select DATEDIFF(YEAR,PeopleBirth,GETDATE())  from People
select COUNT(*) ����,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �������ֵ,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ������Сֵ,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ƽ��ֵ,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �����ܺ� from People
--(10)��н10000���ϵ���Ա����������䣬��С�����ƽ������
select COUNT(*) ����,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �������ֵ,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ������Сֵ,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ƽ��ֵ,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �����ܺ� from People where PeopleSalary > 10000 and PeopleSex = '��'
select COUNT(*) ����,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) �������ֵ,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) ������Сֵ,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) ƽ��ֵ,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) �����ܺ� from People where PeopleSalary > 10000 and PeopleSex = '��'
--(11)ͳ�����ڵ����Ϻ����人������ŮԱ����������䣬��С���䣬ƽ������
select '�人���Ϻ���ŮԱ��' ����,COUNT(*) ����,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) �������ֵ,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) ������Сֵ,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) ƽ��ֵ,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) �����ܺ� from People where PeopleAddress in('�人','�Ϻ�') and PeopleSex = 'Ů'
select COUNT(*) ����,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �������ֵ,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ������Сֵ,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ƽ��ֵ,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) �����ܺ� from People where PeopleAddress in('�人','�Ϻ�') and PeopleSex = 'Ů'
--(12)�����ƽ������ߵ�Ա����Ϣ
select* from People where YEAR(GETDATE()) - YEAR(PeopleBirth) > (select AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) ƽ������ from people)
select*,YEAR(GETDATE())-YEAR(PeopleBirth) ���� from People