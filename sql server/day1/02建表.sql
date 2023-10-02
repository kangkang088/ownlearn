--切换数据库
use DBTEST

--创建表的基本语法
--create table 表名
--(
--	字段名1 数据类型 
--	字段名2 数据类型 
--	字段名3 数据类型 
--)
if exists(select* from sys.objects where name = 'Department' and type = 'U')
drop table Department
--建表(部门，职级，员工)
create table Department
(
    --部门编号 设置主键 自动增长，初始值为1，增量为1
	DepartmentId int primary key identity(1,1),
	--部门名称 不能为空
	DepartmentName nvarchar(50) not null, 
	--部门描述
	DepartmentRemark text
)

--char：定长,char(10),里面可以存储10个字节，无论存储的数据是否真的到了10个字节，都要占用十个字节
--varchar:变长，varchar(10),最多占用10个字节
--text:长文本，几千几万字节  但对类型为text的数据进行查询的效率较低

--nchar,nvarcahr,ntext:存储Unicode字符，对中文友好
--varchar(100) :100个字母或50个汉字
--nvarchar(100) :100个字母或100个汉字
if exists(select* from sys.objects where name = 'Rank' and type = 'U')
drop table [Rank]
create table [Rank]
(
	RankId int primary key identity(1,1),
	RandName nvarchar(50) not null,
	RandRemark text
)
if exists(select* from sys.objects where name = 'People' and type = 'U')
drop table People
create table People
(
	PeopleId int primary key identity(1,1),--编号
	--部门(引用外键)
	DepartmentId int references Department(DepartmentId)not null,
	--职级(引用外键	)
	RankId int references [Rank](RankId)not null,
	PeopleName nvarchar(50) not null,--姓名
	PeopleRemark text,--自我介绍
	PeopleGender nvarchar(1) default('男') check(PeopleGender = '男' or PeopleGender = '女') not null,--性别--默认值为男，约束为男或女，不能为空
	PeopleBirth smalldatetime not null,--生日--最近的一段时间small，范围小于datetime，占用空间也小，效率高	
	PeopleSalary decimal(12,2) check(PeopleSalary >= 1000 and PeopleSalary <= 1000000) not null,--工资--小数点后面两位，总长度为12
	PeoplePhone varchar(20) unique not null,--电话--必须是唯一的 unique
	PeopleAddress varchar(300),--地址
	PeopleAddTime smalldatetime default(getdate())--入职时间--添加进入系统的时间 默认自动填入当前时间
)
--date 年月日
--datetime 年月日时分秒
