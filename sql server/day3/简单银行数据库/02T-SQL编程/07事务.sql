select* from AccountInfo
select* from BankCard
--���� ���֤ 420107198905064135 ���п����� 6225125478544587
--���� ���֤ 420107199507104133 ���п����� 6225547858741263
--�ŷ� ���֤ 420107199602034138 ���п����� 6225547854125656

----------------------------------------------����-------------------------------------------------
--��������һ��Լ��
alter table BankCard add constraint ck_money check(CardMoney >= 0)
--��������д���������񣬻�������ݴ��ң���������ֻ��1000��ȡ������6000����Լ��>=0��ͻ�����Ե�һ��ִ��ʧ�ܣ����ǵڶ�����ִ�гɹ�������ȡ�����������ǽ��ױ�����������ȡ��6000�����ݣ����ݻ����ˡ�
update BankCard set CardMoney = CardMoney - 6000 where CardNo = '6225125478544587'
insert into CardExchange(CardNo,MoneyInBank,ExchangeTime) values('6225125478544587',0,6000,GETDATE())
--�޸�
--ʹ������  @@ERROR ���ִ�е�����д��󣬷��ش�����Ϣ�ı�ţ�û�д���Ϊ0 
--ÿִ��һ�д��룬�ۼ�һ��@@ERROR��ֵ
--ֻҪ����0��˵���д��󣬻ع�,�ص���ȥ��״̬
--����0���ύ����
begin transaction
declare @myError int = 0
update BankCard set CardMoney = CardMoney - 6000 where CardNo = '6225125478544587'
set @myError = @myError + @@ERROR
insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime) values('6225125478544587',0,6000,GETDATE())
set @myError = @myError + @@ERROR
if @myError =0
	begin
	commit transaction
	print 'ȡ��ɹ�'
	end
else
	begin
	rollback transaction
	print 'ȡ��ʧ��'
	end

select* from BankCard--Ǯû��
select* from CardExchange--���׼�¼û�������
go

--(2)�������ŷ�ת��1000Ԫ
--1.�ŷ����1000Ԫ 2.��������1000Ԫ 3.����ת�˼�¼
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
	print 'ת�˳ɹ�'
	end
else
	begin
	rollback transaction
	print 'ת��ʧ��'
	end
select* from BankCard--Ǯ��
select* from CardTransfer--���׼�¼�������
go