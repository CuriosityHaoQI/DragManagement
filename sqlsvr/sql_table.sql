USE DrugManagement
--用户表
USE DrugManagement
--用户表
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
	('3190707003','张浩奇',HASHBYTES('MD5','7003'),1,'2021/4/27');
--药品
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
	,RepertoryNo--库存号
		CHAR(10)
		NOT NULL
	,Specifications--规格
		VARCHAR(20) 
		NOT NULL
	,SKU--库存单位
		VARCHAR(2)
		NOT NULL
	,BatchNumber--批次
		char(5)
		NOT NULL
	,ProduceDate--生产日期
		DATE
		NOT NULL
	,PurchasePrice--进货价格
		MONEY
	,SalePrice--单价
		MONEY
	,Validity--有效期/月
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
		('5%葡萄糖(500ml)','0427000001','500ml','瓶','40001','2019-2-27',35.2,55.5,124,'ptt',1,47),
		('亚硝酸钠','0427000002','500g','瓶','40002','2018-7-25',87.2,100,36,'yxsn',1,49),
		('安定片','0427000003','7.5mg*10片','片','40003','2019-10-4',0.25,0.5,12,'adp',1,48),
		('葡萄糖酸钙口服液','0427000004','10支/盒','盒','40004','2019-11-4',27.2,38.5,30,'pttsgoky',2,45)
	
--库存
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
	,UpperLimit--库存上限
		INT
		NOT NULL
	,LowerLimit--库存下限
		INT
		NOT NULL
	,Cardinal--库存基数
		INT 
		NOT NULL
	,OutDate--出库日期
		DATE
		NOT NULL)
INSERT tb_Repertory
		(Count,UpperLimit,LowerLimit,Cardinal,OutDate)
		VAlUES
		(9800,30000,5000,8000,'2020-4-3'),
		(8600,20000,6000,9000,'2019-1-25'),
		(1000,15000,2000,1500,'2020-2-18'),
		(15000,12000,3000,2500,'2020-1-28')

--供应商
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
		('六安市祥龙药业有限责任公司'),
		('山东联邦恒升医药有限公司'),
		('山东海健药业有限公司'),
		('江苏济源医药有限公司'),
		('湖南华阳制药有限公司'),
		('郑州国药大药房有限公司')

--药品类别
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
		('中药'),
		('西药'),
		('中成药')

--付款方式
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
		('微信'),
		('支付宝'),
		('现金'),
		('银行转账')

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
		,PurchasePrice--进货价格
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
