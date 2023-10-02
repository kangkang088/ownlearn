--向部门表中插入数据
insert into Department(DepartmentName,DepartmentRemark)
values('市场部','......')
insert into Department(DepartmentName,DepartmentRemark)
values('软件部','......')
insert into Department(DepartmentName,DepartmentRemark)
values('企划部','......')
--简写 不推荐
insert into Department values('硬件部','......')
insert into Department values('材料部','......')
--一次性插入多行数据
insert into Department(DepartmentName,DepartmentRemark)
select '测试部','......'union
select '实施部','......'union
select '产品部','......'

--向职级表中插入数据------------------------------------------
insert into [Rank](RandName,RandRemark)
values('初级','......')
insert into [Rank](RandName,RandRemark)
values('中级','......')
insert into [Rank](RandName,RandRemark)
values('高级','......')

--向员工表中插入数据------------------------------------------
insert into People(DepartmentId,RankId,PeopleName,PeopleRemark,PeopleGender,PeopleBirth,PeopleSalary,PeoplePhone,PeopleAddress,PeopleAddTime)
values(8,1,'刘备','...','男','1988-8-8',500,'13888888888','中国',getdate())