/*
连接_连接字符串
*/
--创建数据库；
USE master;
CREATE DATABASE DrugManagement
	ON
		(NAME='Datafile'
		,FILENAME='C:\DrugManagement\DrugManagement.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='C:\DrugManagement\DrugManagement.ldf');
--创建表；
----用户表；
DROP TABLE IF EXISTS tb_User; 					
CREATE TABLE tb_User
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Name
		CHAR(10)
		NOT NULL		
	,Password
		VARBINARY(128)
		NOT NULL);
INSERT tb_User
	(No,Name,Password)
	VALUES
	('3190707001','张浩奇',HASHBYTES('MD5','7001'));