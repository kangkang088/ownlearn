use DBTEST1
--��ѯ
select* from Department
select* from [Rank]
select* from People

--�����޸�
--update ���� set �ֶ�1 = ֵ1,�ֶ�2 = ֵ2 where ����

--���ʵ��յ�,ÿ���˼�н1000Ԫ
update People set PeopleSalary = PeopleSalary + 1000
--Ϊĳһ���˽��м�н,����Ա��Ϊ7��Ա�����м�н500
update People set PeopleSalary = PeopleSalary + 500 
where PeopleId = 7
--�������(��֪���Ϊ1)�Ĺ��ʵ���15000���ˣ����15000
update People set PeopleSalary = 15000
where PeopleSalary < 15000 and DepartmentId  = 1
--�޸������Ĺ�������ǰ�����������������ĵ�ַ�ĳɱ���
update People set PeopleSalary = PeopleSalary * 2,PeopleAddress = '����' 
where PeopleName = '����'

--ɾ������---------------------------------------
--delete from ���� where ����
--ɾ��Ա�������м�¼
delete from People --�������Ͳ�ִ����
--ɾ���г�������֪���ű��3���й��ʴ���20000����
delete from People 
where DepartmentId = 3 and PeopleSalary > 20000

--ɾ����drop truncate��delete��
--  drop table People --ɾ������� = �Ҽ�ɾ�� ������ݶ�û��
--  delete from --ɾ������������� ���ڣ����ݸ������������������������ȫ��ɾ��
--  truncate table People -- ɾ�������� ���ڣ�����ȫ�����


