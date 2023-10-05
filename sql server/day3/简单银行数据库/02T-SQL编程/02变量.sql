--变量：局部变量和全局变量
--（1）局部变量：以@开头 先声明，再复制
declare @str varchar(20)
--set @str = 'hello,i like sql'
select @str = 'hello,i like sql'
print @str

--set和select赋值时候的区别
--set:赋值给变量指定的值
--select:通常用于从表里查询出一个数据并赋值给变量，如果查询结果有多条，取最后一条赋值给变量（可能也会报错）
--example：select @a = 字段名 from 表名
--@a的值：当前表的最后一行的某个字段的值


--（2）全局变量：以@@开头 系统进行定义和维护的，直接使用。 全部都是只读
--@@ERROR：返回执行的上一条语句的错误号
--@@INENTITY：返回最后插入的标识值
--@@MAX_CONNECTIONS：返回允许同时进行的最大用户数
--@@ROWCOUNT：返回受上一语句影响的行数
--@@SERVERNAME：返回运行 SQL Server 的本地服务器的名称
--@@SERVICENAME：返回SQL Server 正在其下运行的注册表项的名称
--@@TRANCOUNT：返回当前连接的活动事务数
--@@LOCK_TIMEOUT：返回当前会话的当前锁定超时位置（毫秒）

--示例
--(1)为赵云开户开卡 身份证：420107199904054233
insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime)
values('420107199904054233','13554785965','赵云',GETDATE())
declare @AccountId int
set @AccountId = @@IDENTITY
insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState)
values('6225125478544588',@AccountId,'123456',0,1)

select* from AccountInfo
select* from BankCard

--(2)求出张飞的银行卡卡号和余额，张飞身份证：420107199602034138
--方案一：连接查询
select CardNo 卡号,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
where AccountCode = ''

select* from AccountInfo
select* from BankCard
--方案二：
declare @AccountId int
select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199602034138')
select CardNo 卡号,CardMoney 余额 from BankCard where BankCard.AccountId = @AccountId

--(3)go 语句
--作用
--(1)等待go语句之前的代码执行完成之后，才能执行后面的代码
create database GOTEST--数据库还没建好呢，就执行下面的use了，会报错，在中间加个go，必须等待数据库建好了，才可以执行use
go
use GOTEST
create table AccountInfo --账户信息表
(
	AccountId int primary key identity(1,1),--账户编号
	AccountCode varchar(20) not null,--身份证号码
	AccountPhone varchar(20) not null,--电话号码
	RealName varchar(20) not null,--真实姓名
	OpenTime smalldatetime not null--开户时间
)
--(2)批处理结束标志
declare @num int --@num:作用范围(在我们执行的下面的代码里面)是全局的
set @num = 100
set @num = 200

go
declare @num1 int --@num:作用范围(两个go之间)是全局的
set @num1 = 100
go
set @num1 = 200 --这里报错，因为go可以作为批处理结束标志，说明@num1只作用到go，go下面就没了