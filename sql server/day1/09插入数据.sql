--���ű��в�������
insert into Department(DepartmentName,DepartmentRemark)
values('�г���','......')
insert into Department(DepartmentName,DepartmentRemark)
values('�����','......')
insert into Department(DepartmentName,DepartmentRemark)
values('�󻮲�','......')
--��д ���Ƽ�
insert into Department values('Ӳ����','......')
insert into Department values('���ϲ�','......')
--һ���Բ����������
insert into Department(DepartmentName,DepartmentRemark)
select '���Բ�','......'union
select 'ʵʩ��','......'union
select '��Ʒ��','......'

--��ְ�����в�������------------------------------------------
insert into [Rank](RandName,RandRemark)
values('����','......')
insert into [Rank](RandName,RandRemark)
values('�м�','......')
insert into [Rank](RandName,RandRemark)
values('�߼�','......')

--��Ա�����в�������------------------------------------------
insert into People(DepartmentId,RankId,PeopleName,PeopleRemark,PeopleGender,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(8,1,'����','...','��','1988-8-8',500,'13888888888','�й�',getdate())