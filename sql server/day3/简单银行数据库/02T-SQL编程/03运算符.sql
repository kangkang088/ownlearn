--(1)��֪�����γ��Ϳ����ܳ������
declare @c int
set @c = 10
declare @k int = 5
declare @zc int = (@c + @k) * 2
declare @mj int = @c * @k
print 'Բ���ܳ���' + Convert(varchar(10),@zc)
print 'Բ�������' + Convert(varchar(10),@mj)
print 'Բ���ܳ���' + cast(@zc as varchar(10))
print 'Բ�������' + cast(@mj as varchar(10))

--(2)��ѯ�����п�״̬Ϊ���ᣬ��������1000000�����п���Ϣ
select* from BankCard where CardState = 3 and CardMoney > 1000000
--(3)��ѯ�����п�״̬Ϊ����������Ϊ0�����п���Ϣ
select* from BankCard where CardState = 3 or CardMoney = 0
--(4)��ѯ�������к��С��������˻���Ϣ�Լ����п���Ϣ
select* from AccountInfo inner join BankCard on BankCard.AccountId = AccountInfo.AccountId where RealName like '%��%'
--(5)�����2000-5000֮������п���Ϣ
select* from BankCard where CardMoney between 2000 and 5000
--(6)���п�״̬Ϊ�����ע�������п���Ϣ
select* from BankCard where CardState in(3,4)
--(7)�������֤��420107199507104133,���������п�����
--��ѯ���֤���˻����Ƿ����.�����ڣ�����п������������ڣ��򲻿���ֱ�ӿ���
select* from AccountInfo
select* from BankCard
declare @AccountId int
if EXISTS(select* from AccountInfo where AccountCode = '420107199507104133') --���ڴ���
	begin
	select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199507104133')
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end
else --�����ڴ���
	begin
	insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime) values('420107199507104133',13454788854,'����',GETDATE())
	set @AccountId = @@IDENTITY
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end
--��չ�������������һ�����ƣ���һ������࿪���ſ�
declare @AccountId int --�˻����
declare @CardCount int --�˻�����------------------------------------
if EXISTS(select* from AccountInfo where AccountCode = '420107199507104133') --���ڴ���
	begin
	select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199507104133')

	select @CardCount = (select COUNT(*) from BankCard where AccountId = @AccountId)--------------------------------
	if @CardCount <=2 
		begin
		insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741266',@AccountId,123456,0,1,GETDATE())
		end
	else
		begin
		print '�����µ����п����Ѿ�Ϊ3�ţ��޷�����������'
		end
	
	end
else --�����ڴ���
	begin
	insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime) values('420107199507104133',13454788854,'����',GETDATE())
	set @AccountId = @@IDENTITY
	insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState,CardTime) values('6225547858741264',@AccountId,123456,0,1,GETDATE())
	end

--(8)��ѯ���п��˻����ǲ������е��˻���������3000
if 3000 < ALL(select CardMoney from BankCard)--���ֱ�����ǰ��
	begin
	print '��'
	end
else
	begin
	print '����'
	end

--(8)��ѯ���п��˻����Ƿ����˻���������30000000
if 30000000 < Any(select CardMoney from BankCard)
	begin
	print '��'
	end
else
	begin
	print 'û��'
	end