select* from AccountInfo where AccountCode = '420107199507104133' --��������������ˣ��Ǿ�Ϊ��һ�����һ������,��߲�ѯЧ��

--��AccountInfo���е�AccountCode����������Ǿۼ�������
create unique nonclustered index index_code
on AccountInfo(AccountCode)
--�����鿴(sys.indexes)
select * from sys.indexes where name = 'index_code'
--����ɾ��
drop index index_code on AccountInfo

--��ѯ
--��ʾָ���������в�ѯ��Ч�ʸߣ�
select* from AccountInfo with(index = index_code) where AccountCode = '420107199507104133'