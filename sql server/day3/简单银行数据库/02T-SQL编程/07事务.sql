select* from AccountInfo
select* from BankCard
--刘备 身份证 420107198905064135 银行卡卡号 6225125478544587
--关羽 身份证 420107199507104133 银行卡卡号 6225547858741263
--张飞 身份证 420107199602034138 银行卡卡号 6225547854125656

----------------------------------------------事务-------------------------------------------------
--给余额添加一个约束
alter table BankCard add constraint ck_money check(CardMoney >= 0)
--下面这样写，不用事务，会造成数据错乱，刘备卡里只有1000，取不出来6000，跟约束>=0冲突，所以第一条执行失败，但是第二条会执行成功。刘备取不出来，但是交易表里又有刘备取了6000的数据，数据混乱了。
update BankCard set CardMoney = CardMoney - 6000 where CardNo = '6225125478544587'
insert into CardExchange(CardNo,MoneyInBank,ExchangeTime) values('6225125478544587',0,6000,GETDATE())
--修改
--使用事务  @@ERROR 如果执行的语句有错误，返回错误信息的编号，没有错误，为0 
--每执行一行代码，累加一次@@ERROR的值
--只要大于0，说明有错误，回滚,回到过去的状态
--等于0，提交事务
begin transaction
declare @myError int = 0
update BankCard set CardMoney = CardMoney - 6000 where CardNo = '6225125478544587'
set @myError = @myError + @@ERROR
insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime) values('6225125478544587',0,6000,GETDATE())
set @myError = @myError + @@ERROR
if @myError =0
	begin
	commit transaction
	print '取款成功'
	end
else
	begin
	rollback transaction
	print '取款失败'
	end

select* from BankCard--钱没变
select* from CardExchange--交易记录没有新添加
go

--(2)刘备向张飞转账1000元
--1.张飞添加1000元 2.刘备减少1000元 3.生成转账记录
begin transaction
declare @myError int = 0
update BankCard set CardMoney = CardMoney + 1000 where CardNo = '6225547854125656'
set @myError = @myError + @@ERROR
update BankCard set CardMoney = CardMoney - 1000 where CardNo = '6225125478544587'
set @myError = @myError + @@ERROR
insert into CardTransfer(CardNoOut,CardNoIn,TransferMoney,TransferTime) values('6225125478544587','6225547854125656',1000,GETDATE())
set @myError = @myError + @@ERROR
if @myError = 0
	begin
	commit transaction
	print '转账成功'
	end
else
	begin
	rollback transaction
	print '转账失败'
	end
select* from BankCard--钱变
select* from CardTransfer--交易记录有新添加
go