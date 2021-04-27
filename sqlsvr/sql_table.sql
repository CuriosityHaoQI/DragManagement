USE DrugManagement
--�û���
USE DrugManagement
--�û���
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
		INT
		IDENTITY (100,1)
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
	,PurchasePrice--�����۸�
		MONEY
	,SalePrice--����
		MONEY
	,Validity--��Ч��/��
		INT
	,MemoryCode
		VARCHAR(20)
		NULL
	,DrugTypeNo
		INT 
		NULL
	,SupplierNo
		INT 
		NULL)
INSERT tb_Drug
		(Name,RepertoryNo,Specifications,SKU,BatchNumber,ProduceDate,PurchasePrice,SalePrice,Validity,MemoryCode,DrugTypeNo,SupplierNo)
		VALUES
		('5%������(500ml)','0427000001','500ml','ƿ','40001','2019-2-27',35.2,55.5,124,'ptt',1,47),
		('��������','0427000002','500g','ƿ','40002','2018-7-25',87.2,100,36,'yxsn',1,49),
		('����Ƭ','0427000003','7.5mg*10Ƭ','Ƭ','40003','2019-10-4',0.25,0.5,12,'adp',1,48),
		('��������ƿڷ�Һ','0427000004','10֧/��','��','40004','2019-11-4',27.2,38.5,30,'pttsgoky',2,45)
	
--���
DROP TABLE IF EXISTS tb_Repertory; 
CREATE TABLE tb_Repertory
	(No
		INT
		IDENTITY (50,1)
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
		(Count,UpperLimit,LowerLimit,Cardinal,OutDate)
		VAlUES
		(9800,30000,5000,8000,'2020-4-3'),
		(8600,20000,6000,9000,'2019-1-25'),
		(1000,15000,2000,1500,'2020-2-18'),
		(15000,12000,3000,2500,'2020-1-28')

--��Ӧ��
DROP TABLE IF EXISTS tb_Supplier
CREATE TABLE tb_Supplier
		(No
			INT
			NOT NULL
			IDENTITY(45,1)
			PRIMARY KEY
		,Name
			VARCHAR(40)
			NOT NULL)
INSERT tb_Supplier
		(Name)
		VALUES
		('����������ҩҵ�������ι�˾'),
		('ɽ���������ҽҩ���޹�˾'),
		('ɽ������ҩҵ���޹�˾'),
		('���ռ�Դҽҩ���޹�˾'),
		('���ϻ�����ҩ���޹�˾'),
		('֣�ݹ�ҩ��ҩ�����޹�˾')

--ҩƷ���
DROP TABLE IF EXISTS tb_DrugType
CREATE TABLE tb_DrugType
		(No
			INT
			NOT NULL
			IDENTITY(27,1)
			PRIMARY KEY
		,Name
			VARCHAR(10)
			NOT NULL)
INSERT tb_DrugType
		(Name)
		VALUES
		('��ҩ'),
		('��ҩ'),
		('�г�ҩ')

--���ʽ
DROP TABLE IF EXISTS tb_Payment
CREATE TABLE tb_Payment
		(No
			INT
			IDENTITY(1,1)
			NOT NULL
			PRIMARY KEY
		,Name
			VARCHAR(20)
			NOT NULL)
INSERT tb_Payment
		(Name)
		VALUES
		('΢��'),
		('֧����'),
		('�ֽ�'),
		('����ת��')

DROP TABLE IF EXISTS tb_DetailOrder
CREATE TABLE tb_DetailOrder
		(No
			INT
			IDENTITY (1,1)
			NOT NULL
			PRIMARY KEY 
		,DrugNo
			INT
			NOT NULL
		,DrugTypeNo
			INT
			NOT NULL
		,SupplierNo
			INT
			NOT NULL
		,PaymentNo
			INT
			NOT NULL
		,OrderDate
			DATE
			NULL
		,IsChecked
			BIT
			NOT NULL
		,PurchasePrice--�����۸�
			MONEY
			NOT NULL
		,DrugAmount
			INT 
			NOT NULL
		,MemoryCode
			VARCHAR(20)
			NOT NULL
		)
INSERT tb_DetailOrder
		(DrugNo,DrugTypeNo,SupplierNo,PaymentNo,OrderDate,IsChecked,PurchasePrice,DrugAmount,MemoryCode)
		VALUES
		(101,27,46,2,'2021-1-2',0,48,10000,'ppt')
