use DBTEST1
select* from People
--统计员工人数，工资总和，平均工资，最高最低工资
select COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People
--(1)根据员工所在地区进行分组，统计员工人数，工资总和，平均工资，最高最低工资
--方案一：union实现
select '武汉' 地区,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People where PeopleAddress = '武汉'
union
select '北京' 地区,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People where PeopleAddress = '北京'
--方案二：分组
select PeopleAddress 地区,COUNT(*) 员工人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People group by PeopleAddress

--(2)根据员工所在地区进行分组，统计员工人数，工资总和，平均工资，最高最低工资,1990年以后的员工不参与统计
select PeopleAddress 地区,COUNT(*) 人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People where PeopleBirth < '2000-1-1' group by PeopleAddress 

--(3)根据员工所在地区进行分组，统计员工人数，工资总和，平均工资，最高最低工资.
--要求筛选出员工人数至少在两人以上的记录，并且在2010年之后出生的员工不参数统计.
select PeopleAddress 地区,COUNT(*) 人数,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资 from People where PeopleBirth < '2010-1-1' group by PeopleAddress having COUNT(*) >= 2