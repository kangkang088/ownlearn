select* from BankCard
select* from AccountInfo
--(1)关羽的银行卡卡号为 6225547858741263
--查询出余额比关羽多的银行卡信息，显示卡号，身份证号，姓名，余额
--方案一：
declare @Balance money
select @Balance = (select CardMoney from BankCard where CardNo = '6225547858741263')
select CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId where CardMoney > @Balance
--方案二：
--子查询
select CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId where CardMoney > (select CardMoney from BankCard where CardNo = '6225547858741263')

--(2)从所有账户信息中查询出余额最高的交易明细（存钱和取钱信息）
--如果有多个人余额一样并且都是最高，下面查询只能查出一个
select* from CardExchange where CardNo = (select top 1 CardNo from BankCard order by CardMoney desc)
--如果有多个人余额一样并且都是最高，需要都查出来
select* from CardExchange where CardNo in (
select CardNo from BankCard where CardMoney = (select MAX(CardMoney) from BankCard)
)

--(3)查询出有取款记录的银行卡及账户的信息,显示卡号，身份证，姓名，余额
select CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
where CardNo in (select CardNo from CardExchange where MoneyOutBank > 0)

--(4)查询出没有存款记录的银行卡及账户的信息,显示卡号，身份证，姓名，余额
select CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId 
where CardNo not in (select CardNo from CardExchange where MoneyInBank > 0)

--(5)关羽的银行卡号为 6225547858741263 ,查询当天是否有收到转账
select* from CardTransfer
if exists(select* from CardTransfer where CardNoIn = '6225547858741263' and CONVERT(varchar(22),GETDATE(),23) = CONVERT(varchar(22),TransferTime,23))
	begin
	print '有收到转账'
	end
else
	begin
	print '没有收到转账'
	end

--(6)交易次数最多的银行卡账户信息，
--显示：卡号，身份证，姓名，余额
--方案一：同样有可能同时存在交易次数一样且为最多的账户的问题
select top 1 BankCard.CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额,Temp.myCount 交易次数 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
inner join
--做一个临时表，起名为Temp
(select CardNo,COUNT(*) myCount from CardExchange group by CardNo) Temp
on BankCard.CardNo = Temp.CardNo
order by Temp.myCount desc

--方案二：
select BankCard.CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额,Temp.myCount 交易次数 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
inner join
--做一个临时表，起名为Temp
(select CardNo,COUNT(*) myCount from CardExchange group by CardNo) Temp
on BankCard.CardNo = Temp.CardNo
where Temp.myCount = 
(
select MAX(Temp.myCount) from (select CardNo,COUNT(*) myCount from CardExchange group by CardNo)Temp
)

--(7)查询出没有转账记录的银行卡及账户的信息,显示卡号，身份证，姓名，余额
select CardNo 卡号,AccountCode 身份证号,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId 
where CardNo not in (select CardNoOut from CardTransfer)
and
CardNo not in (select CardNoIn from CardTransfer)

select* from CardTransfer
