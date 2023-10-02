use DBTEST1
--查询所有列所有行
select* from Department
select* from [Rank]
select* from People

--查询指定列（姓名，性别，生日，月薪，电话）
select PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone from People

--查询指定列（姓名，性别，生日，月薪，电话）（显示中文列名） 并没有修改表的列表，只是显示结果变了
select PeopleName 姓名,PeopleSex 性别,PeopleBirth 生日,PeopleSalary 月薪,PeoplePhone 电话 
from People

--查询员工所在的城市（不需要进行重复数据显示）
select distinct PeopleAddress from People

--假设准备加工资（上调百分之二十），想查询出加工资后的员工数据（只是查询预期结果，没有修改，不同于update修改）
select PeopleName,PeopleSex,PeopleSalary*1.2 加薪后的工资 from People
--查询加工资前后的对比
select PeopleName,PeopleSex,PeopleSalary,PeopleSalary*1.2 加薪后的工资 from People

