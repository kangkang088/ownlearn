if exists(select *from sys.databases where name = 'DBTEST') 
drop database DBTEST
--�������ݿ�
create database DBTEST
on --�����ļ�
(
	name = 'DBTEST',--�߼����ƣ�һ������ݿ�����һ��
	filename = 'E:\DATA\DBTEST.mdf',--����·��������
	size = 5MB,--��ʼ��С
	filegrowth = 2MB --����������ʽ��Ҳ����д�ٷֱ�
)
log on -- ��־�ļ�
(
	name = 'DBTEST_log',--�߼����ƣ�һ������ݿ�����һ��
	filename = 'E:\DATA\DBTEST_log.ldf',--����·��������
	size = 5MB,--��ʼ��С
	filegrowth = 2MB--����������ʽ��Ҳ����д�ٷֱ�
)

--��д
create database DBTEST1