--(1)编写一个函数求该银行的金额总和(没有参数，返回标量值)
--select SUM(CardMoney) from BankCard

create function GetSumMoney() returns money
as 
begin
	declare @sum money
	select @sum = (select SUM(CardMoney) from BankCard)
	return @sum
end
go
--函数调用
select dbo.GetSumMoney()
go


--(2)传入账户编号，返沪账户真实姓名
create function GetRealNameById(@accId int) returns varchar(30)
as
begin
	declare @name varchar(30)
	select @name = (select RealName from AccountInfo where AccountId = @accId)
	return @name
end
go

select dbo.GetRealNameById(2)
go

--(3)传递开始时间和结束时间,返回交易记录(存钱和取钱)
--交易记录中包含真实姓名，卡号，存钱金额，取钱金额，交易时间

--drop function GetRecordByTime
--方案一：规定返回结果数据列的结构 (函数体内可以处理复杂逻辑,除了处理sql查询之外，还可以有其他的代码)
create function GetRecordByTime(@start varchar(30),@end varchar(30)) 
returns @result table 
(
	RealName varchar(20),--真实姓名
	CardNo varchar(30),--银行卡卡号
	MoneyInBank money,--存钱金额
	MoneyOutBank money,--取钱金额
	ExchangeTime smalldatetime --交易时间
)
as 
begin
	insert into @result 
	select RealName 姓名,CardExchange.CardNo 卡号,MoneyInBank 存钱金额,MoneyOutBank 取钱金额,ExchangeTime 交易时间 from CardExchange 
	inner join BankCard on BankCard.CardNo = CardExchange.CardNo
	inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
	where ExchangeTime between @start + ' 00:00:00' and @end + ' 23:59:59'
	return
end
go
select* from GetRecordByTime('1999-1-1','2023-12-12') --标量函数调用前加dbo，表值函数可加可不加，返回的是表
go

--方案二：不规定返回结果数据列的结构 (函数体内只能有return + sql查询结果)
create function GetRecordByTime1(@start varchar(30),@end varchar(30)) 
returns table 
as 
	return 
	select RealName 姓名,CardExchange.CardNo 卡号,MoneyInBank 存钱金额,MoneyOutBank 取钱金额,ExchangeTime 交易时间 from CardExchange 
	inner join BankCard on BankCard.CardNo = CardExchange.CardNo
	inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
	where ExchangeTime between @start + ' 00:00:00' and @end + ' 23:59:59'
go
select* from GetRecordByTime1('1999-1-1','2023-12-12')

--(4)查询银行卡信息，将银行卡状态1，2，3，4分别转换为汉字 正常，挂失，冻结，注销
--并根据银行卡余额显示银行卡等级
--30万以下为普通用户，30万及以上为vip用户
--显示列分别为卡号，身份证，姓名，余额，用户等级，银行卡状态
select CardNo 卡号,AccountCode 身份证,RealName 姓名,CardMoney 余额,
case
	when CardMoney >= 300000 then 'vip用户'
	else '普通用户'
end 用户等级,
case CardState
	when 1 then '正常'
	when 2 then '挂失'
	when 3 then '冻结'
	when 4 then '注销'
end 银行卡状态
from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
go

--用户等级函数
create function GetGrade(@cardMoney money) returns varchar(50)
as
begin
	declare @result varchar(50)
	if @cardMoney >= 300000
		set @result = 'vip用户'
	else
		set @result = '普通用户'
	return @result
end
go
--求银行卡状态的函数
create function GetState(@cardstate int) returns varchar(30)
as
begin
	declare @result varchar(30)
	if @cardstate = 1
		set @result = '正常'
	else if @cardstate = 2
		set @result = '挂失'
	else if @cardstate = 3
		set @result = '冻结'
	else if @cardstate = 4
		set @result = '注销'
	else
		set @result = '异常'
	return @result
end
go
select CardNo 卡号,AccountCode 身份证,RealName 姓名,CardMoney 余额,dbo.GetGrade(BankCard.CardMoney) 用户等级,dbo.GetState(BankCard.CardState) 银行卡状态
from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

--（5）编写函数，根据出生日期求出年龄,年龄为实岁，例如
--2000-05-05 - 2018-05-04：17岁
--2000-05-05 - 2018-05-06：18岁
create table Emp
(
	EmpId int primary key identity(1,2),
	EmpName varchar(20),
	EmpSex varchar(4),
	EmpBirth smalldatetime

)
insert into Emp(EmpName,EmpSex,EmpBirth) values('刘备','男','2008-5-8')
insert into Emp(EmpName,EmpSex,EmpBirth) values('关羽','男','1998-10-10')
insert into Emp(EmpName,EmpSex,EmpBirth) values('张飞','男','1999-7-5')
insert into Emp(EmpName,EmpSex,EmpBirth) values('赵云','男','2003-12-12')
insert into Emp(EmpName,EmpSex,EmpBirth) values('马超','男','2003-1-5')
insert into Emp(EmpName,EmpSex,EmpBirth) values('黄忠','男','1988-8-4')
insert into Emp(EmpName,EmpSex,EmpBirth) values('魏延','男','1998-5-2')
insert into Emp(EmpName,EmpSex,EmpBirth) values('简雍','男','1992-2-20')
insert into Emp(EmpName,EmpSex,EmpBirth) values('诸葛亮','男','1993-3-1')
insert into Emp(EmpName,EmpSex,EmpBirth) values('徐庶','男','1994-8-5')

select*, DATEDIFF(YEAR,EmpBirth,GETDATE()) 年龄 from Emp
go

create function GetAge(@birth smalldatetime) returns int
as
begin
	declare @age int
	set @age = YEAR(GETDATE()) - YEAR(@birth)
	if MONTH(GETDATE()) < MONTH(@birth)
		set @age = @age - 1
	if MONTH(GETDATE()) = MONTH(@birth) and DAY(GETDATE()) < DAY(@age)
		set @age = @age - 1
	return @age
end
go

select*, dbo.GetAge(Emp.EmpBirth) 年龄 from Emp
select*, DATEDIFF(YEAR,EmpBirth,GETDATE()) 年龄 from Emp