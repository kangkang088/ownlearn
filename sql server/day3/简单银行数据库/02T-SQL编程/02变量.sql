--�������ֲ�������ȫ�ֱ���
--��1���ֲ���������@��ͷ ���������ٸ���
declare @str varchar(20)
--set @str = 'hello,i like sql'
select @str = 'hello,i like sql'
print @str

--set��select��ֵʱ�������
--set:��ֵ������ָ����ֵ
--select:ͨ�����ڴӱ����ѯ��һ�����ݲ���ֵ�������������ѯ����ж�����ȡ���һ����ֵ������������Ҳ�ᱨ��
--example��select @a = �ֶ��� from ����
--@a��ֵ����ǰ������һ�е�ĳ���ֶε�ֵ


--��2��ȫ�ֱ�������@@��ͷ ϵͳ���ж����ά���ģ�ֱ��ʹ�á� ȫ������ֻ��
--@@ERROR������ִ�е���һ�����Ĵ����
--@@INENTITY������������ı�ʶֵ
--@@MAX_CONNECTIONS����������ͬʱ���е�����û���
--@@ROWCOUNT����������һ���Ӱ�������
--@@SERVERNAME���������� SQL Server �ı��ط�����������
--@@SERVICENAME������SQL Server �����������е�ע����������
--@@TRANCOUNT�����ص�ǰ���ӵĻ������
--@@LOCK_TIMEOUT�����ص�ǰ�Ự�ĵ�ǰ������ʱλ�ã����룩

--ʾ��
--(1)Ϊ���ƿ������� ���֤��420107199904054233
insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime)
values('420107199904054233','13554785965','����',GETDATE())
declare @AccountId int
set @AccountId = @@IDENTITY
insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState)
values('6225125478544588',@AccountId,'123456',0,1)

select* from AccountInfo
select* from BankCard

--(2)����ŷɵ����п����ź����ŷ����֤��420107199602034138
--����һ�����Ӳ�ѯ
select CardNo ����,CardMoney ��� from BankCard inner join AccountInfo on BankCard.AccountId = AccountInfo.AccountId
where AccountCode = ''

select* from AccountInfo
select* from BankCard
--��������
declare @AccountId int
select @AccountId = (select AccountId from AccountInfo where AccountCode = '420107199602034138')
select CardNo ����,CardMoney ��� from BankCard where BankCard.AccountId = @AccountId

--(3)go ���
--����
--(1)�ȴ�go���֮ǰ�Ĵ���ִ�����֮�󣬲���ִ�к���Ĵ���
create database GOTEST--���ݿ⻹û�����أ���ִ�������use�ˣ��ᱨ�����м�Ӹ�go������ȴ����ݿ⽨���ˣ��ſ���ִ��use
go
use GOTEST
create table AccountInfo --�˻���Ϣ��
(
	AccountId int primary key identity(1,1),--�˻����
	AccountCode varchar(20) not null,--���֤����
	AccountPhone varchar(20) not null,--�绰����
	RealName varchar(20) not null,--��ʵ����
	OpenTime smalldatetime not null--����ʱ��
)
--(2)�����������־
declare @num int --@num:���÷�Χ(������ִ�е�����Ĵ�������)��ȫ�ֵ�
set @num = 100
set @num = 200

go
declare @num1 int --@num:���÷�Χ(����go֮��)��ȫ�ֵ�
set @num1 = 100
go
set @num1 = 200 --���ﱨ����Ϊgo������Ϊ�����������־��˵��@num1ֻ���õ�go��go�����û��