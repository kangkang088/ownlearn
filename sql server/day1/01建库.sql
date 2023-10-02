if exists(select *from sys.databases where name = 'DBTEST') 
drop database DBTEST
--创建数据库
create database DBTEST
on --数据文件
(
	name = 'DBTEST',--逻辑名称，一般和数据库名称一样
	filename = 'E:\DATA\DBTEST.mdf',--物理路径和名称
	size = 5MB,--初始大小
	filegrowth = 2MB --数据增长方式，也可以写百分比
)
log on -- 日志文件
(
	name = 'DBTEST_log',--逻辑名称，一般和数据库名称一样
	filename = 'E:\DATA\DBTEST_log.ldf',--物理路径和名称
	size = 5MB,--初始大小
	filegrowth = 2MB--数据增长方式，也可以写百分比
)

--简写
create database DBTEST1