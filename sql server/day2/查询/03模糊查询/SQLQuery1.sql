use DBTEST1
select* from [Rank]
select* from Department
select* from People
--查询姓刘(已知刘在第一位)的员工信息 %=0个、1个或多个匹配的字符
select* from People where PeopleName like '刘%'
--查询名字中含有尚的员工信息
select* from People where PeopleName like '%尚%'
--查询出名字中含有尚或者史的员工信息
select* from People where PeopleName like '%尚%' or PeopleName like '%史%'

--姓刘，名字是两个字  _有且仅有一个
select* from People where PeopleName like '刘_' 
select* from People where SUBSTRING(PeopleName,1,1) = '刘' and LEN(PeopleName) = 2
--select SUBSTRING('helko,world',3,1)--下标从1开始
--查询出名字最后一个字为香，名字一共是三个字的员工信息
select* from People where PeopleName like '__香 ' 
select* from People where SUBSTRING(PeopleName,3,1) = '香' and LEN(PeopleName) = 3
--电话号码开头为133的员工信息
select* from People where PeoplePhone like '133%'
select* from People where PeoplePhone like '133________'
--电话号码开头为133的员工信息,第四位好像是5或者4，最后一位是8
select* from People where PeoplePhone like '133[4,5]%[8]'
--133开头,第四位2-5之间的数据，最后一个数字不是2和3
select* from People where PeoplePhone like '133[2,3,4,5]%[^2,3]'
select* from People where PeoplePhone like '133[2-5]%[^2-3]'