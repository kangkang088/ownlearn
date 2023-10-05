use DBTEST1
select* from People
select* from [Rank]
select* from Department
delete from Department where DepartmentId >=4
--笛卡尔乘积
select* from People,Department

--简单多表查询
--查询员工信息，并显示相应的部门名称
select* from People,Department where People.DepartmentId = Department.DepartmentId
--查询员工信息，并显示相应的职级信息
select* from People,[Rank] where People.RanKId = [Rank].RankId
----查询员工信息，并显示相应的部门名称,职级信息
select* from People,[Rank],Department where People.RanKId = [Rank].RankId and People.DepartmentId = Department.DepartmentId

--内连接查询
--查询员工信息，并显示相应的部门名称
select* from People inner join Department on People.DepartmentId = Department.DepartmentId
--查询员工信息，并显示相应的职级信息
select* from People inner join [Rank] on [Rank].RankId = People.RanKId
--查询员工信息，并显示相应的部门名称,职级信息
select* from People inner join Department on People.DepartmentId = Department.DepartmentId 
inner join [Rank] on [Rank].RankId = People.RanKId

--简单多表查询和内连接查询的共同特定：不符合主外键关系(部门表里面有部门没人或者人的部门在部门表里面没有)的数据不会被显示出来
--先取消外键约束，添加一个部门编号99和职级编号99的刘德华
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(99,99,'刘德华','男','1999-1-1',15000,'18944448888','上海',GETDATE())
select* from People inner join Department on People.DepartmentId = Department.DepartmentId--不会显示刘德华，不符合主外键关系

select* from People
select* from Department

--外连接（左、右、全外连接）
--(1)左外连接
--查询员工信息，并显示相应的部门名称
--特点：以左表为主表进行数据显示，主外键关系找不到的数据用null取代
select* from People left join Department on People.DepartmentId = Department.DepartmentId

insert into Department(DepartmentName,DepartmentRemark)
values('人事部','人员关系')
select* from Department left join People on People.DepartmentId = Department.DepartmentId

--查询员工信息，并显示相应的职级信息
select* from People left join [Rank] on People.RanKId = [Rank].RankId

----查询员工信息，并显示相应的部门名称,职级信息
select* from People left join [Rank] on People.RanKId = [Rank].RankId 
left join Department on People.DepartmentId = Department.DepartmentId

--(2)右外连接
select* from People left join Department on People.DepartmentId = Department.DepartmentId
---------------------- =========== --------------------------------------------
select* from Department right join People on people.DepartmentId = Department.DepartmentId

--(3)全外连接 两张表无论是否符合关系，都显示
select* from People full join Department on People.DepartmentId = Department.DepartmentId

--多表查询综合案例
--(1)武汉地区所有员工信息，要求显示部门名称以及员工的详细资料(中文别名)
select PeopleId 员工编号,DepartmentName 部门名称,PeopleName 员工姓名,PeopleSex 员工性别,PeopleBirth 员工生日,PeopleSalary 员工工资,PeoplePhone 员工电话,PeopleAddress 员工地址 from People left join Department on People.DepartmentId = Department.DepartmentId where PeopleAddress = '武汉'
--(2)武汉地区所有员工信息，要求显示部门名称，职级名称以及员工的详细资料(中文别名)
select PeopleId 员工编号,DepartmentName 部门名称,RankName 职级信息,PeopleName 员工姓名,PeopleSex 员工性别,PeopleBirth 员工生日,PeopleSalary 员工工资,PeoplePhone 员工电话,PeopleAddress 员工地址 from People left join Department on People.DepartmentId = Department.DepartmentId
left join [Rank] on People.RanKId = [Rank].RankId
where PeopleAddress = '武汉'
--(3)根据部门分组统计人员人数，工资总和，平均，最高，最低工资
select Department.DepartmentName 部门名称,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People inner join Department on People.DepartmentId = Department.DepartmentId
group by Department.DepartmentId,DepartmentName
--(4)根据部门分组统计人员人数，工资总和，平均，最高，最低工资
--平均工资15000以下的不显示
select Department.DepartmentName 部门名称,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People inner join Department on Department.DepartmentId = People.DepartmentId 
group by Department.DepartmentId,DepartmentName having AVG(PeopleSalary) >=15000 order by AVG(PeopleSalary) desc
--(5)根据部门名称,然后根据职位名称，分组统计人员人数，工资总和，平均，最高，最低工资
select Department.DepartmentName 部门名称,[Rank].RankName 职级名称,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People inner join Department on People.DepartmentId = Department.DepartmentId
inner join [Rank] on [Rank].RankId = People.RanKId
group by Department.DepartmentId,DepartmentName,[Rank].RankId,RankName


--自连接(自己连自己)
create table Dept
(
	DeptID int primary key,--部门编号
	DeptName varchar(50),--部门名称
	ParentId int --上级部门编号
)
--一级部门
insert into Dept(DeptID,DeptName,ParentId) values(1,'软件部',0)
insert into Dept(DeptID,DeptName,ParentId) values(2,'硬件部',0)
--二级部门
insert into Dept(DeptID,DeptName,ParentId) values(3,'软件研发部',1)
insert into Dept(DeptID,DeptName,ParentId) values(4,'软件测试部',1)
insert into Dept(DeptID,DeptName,ParentId) values(5,'软件实施部',1)
insert into Dept(DeptID,DeptName,ParentId) values(6,'硬件研发部',2)
insert into Dept(DeptID,DeptName,ParentId) values(7,'硬件测试部',2)
insert into Dept(DeptID,DeptName,ParentId) values(8,'硬件实施部',2)

select* from Dept
--部门编号   部门名称   上级部门名称
-- 3       软件研发部     软件部
-- 4       软件测试部     软件部
---------------------------------

select A.DeptID 部门编号,a.DeptName 部门名称,b.DeptName 上级部门名称 from Dept A inner join Dept B on A.ParentId = b.DeptID