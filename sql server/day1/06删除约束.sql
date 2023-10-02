use DBTEST
--维护约束（删除，添加）
--1.删除约束
--alter table 表名 drop constraint 约束名
--删除工资的约束
alter table People drop constraint CK__People__PeopleSa__7A672E12