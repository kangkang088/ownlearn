create database DBWORK1
on
(
	name = 'DBWORK1',
	filename = 'E:\DATA\DBWORK1.mdf',
	size = 5MB,
	filegrowth = 2MB
)
log on
(
	name = 'DBWORK1_log',
	filename = 'E:\DATA\DBWORK1_log.ldf',
	size = 5MB,
	filegrowth = 2MB
)
use DBWORK1