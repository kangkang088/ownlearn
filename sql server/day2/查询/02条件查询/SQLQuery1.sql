use DBTEST1
select* from People

--查询性别为女的员工的所有信息
select* from People where PeopleSex = '女'

--查询工资大于等于15000的员工信息
select* from People where PeopleSalary >= 15000

--性别为女，工资大于等于15000
select* from People where PeopleSalary >= 15000 and PeopleSex = '女'

--月薪大于等于15000或月薪大于等于8000的女员工
select* from People where PeopleSalary >=15000 or (PeopleSalary >=8000 and PeopleSex = '女')

--生日在2000-1-1之后，并且月薪大于等于15000的女员工
select* from People where PeopleBirth >= '2000-1-1' and PeopleSalary >=15000 and PeopleSex = '女'

--月薪10000-20000之间的员工信息（）
select* from People where PeopleSalary >=10000 and PeopleSalary <=20000 
select* from People where PeopleSalary between 10000 and 20000

--地址在武汉或者北京的员工信息
select* from People where PeopleAddress = '武汉' or PeopleAddress = '北京'
select* from People where PeopleAddress in('武汉','北京')

--排序
--查询所有员工信息，根据工资进行降序排序
--asc：升序（默认值） desc：降序
select* from People order by PeopleSalary desc

--根据名字长度排序（降序）
select* from People order by LEN(PeopleName) desc

--查询出工资最高的五个人的信息
select top 5 * from People order by PeopleSalary desc

--查询工资最高的百分之十的员工信息
select top 10 percent * from People order by PeopleSalary desc

--null：空值
insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddTime)
values(1,1,'马云','男','1977-7-7',500000,'138585858',GETDATE())
--查询出地址没有填写的员工信息
select* from People where PeopleAddress is null
--查询出地址已经填写的员工信息
select* from People where PeopleAddress is not null

insert into People(DepartmentId,RanKId,PeopleName,PeopleSex,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(1,1,'马云二号','男','1977-7-7',500000,'1385875858','',GETDATE())
select* from People where PeopleAddress = ''

--练习
--员工表中查询出80后员工信息
select * from People where PeopleBirth >= '1980-1-1' and PeopleBirth <= '1989-12-31'
select * from People where PeopleBirth between '1980-1-1' and  '1989-12-31'
select * from People where YEAR(PeopleBirth) between '1980' and '1989'
--30-40之间，并且工资在15000-30000之间的员工信息
--假设年龄=当前年份-生日年份
select* from People where (YEAR(GETDATE())-YEAR(PeopleBirth) >= 30 and YEAR(GETDATE())-YEAR(PeopleBirth) <= 40) and (PeopleSalary >= 15000 and PeopleSalary <= 30000)
select* from People where (YEAR(GETDATE())-YEAR(PeopleBirth) between 30 and 40) and (PeopleSalary between 15000 and 30000)
--巨蟹座员工信息
--巨蟹座（6.22-7.22）
select* from People where (MONTH(PeopleBirth)=6 and DAY(PeopleBirth) >=22) or (MONTH(PeopleBirth)=7 and DAY(PeopleBirth) <=22)
--工资比赵云高的人的信息（子查询：查询结果做条件）
select* from People where PeopleSalary > (select PeopleSalary from People where PeopleName = '赵云')
--查询和赵云在一个城市的人的信息
select* from People where PeopleAddress in (select PeopleAddress from People where PeopleAddress = '宜昌')

--查询出生效是虎的人员信息
--鼠、牛、虎、兔、龙、蛇、马、羊、猴、鸡、狗、猪
--4   5   6  7   8   9  10  11  0  1   2  3
select* from People where YEAR(PeopleBirth) % 12 = 6
--查询所有的员工信息，添加一列，显示生肖
select*,
case YEAR(PeopleBirth) % 12
	when 4 then '鼠'
	when 5 then '牛'
	when 6 then '虎'
	when 7 then '兔'
	when 8 then '龙'
	when 9 then '蛇'
	when 10 then '马'
	when 11 then '羊'
	when 0 then '猴'
	when 1 then '鸡'
	when 2 then '狗'
	when 3 then '猪'
	else ''
end 生肖
from People 

