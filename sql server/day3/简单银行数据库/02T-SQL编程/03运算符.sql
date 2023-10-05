--(1)已知长方形长和宽，求周长和面积
declare @c int
set @c = 10
declare @k int = 5
declare @zc int = (@c + @k) * 2
declare @mj int = @c * @k
print '圆的周长：' + Convert(varchar(10),@zc)
print '圆的面积：' + Convert(varchar(10),@mj)
print '圆的周长：' + cast(@zc as varchar(10))
print '圆的面积：' + cast(@mj as varchar(10))

--(2)查询出银行卡状态为冻结，并且余额超过1000000的银行卡信息
select* from BankCard where CardState = 3 and CardMoney > 1000000
--(3)查询出银行卡状态为冻结或者余额为0的银行卡信息
select* from BankCard where CardState = 3 or CardMoney = 0
--(4)查询出姓名中含有‘刘’的账户信息以及银行卡信息
select* from AccountInfo inner join BankCard on BankCard.AccountId = AccountInfo.AccountId where RealName like '%刘%'
--(5)余额在2000-5000之间的银行卡信息
select* from BankCard where CardMoney between 2000 and 5000
--(6)银行卡状态为冻结或注销的银行卡信息
select* from BankCard where CardState in(3,4)
--(7)关羽身份证：420107199507104133,关羽来银行开户，
--查询身份证在账户表是否存在.不存在，则进行开户开卡；存在，则不开户直接开卡
select* from AccountInfo
select* from BankCard
declare @AccountId int
if EXISTS(select* from AccountInfo where AccountCode = '420107199507104133') --存在此人
	begin
	select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199507104133')
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end
else --不存在此人
	begin
	insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime) values('420107199507104133',13454788854,'关羽',GETDATE())
	set @AccountId = @@IDENTITY
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end
--扩展：上面需求添加一个限制，即一个人最多开三张卡
declare @AccountId int --账户编号
declare @CardCount int --账户卡数------------------------------------
if EXISTS(select* from AccountInfo where AccountCode = '420107199507104133') --存在此人
	begin
	select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199507104133')

	select @CardCount = (select COUNT(*) from BankCard where AccountId = @AccountId)--------------------------------
	if @CardCount <=2 
		begin
		insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741266',@AccountId,123456,0,1,GETDATE())
		end
	else
		begin
		print '您名下的银行卡数已经为3张，无法继续开卡。'
		end
	
	end
else --不存在此人
	begin
	insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime) values('420107199507104133',13454788854,'关羽',GETDATE())
	set @AccountId = @@IDENTITY
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end

--(8)查询银行卡账户余额，是不是所有的账户余额都超过了3000
if 3000 < ALL(select CardMoney from BankCard)--数字必须在前面
	begin
	print '是'
	end
else
	begin
	print '不是'
	end

--(8)查询银行卡账户余额，是否含有账户的余额超过了30000000
if 30000000 < Any(select CardMoney from BankCard)
	begin
	print '有'
	end
else
	begin
	print '没有'
	end