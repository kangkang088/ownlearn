use DBTEST1
select* from People
--(1)求员工总人数
select COUNT(*) 人数 from People
--(2)最高工资
select MAX(PeopleSalary) 最高工资 from People
--(3)最低工资
select MIN(PeopleSalary) 最低工资 from People
--(4)求所有员工工资总和
select SUM(PeopleSalary) 工资总和 from People
--(5)求所有员工工平均值
select ROUND(AVG(PeopleSalary),2) 平均工资 from People
--小数显示的太多怎么办？ 0:四舍五入（默认值） 其他值：直接删掉
select ROUND(25.5555,2,0)--保留两位小数
--(6)所有信息一行显示
select COUNT(*) 人数,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资,SUM(PeopleSalary) 工资总和,ROUND(AVG(PeopleSalary),2) 平均工资 from People
--(7)查询武汉地区的员工人数,总工资，最低最高工资，平均工资
select COUNT(*) 人数,MAX(PeopleSalary) 最高工资,MIN(PeopleSalary) 最低工资,SUM(PeopleSalary) 工资总和,AVG(PeopleSalary) 平均工资 from People where PeopleAddress = '武汉'
--(8)查询比平均工资高的员工信息
select* from People where PeopleSalary > (select ROUND(AVG(PeopleSalary),2) 平均工资 from People)
--(9)求数量，年龄最大值，最小值，平均值，年龄总和，一行显示
update People set PeopleBirth = '1985-6-28' where PeopleId = 11
update People set PeopleBirth = '1996-8-3' where PeopleId = 14
update people set PeopleBirth = '1996-7-15' where PeopleId = 17
update people set PeopleBirth = '1976-9-25' where PeopleId = 21
update people set PeopleBirth = '1986-6-15' where PeopleId = 22
--方案一：
select*,YEAR(GETDATE()) - YEAR(PeopleBirth) 年龄 from People
select COUNT(*) 数量,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最大值,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最小值,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) 平均值,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄总和 from People
--方案二：
select DATEDIFF(YEAR,PeopleBirth,GETDATE())  from People
select COUNT(*) 数量,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最大值,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最小值,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 平均值,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄总和 from People
--(10)月薪10000以上的男员工的最大年龄，最小年龄和平均年龄
select COUNT(*) 数量,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最大值,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最小值,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 平均值,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄总和 from People where PeopleSalary > 10000 and PeopleSex = '男'
select COUNT(*) 数量,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最大值,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最小值,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) 平均值,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄总和 from People where PeopleSalary > 10000 and PeopleSex = '男'
--(11)统计所在地在上海或武汉的所有女员工的最大年龄，最小年龄，平均年龄
select '武汉或上海的女员工' 描述,COUNT(*) 数量,MAX(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最大值,MIN(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄最小值,AVG(YEAR(GETDATE()) - YEAR(PeopleBirth)) 平均值,SUM(YEAR(GETDATE()) - YEAR(PeopleBirth)) 年龄总和 from People where PeopleAddress in('武汉','上海') and PeopleSex = '女'
select COUNT(*) 数量,MAX(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最大值,MIN(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄最小值,AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 平均值,SUM(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 年龄总和 from People where PeopleAddress in('武汉','上海') and PeopleSex = '女'
--(12)年龄比平均年龄高的员工信息
select* from People where YEAR(GETDATE()) - YEAR(PeopleBirth) > (select AVG(DATEDIFF(YEAR,PeopleBirth,GETDATE())) 平均年龄 from people)
select*,YEAR(GETDATE())-YEAR(PeopleBirth) 年龄 from People