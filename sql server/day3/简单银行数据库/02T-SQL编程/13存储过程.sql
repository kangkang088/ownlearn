--(1)没有输入参数，没有输出参数的存储过程
--定义存储过程实现查询出账户余额最高的银行卡账户信息，显示银行卡号，姓名，账户余额
--方案一：
create proc proc_MaxMoneyCard
as
select top 1 CardNo 银行卡卡号,RealName 姓名,CardMoney 账户余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId order by CardMoney desc
go --存在并列最高只能查一个的问题
--调用
exec proc_MaxMoneyCard
drop proc proc_MaxMoneyCard
go
--方案二：(多人并列时都可以查出来)
create proc proc_MaxMoneyCard
as
	select CardNo 银行卡卡号,RealName 姓名,CardMoney 账户余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId 
	where CardMoney = (select MAX(CardMoney) from BankCard)
go
exec proc_MaxMoneyCard
--(2)有输入参数，没有输出参数的存储过程，
--模拟银行卡存钱操作，传入银行卡号，存钱金额，实现存钱操作
go
create proc proc_SaveMoney
@CardNo varchar(30),
@Money money
as
	update BankCard set CardMoney = CardMoney + @Money where CardNo = @CardNo
	insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime)
	values(@CardNo,@Money,0,GETDATE())
go
select* from AccountInfo
select* from BankCard
select* from CardExchange
exec proc_SaveMoney '6225125478544587',1000
go
--(3)有输入参数，没有输出参数但是有返回值的存储过程(返回值必须为整数)
--模拟银行卡取钱操作，传入银行卡号，取钱金额，实现取钱操作
--取钱成功，返回1；失败，返回-1
create proc proc_GetMoney
@cardNo varchar(30),
@cardMoney money
as
	update BankCard set CardMoney = CardMoney - @cardMoney where CardNo = @cardNo
	if @@ERROR <> 0
	return -1
	insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime)
	values(@cardNo,0,@cardMoney,GETDATE())
	return 1
go

declare @returnValue int 
exec @returnValue = proc_GetMoney '6225125478544587',5000
select @returnValue
--(4)有输入参数，输出参数的存储过程
--查询出某段时间的银行存取款信息，以及存款总金额，取款总金额
--传入开始时间，结束时间，显示存取款信息的同时，返回存款总金额，取款总金额
go
create proc proc_SomeTimeCardExchangeInfo
@beginTime varchar(50),
@endTime varchar(50),
--output关键字：输出参数
@sumIn money output,--存款总金额
@sumOut money output--取款总金额
as
	select	@sumIn = (select SUM(MoneyInBank) from CardExchange where ExchangeTime between @beginTime + ' 00:00:00' and @endTime + ' 23:59:59')
	select	@sumOut = (select SUM(MoneyOutBank) from CardExchange where ExchangeTime between @beginTime + ' 00:00:00' and @endTime + ' 23:59:59')
	select* from CardExchange where ExchangeTime between @beginTime + ' 00:00:00' and @endTime + ' 23:59:59'
go
declare @in money
declare @out money
exec proc_SomeTimeCardExchangeInfo '2020-1-1','2025-1-1',@in output,@out output
select @in
select @out
--(5)具有同时输入输出参数的存储过程
--密码升级，传入卡号和密码，如果卡号和密码正确，并且密码长度<8,自动升级为8位密码,密码大于8不改
--rand() 0-1之间的小数 0.00001-0.99999之间 rand()*10 0.0001-9.9999之间 floor处理掉小数位，变成0-9之间(包0包9)
select FLOOR(RAND()*10) --[0,9]
go
create proc proc_PasswordUpgrade
@CardNumber nvarchar(20),--卡号
@Password nvarchar(20) output--密码（同时输入输出的参数）
as
	if not exists(select* from BankCard where CardNo = @CardNumber and CardPwd = @Password)
	 set @Password = ''
	else
	 begin
		if LEN(@Password) < 8
		begin
			declare @len int = 8 - LEN(@Password)
			declare @i int = 1
			while @i <= @len
			begin
				set @Password = @Password + CAST(FLOOR(RAND()*10) as varchar(1))
				set @i = @i + 1
			end
			update BankCard set CardPwd = @Password where CardNo = @CardNumber
		end
	 end
go

declare @pwd nvarchar(20) = '123456' --这里有赋值，说明是同时输入输出参数
exec proc_PasswordUpgrade '6225125478544587',@pwd output
select @pwd
select* from BankCard