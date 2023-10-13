use DBWORK1
--店员信息表
create table SalesMan
(
	SalesmanID int identity(1,1) primary key,   --编号
	SalesmanName nvarchar(50) not null,         --员工名字
	Mobile nvarchar(20) not null unique,        --员工电话（用户名）
	Pwd nvarchar(20) not null,                  --密码
	Gender nvarchar(2) not null check(Gender in ('男','女')),   --性别
	Wage decimal(8,2) not null,                 --基本工资
	CommissionRate decimal(4,2) not null,       --提成比例
	[Role] nvarchar(20) not null check([Role] in ('店长','导购员','收银员')) --角色
)
--产品类型表
create table [Type]
(
	TypeID int identity(1,1) primary key,   --编号
	TypeName nvarchar(50) not null,  --类别名称
)
--产品信息表
create table Goods
(
	GoodsID int identity(1,1) primary key,  --编号
	BarCode nvarchar(20) not null unique,   --条码
	TypeID int not null,                    --类型编号，与[Type]的TypeID形成主外键关系
	GoodsName nvarchar(50) not null,        --商品名称
	StorePrice decimal(8,2) not null,       --进货价格
	SalePrice decimal(8,2) not null,        --销售价格
	Discount decimal(4,2) not null default(1),  --折扣
	StockNum int not null,                   --库存数量
	StockDate datetime not null default(getdate())  --入库时间
)
select* from Goods
--销售账单表
create table Sales
(
	SalesID int identity(1,1) primary key,  --账单编号
	ReceiptsCode nvarchar(50) not null unique,  --账单流水号
	SalesDate date not null default(getdate()),  --销售时间
	AllMoney decimal(8,2) not null,              --销售总价
	SalesmanID int not null,                     --导购员编号
	CashierID int not null,                      --收银员编号
)
--销售账单明细表
create table SalesDetail
(
	SDID int identity(1,1) primary key,   --编号
	SalesID int not null,                 --账单编号（与Sales的SalesID主外键关系）
	GoodsID int not null,                 --商品编号
	Quantity int not null,                --数量
	GoodsMoney decimal(8,2) not null      --销售价格
)

--初始化店员信息
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('李易峰','13554787653','123456','男',6000,0.1,'店长')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('范冰冰','13435465678','123456','女',5000,0.1,'收银员')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('林志玲','13365767890','123456','女',3000,0.3,'导购员')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('章子怡','13777886765','123456','女',3000,0.3,'导购员')
insert into SalesMan(SalesmanName,Mobile,Pwd,Gender,Wage,CommissionRate,[Role])
values('孙燕姿','13665656666','123456','女',3000,0.3,'导购员')

--初始化产品类型数据
insert into [Type](TypeName) values('鞋类')
insert into [Type](TypeName) values('服装')
insert into [Type](TypeName) values('装备')
--初始化产品信息
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000001',1,'登月纪念款反光运动跑鞋',400,800,1,20,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000002',1,'AIR ZOOM33男子休闲运动鞋',200,398,1,30,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000003',2,'秋款针织卫衣圆领套头衫637903',400,800,1,20,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000004',2,'长袖针织衫805248',400,800,1,40,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000005',3,'基础足球护腿板SP0040',20,60,1,100,getdate())
insert into Goods(BarCode,TypeID,GoodsName,StorePrice,SalePrice,Discount,StockNum,StockDate)
values('000006',3,'耐克双肩背包NIKE-KYRIE欧文篮球运动训练装备',300,588,1,200,getdate())
--初始化销售账单信息
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'1',':',''),getdate(),1600,3,2)
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'2',':',''),getdate(),1388,4,2)
insert into Sales(ReceiptsCode,SalesDate,AllMoney,SalesmanID,CashierID)
values(convert(varchar(100),getdate(), 112)+replace(convert(varchar(100), GETDATE(), 14)+'3',':',''),getdate(),860,3,2)
select* from Sales
--初始化销售账单明细信息
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
select SalesmanName 姓名,[Role] 类型,Mobile 电话,Wage 基本工资,
case
	when [Role] = '收银员' then '0' 
	else
	CommissionRate
end 提成比例,
case
	when [Role] = '店长' then @AllSellMoney
	when sumMoney is null then 0
	else sumMoney
end 月销售额,
case
	when [Role] = '店长' then CONVERT(decimal(9,2),Wage + @AllSellMoney*CommissionRate)
	when sumMoney is null then CONVERT(decimal(9,2),Wage)
	else CONVERT(decimal(9,2),Wage + sumMoney * CommissionRate)
end 应发工资 from SalesMan
left join
(select SalesmanID,SUM(AllMoney) sumMoney from Sales where SalesDate between '2023-10-1' and '2023-10-31' group by SalesmanID) ss
on SalesMan.SalesmanID = ss.SalesmanID 


select ReceiptsCode 流水号,SalesDate 购物日期,AllMoney 购物金额,
lirun 单笔利润,
DaoGouMan.SalesmanName 导购员,CashierMan.SalesmanName 收银员 from Sales 
left join SalesMan DaoGouMan on DaoGouMan.SalesmanID = Sales.SalesmanID 
left join SalesMan CashierMan on  Sales.CashierID = CashierMan.SalesmanID
left join (select SalesID,SUM((GoodsMoney - StorePrice)*Quantity) lirun from SalesDetail left join Goods on SalesDetail.GoodsID = Goods.GoodsID group by SalesID) liruntable on Sales.SalesID = liruntable.SalesID
where SalesDate between '2023-10-1' and '2023-10-31' 
and Sales.SalesmanID = ?