select* from BankCard
select* from AccountInfo
--(1)��������п�����Ϊ 6225547858741263
--��ѯ�����ȹ��������п���Ϣ����ʾ���ţ����֤�ţ����������
--����һ��
declare @Balance money
select @Balance = (select CardMoney from BankCard where CardNo = '6225547858741263')
select CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId where CardMoney > @Balance
--��������
--�Ӳ�ѯ
select CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId where CardMoney > (select CardMoney from BankCard where CardNo = '6225547858741263')

--(2)�������˻���Ϣ�в�ѯ�������ߵĽ�����ϸ����Ǯ��ȡǮ��Ϣ��
--����ж�������һ�����Ҷ�����ߣ������ѯֻ�ܲ��һ��
select* from CardExchange where CardNo = (select top 1 CardNo from BankCard order by CardMoney desc)
--����ж�������һ�����Ҷ�����ߣ���Ҫ�������
select* from CardExchange where CardNo in (
select CardNo from BankCard where CardMoney = (select MAX(CardMoney) from BankCard)
)

--(3)��ѯ����ȡ���¼�����п����˻�����Ϣ,��ʾ���ţ����֤�����������
select CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
where CardNo in (select CardNo from CardExchange where MoneyOutBank > 0)

--(4)��ѯ��û�д���¼�����п����˻�����Ϣ,��ʾ���ţ����֤�����������
select CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId 
where CardNo not in (select CardNo from CardExchange where MoneyInBank > 0)

--(5)��������п���Ϊ 6225547858741263 ,��ѯ�����Ƿ����յ�ת��
select* from CardTransfer
if exists(select* from CardTransfer where CardNoIn = '6225547858741263' and CONVERT(varchar(22),GETDATE(),23) = CONVERT(varchar(22),TransferTime,23))
	begin
	print '���յ�ת��'
	end
else
	begin
	print 'û���յ�ת��'
	end

--(6)���״����������п��˻���Ϣ��
--��ʾ�����ţ����֤�����������
--����һ��ͬ���п���ͬʱ���ڽ��״���һ����Ϊ�����˻�������
select top 1 BankCard.CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ���,Temp.myCount ���״��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
inner join
--��һ����ʱ������ΪTemp
(select CardNo,COUNT(*) myCount from CardExchange group by CardNo) Temp
on BankCard.CardNo = Temp.CardNo
order by Temp.myCount desc

--��������
select BankCard.CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ���,Temp.myCount ���״��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
inner join
--��һ����ʱ������ΪTemp
(select CardNo,COUNT(*) myCount from CardExchange group by CardNo) Temp
on BankCard.CardNo = Temp.CardNo
where Temp.myCount = 
(
select MAX(Temp.myCount) from (select CardNo,COUNT(*) myCount from CardExchange group by CardNo)Temp
)

--(7)��ѯ��û��ת�˼�¼�����п����˻�����Ϣ,��ʾ���ţ����֤�����������
select CardNo ����,AccountCode ���֤��,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId 
where CardNo not in (select CardNoOut from CardTransfer)
and
CardNo not in (select CardNoIn from CardTransfer)

select* from CardTransfer
