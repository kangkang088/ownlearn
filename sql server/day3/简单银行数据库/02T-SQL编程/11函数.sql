--(1)��дһ������������еĽ���ܺ�(û�в��������ر���ֵ)
--select SUM(CardMoney) from BankCard

create function GetSumMoney() returns money
as 
begin
	declare @sum money
	select @sum = (select SUM(CardMoney) from BankCard)
	return @sum
end
go
--��������
select dbo.GetSumMoney()
go


--(2)�����˻���ţ������˻���ʵ����
create function GetRealNameById(@accId int) returns varchar(30)
as
begin
	declare @name varchar(30)
	select @name = (select RealName from AccountInfo where AccountId = @accId)
	return @name
end
go

select dbo.GetRealNameById(2)
go

--(3)���ݿ�ʼʱ��ͽ���ʱ��,���ؽ��׼�¼(��Ǯ��ȡǮ)
--���׼�¼�а�����ʵ���������ţ���Ǯ��ȡǮ������ʱ��

--drop function GetRecordByTime
--����һ���涨���ؽ�������еĽṹ (�������ڿ��Դ������߼�,���˴���sql��ѯ֮�⣬�������������Ĵ���)
create function GetRecordByTime(@start varchar(30),@end varchar(30)) 
returns @result table 
(
	RealName varchar(20),--��ʵ����
	CardNo varchar(30),--���п�����
	MoneyInBank money,--��Ǯ���
	MoneyOutBank money,--ȡǮ���
	ExchangeTime smalldatetime --����ʱ��
)
as 
begin
	insert into @result 
	select RealName ����,CardExchange.CardNo ����,MoneyInBank ��Ǯ���,MoneyOutBank ȡǮ���,ExchangeTime ����ʱ�� from CardExchange 
	inner join BankCard on BankCard.CardNo = CardExchange.CardNo
	inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
	where ExchangeTime between @start + ' 00:00:00' and @end + ' 23:59:59'
	return
end
go
select* from GetRecordByTime('1999-1-1','2023-12-12') --������������ǰ��dbo����ֵ�����ɼӿɲ��ӣ����ص��Ǳ�
go

--�����������涨���ؽ�������еĽṹ (��������ֻ����return + sql��ѯ���)
create function GetRecordByTime1(@start varchar(30),@end varchar(30)) 
returns table 
as 
	return 
	select RealName ����,CardExchange.CardNo ����,MoneyInBank ��Ǯ���,MoneyOutBank ȡǮ���,ExchangeTime ����ʱ�� from CardExchange 
	inner join BankCard on BankCard.CardNo = CardExchange.CardNo
	inner join AccountInfo on AccountInfo.AccountId = BankCard.AccountId
	where ExchangeTime between @start + ' 00:00:00' and @end + ' 23:59:59'
go
select* from GetRecordByTime1('1999-1-1','2023-12-12')

--(4)��ѯ���п���Ϣ�������п�״̬1��2��3��4�ֱ�ת��Ϊ���� ��������ʧ�����ᣬע��
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
end ���п�״̬
from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
go

--�û��ȼ�����
create function GetGrade(@cardMoney money) returns varchar(50)
as
begin
	declare @result varchar(50)
	if @cardMoney >= 300000
		set @result = 'vip�û�'
	else
		set @result = '��ͨ�û�'
	return @result
end
go
--�����п�״̬�ĺ���
create function GetState(@cardstate int) returns varchar(30)
as
begin
	declare @result varchar(30)
	if @cardstate = 1
		set @result = '����'
	else if @cardstate = 2
		set @result = '��ʧ'
	else if @cardstate = 3
		set @result = '����'
	else if @cardstate = 4
		set @result = 'ע��'
	else
		set @result = '�쳣'
	return @result
end
go
select CardNo ����,AccountCode ���֤,RealName ����,CardMoney ���,dbo.GetGrade(BankCard.CardMoney) �û��ȼ�,dbo.GetState(BankCard.CardState) ���п�״̬
from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId

--��5����д���������ݳ��������������,����Ϊʵ�꣬����
--2000-05-05 - 2018-05-04��17��
--2000-05-05 - 2018-05-06��18��
create table Emp
(
	EmpId int primary key identity(1,2),
	EmpName varchar(20),
	EmpSex varchar(4),
	EmpBirth smalldatetime

)
insert into Emp(EmpName,EmpSex,EmpBirth) values('����','��','2008-5-8')
insert into Emp(EmpName,EmpSex,EmpBirth) values('����','��','1998-10-10')
insert into Emp(EmpName,EmpSex,EmpBirth) values('�ŷ�','��','1999-7-5')
insert into Emp(EmpName,EmpSex,EmpBirth) values('����','��','2003-12-12')
insert into Emp(EmpName,EmpSex,EmpBirth) values('��','��','2003-1-5')
insert into Emp(EmpName,EmpSex,EmpBirth) values('����','��','1988-8-4')
insert into Emp(EmpName,EmpSex,EmpBirth) values('κ��','��','1998-5-2')
insert into Emp(EmpName,EmpSex,EmpBirth) values('��Ӻ','��','1992-2-20')
insert into Emp(EmpName,EmpSex,EmpBirth) values('�����','��','1993-3-1')
insert into Emp(EmpName,EmpSex,EmpBirth) values('����','��','1994-8-5')

select*, DATEDIFF(YEAR,EmpBirth,GETDATE()) ���� from Emp
go

create function GetAge(@birth smalldatetime) returns int
as
begin
	declare @age int
	set @age = YEAR(GETDATE()) - YEAR(@birth)
	if MONTH(GETDATE()) < MONTH(@birth)
		set @age = @age - 1
	if MONTH(GETDATE()) = MONTH(@birth) and DAY(GETDATE()) < DAY(@age)
		set @age = @age - 1
	return @age
end
go

select*, dbo.GetAge(Emp.EmpBirth) ���� from Emp
select*, DATEDIFF(YEAR,EmpBirth,GETDATE()) ���� from Emp