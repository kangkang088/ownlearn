use DBTEST1
select* from [Rank]
select* from Department
select* from People
--��ѯ����(��֪���ڵ�һλ)��Ա����Ϣ %=0����1������ƥ����ַ�
select* from People where PeopleName like '��%'
--��ѯ�����к����е�Ա����Ϣ
select* from People where PeopleName like '%��%'
--��ѯ�������к����л���ʷ��Ա����Ϣ
select* from People where PeopleName like '%��%' or PeopleName like '%ʷ%'

--������������������  _���ҽ���һ��
select* from People where PeopleName like '��_' 
select* from People where SUBSTRING(PeopleName,1,1) = '��' and LEN(PeopleName) = 2
--select SUBSTRING('helko,world',3,1)--�±��1��ʼ
--��ѯ���������һ����Ϊ�㣬����һ���������ֵ�Ա����Ϣ
select* from People where PeopleName like '__�� ' 
select* from People where SUBSTRING(PeopleName,3,1) = '��' and LEN(PeopleName) = 3
--�绰���뿪ͷΪ133��Ա����Ϣ
select* from People where PeoplePhone like '133%'
select* from People where PeoplePhone like '133________'
--�绰���뿪ͷΪ133��Ա����Ϣ,����λ������5����4�����һλ��8
select* from People where PeoplePhone like '133[4,5]%[8]'
--133��ͷ,����λ2-5֮������ݣ����һ�����ֲ���2��3
select* from People where PeoplePhone like '133[2,3,4,5]%[^2,3]'
select* from People where PeoplePhone like '133[2-5]%[^2-3]'