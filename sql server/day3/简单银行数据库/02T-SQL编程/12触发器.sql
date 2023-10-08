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
insert into Department(DepartmentId,DepartmentName) values('001','总经办')
insert into Department(DepartmentId,DepartmentName) values('002','市场部')
insert into Department(DepartmentId,DepartmentName) values('003','人事部')
insert into Department(DepartmentId,DepartmentName) values('004','财务部')
insert into Department(DepartmentId,DepartmentName) values('005','软件部')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('001','刘备','男','13558785478')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('001','关羽','男','13558788785')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('002','张飞','男','13698547125')

select* from Department
select* from People
go

--(1)假设有部门表和员工表，添加员工的时候，该员工的部门编号如果在部门表里找不到，
--则自动添加部门信息，部门名称为‘新部门’
--创建一个触发器    名字叫          在哪个表里(对哪个表操作的时候才会触发)   在这个表里做什么事情才会触发
create trigger tri_InsertPeople       on People                             after insert
--触发什么事情
as														--inserted:在我们添加数据的时候，会产生的一张临时的表，存储添加的数据
	if not exists(select* from Department where DepartmentId = (select DepartmentId from inserted))
	begin
		insert into Department(DepartmentId,DepartmentName) values((select DepartmentId from inserted),'新部门')
	end
go
--测试触发器
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('003','赵云','男','13698547125')
insert into People(DepartmentId,PeopleName,PeopleSex,PeoplePhone) values('006','马超','男','13698547125')
select* from Department
--(2)触发器实现，删除一个部门时，部门下的所有员工都删除
go
create trigger tri_DeleteDept on Department after delete 
as
	delete from People where DepartmentId = (select DepartmentId from deleted)
go
--测试
delete from Department where DepartmentId = '006'
select* from Department
select* from People
--(3)创建一个触发器，删除一个部门的时候判断其下是否有员工，有则不删除，没有则删除
go
create trigger tri_DeleteDept_s on Department instead of delete
as
	if not exists(select* from People where DepartmentId = (select DepartmentId from deleted))
	delete from Department where DepartmentId = (select DepartmentId from deleted)
go
--测试
select* from Department
select* from People
delete from Department where DepartmentId = '005'
--(4)修改一个部门编号，其下所有员工的部门编号跟着修改
go
create trigger tri_UpdateDept on Department after update
as
	--修改一条数据，可以认为是先删除老数据，再添加新数据
	update People set DepartmentId = (select DepartmentId from inserted) 
	where DepartmentId = (select DepartmentId from deleted)
go
--测试
select* from Department
select* from People
update Department set DepartmentId = '005' where DepartmentId = '001'