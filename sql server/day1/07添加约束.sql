use DBTEST
--alter table ���� add constraint Լ���� check(���ʽ)
alter table People add constraint CK_People_PeoPleSa check(PeopleSalary > 0 and PeopleSalary < 1000)