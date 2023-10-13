use DBWORK1
--��Ա��Ϣ��
create table SalesMan
(
	SalesmanID int identity(1,1) primary key,   --���
	SalesmanName nvarchar(50) not null,         --Ա������
	Mobile nvarchar(20) not null unique,        --Ա���绰���û�����
	Pwd nvarchar(20) not null,                  --����
	Gender nvarchar(2) not null check(Gender in ('��','Ů')),   --�Ա�
	Wage decimal(8,2) not null,                 --��������
	CommissionRate decimal(4,2) not null,       --��ɱ���
	[Role] nvarchar(20) not null check([Role] in ('�곤','����Ա','����Ա')) --��ɫ
)
--��Ʒ���ͱ�
create table [Type]
(
	TypeID int identity(1,1) primary key,   --���
	TypeName nvarchar(50) not null,  --�������
)
--��Ʒ��Ϣ��
create table Goods
(
	GoodsID int identity(1,1) primary key,  --���
	BarCode nvarchar(20) not null unique,   --����
	TypeID int not null,                    --���ͱ�ţ���[Type]��TypeID�γ��������ϵ
	GoodsName nvarchar(50) not null,        --��Ʒ����
	StorePrice decimal(8,2) not null,       --�����۸�
	SalePrice decimal(8,2) not null,        --���ۼ۸�
	Discount decimal(4,2) not null default(1),  --�ۿ�
	StockNum int not null,                   --�������
	StockDate datetime not null default(getdate())  --���ʱ��
)
select* from Goods
--�����˵���
create table Sales
(
	SalesID int identity(1,1) primary key,  --�˵����
	ReceiptsCode nvarchar(50) not null unique,  --�˵���ˮ��
	SalesDate date not null default(getdate()),  --����ʱ��
	AllMoney decimal(8,2) not null,              --�����ܼ�
	SalesmanID int not null,                     --����Ա���
	CashierID int not null,                      --����Ա���
)
--�����˵���ϸ��
create table SalesDetail
(
	SDID int identity(1,1) primary key,   --���
	SalesID int not null,                 --�˵���ţ���Sales��SalesID�������ϵ��
	GoodsID int not null,                 --��Ʒ���
	Quantity int not null,                --����
	GoodsMoney decimal(8,2) not null      --���ۼ۸�
)

--��ʼ����Ա��Ϣ
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('���׷�','13554787653','123456','��',6000,0.1,'�곤')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('������','13435465678','123456','Ů',5000,0.1,'����Ա')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('��־��','13365767890','123456','Ů',3000,0.3,'����Ա')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('������','13777886765','123456','Ů',3000,0.3,'����Ա')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('������','13665656666','123456','Ů',3000,0.3,'����Ա')

--��ʼ����Ʒ��������
insert into [Type](TypeName) values('Ь��')
insert into [Type](TypeName) values('��װ')
insert into [Type](TypeName) values('װ��')
--��ʼ����Ʒ��Ϣ
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000001',1,'���¼������˶���Ь',400,800,1,20,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000002',1,'AIR ZOOM33���������˶�Ь',200,398,1,30,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000003',2,'�����֯����Բ����ͷ��637903',400,800,1,20,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000004',2,'������֯��805248',400,800,1,40,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000005',3,'���������Ȱ�SP0040',20,60,1,100,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000006',3,'�Ϳ�˫�米��NIKE-KYRIEŷ�������˶�ѵ��װ��',300,588,1,200,getdate())
--��ʼ�������˵���Ϣ
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'1',':',''),getdate(),1600,3,2)
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'2',':',''),getdate(),1388,4,2)
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'3',':',''),getdate(),860,3,2)
select* from Sales
--��ʼ�������˵���ϸ��Ϣ
insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(1,1,1,800)
insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(1,3,1,800)

insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(2,3,1,800)
insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(2,6,1,588)

insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(3,4,1,800)
insert into SalesDetail(SalesID,GoodsID,Quantity,GoodsMoney)
values(3,5,1,60)

select* from SalesMan
select* from [Type]
select* from Goods
select* from Sales
select* from SalesDetail


declare @AllSellMoney decimal(10,2)
select @AllSellMoney = (select SUM(AllMoney) from Sales where SalesDate between '2023-10-1' and '2023-10-31')
if @AllSellMoney is null
	set @AllSellMoney = 0
select SalesmanName ����,[Role] ����,Mobile �绰,Wage ��������,
case
	when [Role] = '����Ա' then '0' 
	else
	CommissionRate
end ��ɱ���,
case
	when [Role] = '�곤' then @AllSellMoney
	when sumMoney is null then 0
	else sumMoney
end �����۶�,
case
	when [Role] = '�곤' then CONVERT(decimal(9,2),Wage + @AllSellMoney*CommissionRate)
	when sumMoney is null then CONVERT(decimal(9,2),Wage)
	else CONVERT(decimal(9,2),Wage + sumMoney * CommissionRate)
end Ӧ������ from SalesMan
left join
(select SalesmanID,SUM(AllMoney) sumMoney from Sales where SalesDate between '2023-10-1' and '2023-10-31' group by SalesmanID) ss
on SalesMan.SalesmanID = ss.SalesmanID 


select ReceiptsCode ��ˮ��,SalesDate ��������,AllMoney ������,
lirun ��������,
DaoGouMan.SalesmanName ����Ա,CashierMan.SalesmanName ����Ա from Sales 
left join SalesMan DaoGouMan on DaoGouMan.SalesmanID = Sales.SalesmanID 
left join SalesMan CashierMan on  Sales.CashierID = CashierMan.SalesmanID
left join (select SalesID,SUM((GoodsMoney - StorePrice)*Quantity) lirun from SalesDetail left join Goods on SalesDetail.GoodsID = Goods.GoodsID group by SalesID) liruntable on Sales.SalesID = liruntable.SalesID
where SalesDate between '2023-10-1' and '2023-10-31' 
and Sales.SalesmanID = ?