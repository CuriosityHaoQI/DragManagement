USE DrugManagement
//�û���
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
		NOT NULL
	,Gender
		BIT
		NOT NULL
	,BirthDate
		DATE
		NULL
	,Photo
		VARBINARY(MAX)
		NULL)
INSERT tb_User
	(No,Name,Password,Gender,Birthdate)
	VALUES
	('3190707003','�ź���',HASHBYTES('MD5','7003'),1,'2021/4/27');
--ҩƷ
DROP TABLE IF EXISTS tb_Drug; 
CREATE TABLE tb_Drug
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Name
		VARCHAR(20)
		NOT NULL
	,RepertoryNo--����
		CHAR(10)
		NOT NULL
	,Specifications--���
		VARCHAR(20) 
		NOT NULL
	,SKU--��浥λ
		VARCHAR(2)
		NOT NULL
	,BatchNumber--����
		char(5)
		NOT NULL
	,ProduceDate--��������
		DATE
		NOT NULL
	,price--�۸�
		MONEY
		NOT NULL
	,Validity--��Ч��/��
		INT
		NOT NULL)
INSERT tb_Drug
		(No,Name,RepertoryNo,Specifications,SKU,BatchNumber,ProduceDate,price,Validity)
		VALUES
		('1000012345','5%������(500ml)','0427000001','500ml','ƿ','40001','2019-2-27',89.2,24),
		('1000012346','��������','0427000002','500g','ƿ','40002','2018-7-25',87.2,36),
		('1000012347','����Ƭ','0427000003','7.5mg*10Ƭ','Ƭ','40003','2019-10-4',45.6,12),
		('1000012348','��������ƿڷ�Һ','0427000004','10֧/��','��','40004','2019-11-4',87.2,30)
	
--���
DROP TABLE IF EXISTS tb_Repertory; 
CREATE TABLE tb_Repertory
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Count
		INT
		NOT NULL
	,UpperLimit--�������
		INT
		NOT NULL
	,LowerLimit--�������
		INT
		NOT NULL
	,Cardinal--������
		INT 
		NOT NULL
	,OutDate--��������
		DATE
		NOT NULL)
INSERT tb_Repertory
		(No,Count,UpperLimit,LowerLimit,Cardinal,OutDate)
		VAlUES
		('0427000001',9800,30000,5000,8000,'2020-4-3'),
		('0427000002',8600,20000,6000,9000,'2019-1-25'),
		('0427000003',1000,15000,2000,1500,'2020-2-18'),
		('0427000004',15000,12000,3000,2500,'2020-1-28')