create database BANKSQL
on
(
	name = 'BANKSQL',
	filename = 'E:\DATA\BANKSQL.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'BANKSQL_log',
	filename = 'E:\DATA\BANKSQL_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use BANKSQL
--基本功能
--1.银行开户（注册个人信息）及开卡（办理银行卡）（一个人可以办理多张，但最多只能办3张）
--2.存钱
--3.查询余额
--4.取钱
--5.转账
--6.查看交易记录
--7.账户挂失
--8.账户注销

-----------------表设计-----------------
--1.账户信息表
--2.银行卡表
--3.交易信息表（存储存钱和取钱的记录）
--4.转账信息表（存储转账信息记录）
--5.状态信息变化表（存储银行卡状态1:正常2:挂失3:冻结4:注销）


-----------------------表结构设计---------------------
create table AccountInfo --账户信息表
(
	AccountId int primary key identity(1,1),--账户编号
	AccountCode varchar(20) not null,--身份证号码
	AccountPhone varchar(20) not null,--电话号码
	RealName varchar(20) not null,--真实姓名
	OpenTime smalldatetime not null--开户时间
)
create table BankCard --银行卡表
(
	CardNo varchar(50) primary key, --银行卡卡号
	AccountId int not null, --账户编号(与账户信息表形成主外键关系)
	CardPwd varchar(50) not null, --银行卡密码
	CardMoney money not null, --银行卡余额
	CardState int not null, --1:正常2:挂失3:冻结4:注销
	CardTime smalldatetime default(getdate()) --开卡时间
)
create table CardExchange--交易信息表(存储存钱和取钱的记录)
(
	ExchangeId int primary key identity(1,1),--交易自动编号
	CardNo varchar(50) not null,--银行卡卡号（与银行卡表形成主外键关系）
	MoneyInBank money not null,--存钱金额
	MoneyOutBank money not null,--取钱金额
	ExchangeTime smalldatetime not null,--交易时间
)
create table CardTransfer--转账信息表（存储转账信息）
(
	TransferId int primary key identity(1,1),--转账自动编号
	CardNoOut varchar(50) not null,--转出银行卡卡号(与银行卡表形成主外键关系)
	CardNoIn varchar(50) not null,--转入银行卡卡号(与银行卡表形成主外键关系)
	TransferMoney money not null,--交易金额
	TransferTime smalldatetime not null,--交易时间
)
create table CardStateChange--状态信息变化表（存储银行卡状态1:正常2:挂失3:冻结4:注销）
(
	StateId int primary key identity(1,1),--状态信息自动编号
	CardNo varchar(50) not null,--银行卡卡号（与银行卡表形成主外键关系）
	OldState int not null,--银行卡原始状态
	NewState int not null,--银行卡新状态
	StateWhy varchar(200) not null,--状态变化原因
	StateTime smalldatetime not null--记录产生时间
)

--为刘备，关羽，张飞三个人进行开户操作
--刘备身份证：420107198905064135
--关羽身份证：420107199507104133
--张飞身份证：420107199602034138
insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime)
values('420107198905064135','13554785425','刘备',GETDATE())
insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState)
values('6225125478544587',1,'123456',0,1)
insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime)
values('420107199507104133','13454788854','关羽',GETDATE())
insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState)
values('6225547858741263',2,'123456',0,1)
insert into AccountInfo(AccountCode,AccountPhone,RealName,OpenTime)
values('420107199602034138','13456896321','张飞',GETDATE())
insert into BankCard(CardNo,AccountId,CardPwd,CardMoney,CardState)
values('6225547854125656',3,'123456',0,1)

select* from AccountInfo
select* from BankCard

--存钱操作，刘备2000,关羽8000,张飞500000
update BankCard set CardMoney = CardMoney + 2000 where CardNo = '6225125478544587'
insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime)
values('6225125478544587',2000,0,GETDATE())
update BankCard set CardMoney = CardMoney + 8000 where CardNo = '6225547858741263'
insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime)
values('6225547858741263',8000,0,GETDATE())
update BankCard set CardMoney = CardMoney + 500000 where CardNo = '6225547854125656'
insert into CardExchange(CardNo,MoneyInBank,MoneyOutBank,ExchangeTime)
values('6225547854125656',500000,0,GETDATE())

select* from AccountInfo
select* from BankCard
select* from CardExchange

--转账：刘备给张飞转1000元
update BankCard set CardMoney = CardMoney - 1000 where CardNo = '6225125478544587'
update BankCard set CardMoney = CardMoney + 1000 where CardNo = '6225547854125656'
insert into CardTransfer(CardNoOut,CardNoIn,TransferMoney,TransferTime)
values('6225125478544587','6225547854125656',1000,GETDATE())

select* from CardTransfer