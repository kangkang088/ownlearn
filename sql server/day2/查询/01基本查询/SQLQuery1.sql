use DBTEST1
--��ѯ������������
select* from Department
select* from [Rank]
select* from People

--��ѯָ���У��������Ա����գ���н���绰��
select PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone from People

--��ѯָ���У��������Ա����գ���н���绰������ʾ���������� ��û���޸ı���б�ֻ����ʾ�������
select PeopleName ����,PeopleSex �Ա�,PeopleBirth ����,PeopleSalary ��н,PeoplePhone �绰 
from People

--��ѯԱ�����ڵĳ��У�����Ҫ�����ظ�������ʾ��
select distinct PeopleAddress from People

--����׼���ӹ��ʣ��ϵ��ٷ�֮��ʮ�������ѯ���ӹ��ʺ��Ա�����ݣ�ֻ�ǲ�ѯԤ�ڽ����û���޸ģ���ͬ��update�޸ģ�
select PeopleName,PeopleSex,PeopleSalary*1.2 ��н��Ĺ��� from People
--��ѯ�ӹ���ǰ��ĶԱ�
select PeopleName,PeopleSex,PeopleSalary,PeopleSalary*1.2 ��н��Ĺ��� from People

