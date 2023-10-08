create table Student
(
	StuId int primary key identity(1,2),
	StuName varchar(20),
	StuSex varchar(4)
)
insert into Student(StuName,StuSex) values('刘备','男')
insert into Student(StuName,StuSex) values('关羽','男')
insert into Student(StuName,StuSex) values('张飞','男')
insert into Student(StuName,StuSex) values('赵云','男')
insert into Student(StuName,StuSex) values('马超','男')
insert into Student(StuName,StuSex) values('黄忠','男')
insert into Student(StuName,StuSex) values('魏延','男')
insert into Student(StuName,StuSex) values('简雍','男')
insert into Student(StuName,StuSex) values('诸葛亮','男')
insert into Student(StuName,StuSex) values('徐庶','男')
insert into Student(StuName,StuSex) values('周仓','男')
insert into Student(StuName,StuSex) values('关平','男')
insert into Student(StuName,StuSex) values('张苞','男')
insert into Student(StuName,StuSex) values('曹操','男')
insert into Student(StuName,StuSex) values('曹仁','男')
insert into Student(StuName,StuSex) values('曹丕','男')
insert into Student(StuName,StuSex) values('曹植','男')
insert into Student(StuName,StuSex) values('曹彰','男')
insert into Student(StuName,StuSex) values('典韦','男')
insert into Student(StuName,StuSex) values('许褚','男')
insert into Student(StuName,StuSex) values('夏侯敦','男')
insert into Student(StuName,StuSex) values('郭嘉','男')
insert into Student(StuName,StuSex) values('荀彧','男')
insert into Student(StuName,StuSex) values('贾诩','男')
insert into Student(StuName,StuSex) values('孙权','男')
insert into Student(StuName,StuSex) values('孙坚','男')
insert into Student(StuName,StuSex) values('孙策','男')
insert into Student(StuName,StuSex) values('太史慈','男')
insert into Student(StuName,StuSex) values('大乔','女')
insert into Student(StuName,StuSex) values('小乔','女')

select* from Student
--分页
--假设每页五条数据
--第一页
select top 5 * from Student where StuId not in (select top 0 StuId from Student)
--第二页
select top 5 * from Student where StuId not in(select top 5 StuId from Student)
--第三页，以此类推
select top 5 * from Student where StuId not in(select top 10 StuId from Student)
--第四页
select top 5 * from Student where StuId not in(select top 15 StuId from Student)
--第五页
select top 5 * from Student where StuId not in(select top 20 StuId from Student)
--第六页
select top 5 * from Student where StuId not in(select top 25 StuId from Student)

--规律：
-------------------------------------------------------------------------------
--select top 页码大小（每页有几个数据项） * from Student where StuId not in (select top 页码大小*（当前页-1） StuId from Student)
-------------------------------------------------------------------------------

--分页
--方案一：数据量特别大的时候效率不高
declare @PageSize int = 5
declare @PageIndex int = 1 --2、3、4、5、... n
select top (@PageSize) * from Student where StuId not in(select top (@PageSize*(@PageIndex - 1)) StuId from Student)
go
--方案二：使用row_number分页 
--根据id使用between 1 and 5 进行分页时，存在问题，第一页可能删除了一个3，这时第一页查询应该是1，5，7，9，11，但是这样用between却是1，5，7，9
--解决 用row_number根据行号
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 1 and 5
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 6 and 10
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 11 and 15
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 16 and 20
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 21 and 25
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between 26 and 30
--select* from (select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp where RowID between 1 and 5
--between (当前页-1)*页码大小 + 1 and 当前页*页码大小

declare @PageSize int = 5
declare @PageIndex int = 3 --2、3、4、5、... n
select* from 
(select ROW_NUMBER() over(order by StuId) RowID,* from Student) Temp
where RowID between (((@PageIndex - 1)*@PageSize) + 1) and (@PageIndex * @PageSize)