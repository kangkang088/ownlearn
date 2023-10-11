use DBTHREEPRODUCTION
--רҵ
create table ProfessionInfo
(
	ProfessionID int primary key identity(1,1), --רҵ���
	ProfessionName varchar(50) not null unique --רҵ����
)
--ѧ��
create table StudentInfo
(
	StuID varchar(20) primary key,  --ѧ��ѧ��
	StuName varchar(50) not null,		--ѧ������
	StuAge int not null check(StuAge > 0 and StuAge < 130), --ѧ������
	StuSex char(2) not null check(StuSex in('��','Ů')),  --ѧ���Ա�
	StuHobby nvarchar(100), --����
	ProfessionID int not null references ProfessionInfo(ProfessionID), --����רҵ���
)
--���רҵ��Ϣ
insert into ProfessionInfo(ProfessionName) values('���Ӿ���')
insert into ProfessionInfo(ProfessionName) values('�������')
insert into ProfessionInfo(ProfessionName) values('ҽ�ƻ���')
--����ѧ����Ϣ
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('001','����',18,'��','',1)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('002','����',20,'��','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('003','�ŷ�',19,'��','',2)
insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID)
values('004','������',17,'Ů','',3)
select* from ProfessionInfo
select* from StudentInfo inner join ProfessionInfo on ProfessionInfo.ProfessionID = StudentInfo.ProfessionID