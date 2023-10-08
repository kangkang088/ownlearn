create table Department
(
	DepartmentId varchar(10) primary key,
	DepartmentName nvarchar(50)
)
create table People
(
	PeopleId int primary key identity(1,1),
	DepartmentId varchar(10),
	PeopleName nvarchar(20),
	PeopleSex varchar(2),
	PeoplePhone varchar(20),
)
insert into Department(DepartmentId,DepartmentName) values('001','�ܾ���')
insert into Department(DepartmentId,DepartmentName) values('002','�г���')
insert into Department(DepartmentId,DepartmentName) values('003','���²�')
insert into Department(DepartmentId,DepartmentName) values('004','����')
insert into Department(DepartmentId,DepartmentName) values('005','�����')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('001','����','��','13558785478')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('001','����','��','13558788785')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('002','�ŷ�','��','13698547125')

select* from Department
select* from People
go

--(1)�����в��ű��Ա�������Ա����ʱ�򣬸�Ա���Ĳ��ű������ڲ��ű����Ҳ�����
--���Զ���Ӳ�����Ϣ����������Ϊ���²��š�
--����һ��������    ���ֽ�          ���ĸ�����(���ĸ��������ʱ��Żᴥ��)   �����������ʲô����Żᴥ��
create trigger tri_InsertPeople       on People                             after insert
--����ʲô����
as														--inserted:������������ݵ�ʱ�򣬻������һ����ʱ�ı��洢��ӵ�����
	if not exists(select* from Department where DepartmentId = (select DepartmentId from inserted))
	begin
		insert into Department(DepartmentId,DepartmentName) values((select DepartmentId from inserted),'�²���')
	end
go
--���Դ�����
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('003','����','��','13698547125')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('006','��','��','13698547125')
select* from Department
--(2)������ʵ�֣�ɾ��һ������ʱ�������µ�����Ա����ɾ��
go
create trigger tri_DeleteDept on Department after delete 
as
	delete from People where DepartmentId = (select DepartmentId from deleted)
go
--����
delete from Department where DepartmentId = '006'
select* from Department
select* from People
--(3)����һ����������ɾ��һ�����ŵ�ʱ���ж������Ƿ���Ա��������ɾ����û����ɾ��
go
create trigger tri_DeleteDept_s on Department instead of delete
as
	if not exists(select* from People where DepartmentId = (select DepartmentId from deleted))
	delete from Department where DepartmentId = (select DepartmentId from deleted)
go
--����
select* from Department
select* from People
delete from Department where DepartmentId = '005'
--(4)�޸�һ�����ű�ţ���������Ա���Ĳ��ű�Ÿ����޸�
go
create trigger tri_UpdateDept on Department after update
as
	--�޸�һ�����ݣ�������Ϊ����ɾ�������ݣ������������
	update People set DepartmentId = (select DepartmentId from inserted) 
	where DepartmentId = (select DepartmentId from deleted)
go
--����
select* from Department
select* from People
update Department set DepartmentId = '005' where DepartmentId = '001'