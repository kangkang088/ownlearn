--(1)û�����������û����������Ĵ洢����
--����洢����ʵ�ֲ�ѯ���˻������ߵ����п��˻���Ϣ����ʾ���п��ţ��������˻����
--����һ��
create proc proc_MaxMoneyCard
as
select top 1 CardNo ���п�����,RealName ����,CardMoney �˻���� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId order by CardMoney desc
go --���ڲ������ֻ�ܲ�һ��������
--����
exec proc_MaxMoneyCard
drop proc proc_MaxMoneyCard
go
--��������(���˲���ʱ�����Բ����)
create proc proc_MaxMoneyCard
as
	select CardNo ���п�����,RealName ����,CardMoney �˻���� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId 
	where CardMoney = (select MAX(CardMoney) from BankCard)
go
exec proc_MaxMoneyCard
--(2)�����������û����������Ĵ洢���̣�
--ģ�����п���Ǯ�������������п��ţ���Ǯ��ʵ�ִ�Ǯ����
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
--(3)�����������û��������������з���ֵ�Ĵ洢����(����ֵ����Ϊ����)
--ģ�����п�ȡǮ�������������п��ţ�ȡǮ��ʵ��ȡǮ����
--ȡǮ�ɹ�������1��ʧ�ܣ�����-1
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
--(4)�������������������Ĵ洢����
--��ѯ��ĳ��ʱ������д�ȡ����Ϣ���Լ�����ܽ�ȡ���ܽ��
--���뿪ʼʱ�䣬����ʱ�䣬��ʾ��ȡ����Ϣ��ͬʱ�����ش���ܽ�ȡ���ܽ��
go
create proc proc_SomeTimeCardExchangeInfo
@beginTime varchar(50),
@endTime varchar(50),
--output�ؼ��֣��������
@sumIn money output,--����ܽ��
@sumOut money output--ȡ���ܽ��
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
--(5)����ͬʱ������������Ĵ洢����
--�������������뿨�ź����룬������ź�������ȷ���������볤��<8,�Զ�����Ϊ8λ����,�������8����
--rand() 0-1֮���С�� 0.00001-0.99999֮�� rand()*10 0.0001-9.9999֮�� floor�����С��λ�����0-9֮��(��0��9)
select FLOOR(RAND()*10) --[0,9]
go
create proc proc_PasswordUpgrade
@CardNumber nvarchar(20),--����
@Password nvarchar(20) output--���루ͬʱ��������Ĳ�����
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

declare @pwd nvarchar(20) = '123456' --�����и�ֵ��˵����ͬʱ�����������
exec proc_PasswordUpgrade '6225125478544587',@pwd output
select @pwd
select* from BankCard