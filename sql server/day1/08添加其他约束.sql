--添加约束（主键）
alter table 表名 add constraint 约束名 primary key(列名)
--添加约束（唯一）
alter table 表名 add constraint 约束名 unique(列名)
--添加约束（默认）
alter table 表名 add constraint 约束名 default 默认值 for 列名
--添加约束（外键）
alter table 表名 add constraint 约束名 foreign key(列名) references 关联的表名(列名(一般是主键)) 