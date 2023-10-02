use DBTEST1
--查询
select* from Department
select* from [Rank]
select* from People

--数据修改
--update 表名 set 字段1 = 值1,字段2 = 值2 where 条件

--工资的普调,每个人加薪1000元
update People set PeopleSalary = PeopleSalary + 1000
--为某一个人进行加薪,假设对编号为7的员工进行加薪500
update People set PeopleSalary = PeopleSalary + 500 
where PeopleId = 7
--将软件部(已知编号为1)的工资低于15000的人，变成15000
update People set PeopleSalary = 15000
where PeopleSalary < 15000 and DepartmentId  = 1
--修改刘备的工资是以前的两倍，并且刘备的地址改成北京
update People set PeopleSalary = PeopleSalary * 2,PeopleAddress = '北京' 
where PeopleName = '刘备'

--删除数据---------------------------------------
--delete from 表名 where 条件
--删除员工表所有记录
delete from People --这条语句就不执行了
--删除市场部（已知部门编号3）中工资大于20000的人
delete from People 
where DepartmentId = 3 and PeopleSalary > 20000

--删除（drop truncate，delete）
--  drop table People --删除表对象 = 右键删除 表和数据都没了
--  delete from --删除表里面的数据 表还在，数据根据条件清除，不加条件就是全部删除
--  truncate table People -- 删除表数据 表还在，数据全部清空


