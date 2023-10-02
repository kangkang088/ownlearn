use DBTEST
--alter table 表名 add constraint 约束名 check(表达式)
alter table People add constraint CK_People_PeoPleSa check(PeopleSalary > 0 and PeopleSalary < 1000)