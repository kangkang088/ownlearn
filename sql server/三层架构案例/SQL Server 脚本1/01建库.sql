create database DBTHREEPRODUCTION
ON
(
	name = 'DBTHREEPRODUCTION',
	filename = 'E:\DATA\DBTHREEPRODUCTION.mdf',
	size = 5MB,
	filegrowth = 2MB
)
LOG ON
(
	name = 'DBTHREEPRODUCTION_log',
	filename = 'E:\DATA\DBTHREEPRODUCTION_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
