--(1)��ʾ���ţ����֤�����������
--select CardNo ����,AccountCode ���֤,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

--������ͼ,ʵ����ʾ���ţ����֤�����������
create view View_Account_Card
as
select CardNo ����,AccountCode ���֤,RealName ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
go
 select* from View_Account_Card--����ÿ�β�ѯ��ͬ�����ݵ�ʱ���ظ���д��
--ɾ����ͼ
drop view View_Account_Card
