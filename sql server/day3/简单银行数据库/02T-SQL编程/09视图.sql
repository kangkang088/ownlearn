--(1)显示卡号，身份证，姓名，余额
--select CardNo 卡号,AccountCode 身份证,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

--创建视图,实现显示卡号，身份证，姓名，余额
create view View_Account_Card
as
select CardNo 卡号,AccountCode 身份证,RealName 姓名,CardMoney 余额 from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
go
 select* from View_Account_Card--不用每次查询相同的内容的时候重复编写了
--删除视图
drop view View_Account_Card
