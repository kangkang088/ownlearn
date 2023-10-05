--------------------------------选择分支结构--------------------------------------------
select* from BankCard
--(1)某用户银行卡号：6225547854125656
--该用户取钱，取钱5000元，余额充足则进行取钱操作，
--并提示‘取钱成功’,否则，提示‘金额不足’
declare @Balance money = (select CardMoney from BankCard where CardNo = '6225547854125656')
if 5000 < @Balance --可以取钱
	begin
	update BankCard set CardMoney = CardMoney - 5000 where CardNo = '6225547854125656'
	insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime) values('6225547854125656',0,5000,GETDATE())
	end
else--不可以取钱
	begin
	print '不能取钱，余额不足'
	end
select* from CardExchange

--(2)查询银行卡信息，将银行卡状态1，2，3，4分别转换为汉字 正常，挂失，冻结，注销
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
	else '无法识别的异常状态'
end 银行卡状态
from BankCard 
inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

-------------------------------循环结构（while）-----------------------------------------
--(1)循环打印1-10
declare @i int = 1
while @i <= 10
begin
	print @i
	set @i = @i + 1
end
go
--(2)循环打印乘法口诀表
--特殊字符：char(9):制表符 char(10):换行符
declare @i int = 1
declare @j int = 1
declare @sum int = 0
while @i <= 9
begin
	set @j = 1
	declare @str varchar(1000) = ''
	while @j <= @i
	begin
		set @sum = @i * @j 
		set @str = @str + CAST(@i as varchar(5)) + '*' + CAST(@j as varchar(5)) + '=' + CAST(@i * @j as varchar(5)) + CHAR(9)
		set @j = @j + 1
	end
	set @i = @i + 1
	print @str
end