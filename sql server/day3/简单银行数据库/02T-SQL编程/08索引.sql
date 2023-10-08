select* from AccountInfo where AccountCode = '420107199507104133' --假设这样查很慢了，那就为这一列添加一个索引,提高查询效率

--给AccountInfo表中的AccountCode添加索引（非聚集索引）
create unique nonclustered index index_code
on AccountInfo(AccountCode)
--索引查看(sys.indexes)
select * from sys.indexes where name = 'index_code'
--索引删除
drop index index_code on AccountInfo

--查询
--显示指定索引进行查询（效率高）
select* from AccountInfo with(index = index_code) where AccountCode = '420107199507104133'