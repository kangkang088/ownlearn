--------------------------------ѡ���֧�ṹ--------------------------------------------
select* from BankCard
--(1)ĳ�û����п��ţ�6225547854125656
--���û�ȡǮ��ȡǮ5000Ԫ�������������ȡǮ������
--����ʾ��ȡǮ�ɹ���,������ʾ�����㡯
declare @Balance money = (select CardMoney from BankCard where CardNo = '6225547854125656')
if 5000 < @Balance --����ȡǮ
	begin
	update BankCard set CardMoney = CardMoney - 5000 where CardNo = '6225547854125656'
	insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime) values('6225547854125656',0,5000,GETDATE())
	end
else--������ȡǮ
	begin
	print '����ȡǮ������'
	end
select* from CardExchange

--(2)��ѯ���п���Ϣ�������п�״̬1��2��3��4�ֱ�ת��Ϊ���� ��������ʧ�����ᣬע��
--���������п������ʾ���п��ȼ�
--30������Ϊ��ͨ�û���30������Ϊvip�û�
--��ʾ�зֱ�Ϊ���ţ����֤�����������û��ȼ������п�״̬
select CardNo ����,AccountCode ���֤,RealName ����,CardMoney ���,
case
	when CardMoney >= 300000 then 'vip�û�'
	else '��ͨ�û�'
end �û��ȼ�,
case CardState
	when 1 then '����'
	when 2 then '��ʧ'
	when 3 then '����'
	when 4 then 'ע��'
	else '�޷�ʶ����쳣״̬'
end ���п�״̬
from BankCard 
inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

-------------------------------ѭ���ṹ��while��-----------------------------------------
--(1)ѭ����ӡ1-10
declare @i int = 1
while @i <= 10
begin
	print @i
	set @i = @i + 1
end
go
--(2)ѭ����ӡ�˷��ھ���
--�����ַ���char(9):�Ʊ�� char(10):���з�
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