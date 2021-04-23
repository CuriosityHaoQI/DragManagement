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
		CHAR(10)
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
		INT)
INSERT tb_Drug
		(No,Name,RepertoryNo,Specifications,SKU,BatchNumber,ProduceDate,PurchasePrice,SalePrice,Validity)
		VALUES
		('1000012345','5%葡萄糖(500ml)','0427000001','500ml','瓶','40001','2019-2-27',35.2,55.5,124),
		('1000012346','亚硝酸钠','0427000002','500g','瓶','40002','2018-7-25',87.2,100,36),
		('1000012347','安定片','0427000003','7.5mg*10片','片','40003','2019-10-4',0.25,0.5,12),
		('1000012348','葡萄糖酸钙口服液','0427000004','10支/盒','盒','40004','2019-11-4',27.2,38.5,30)
	
--库存
DROP TABLE IF EXISTS tb_Repertory; 
CREATE TABLE tb_Repertory
	(No
		CHAR(10)
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
		(No,Count,UpperLimit,LowerLimit,Cardinal,OutDate)
		VAlUES
		('0427000001',9800,30000,5000,8000,'2020-4-3'),
		('0427000002',8600,20000,6000,9000,'2019-1-25'),
		('0427000003',1000,15000,2000,1500,'2020-2-18'),
		('0427000004',15000,12000,3000,2500,'2020-1-28')

USE DrugManagement
--供应商
DROP TABLE IF EXISTS tb_Supplier
CREATE TABLE tb_Supplier
		(No
			CHAR(5)
			NOT NULL
			PRIMARY KEY
		,Name
			VARCHAR(40)
			NOT NULL)
INSERT tb_Supplier
		(No,Name)
		VALUES
		('10001','六安市祥龙药业有限责任公司'),
		('10002','山东联邦恒升医药有限公司'),
		('10003','山东海健药业有限公司'),
		('10004','江苏济源医药有限公司'),
		('10005','湖南华阳制药有限公司'),
		('10006','郑州国药大药房有限公司')

--药品类别
DROP TABLE IF EXISTS tb_DrugType
CREATE TABLE tb_DrugType
		(No
			CHAR(2)
			NOT NULL
			PRIMARY KEY
		,Name
			VARCHAR(10)
			NOT NULL)
INSERT tb_DrugType
		(No,Name)
		VALUES
		('01','中药'),
		('02','西药'),
		('03','中成药')

--付款方式
DROP TABLE IF EXISTS tb_Payment
CREATE TABLE tb_Payment
		(No
			CHAR(2)
			NOT NULL
			PRIMARY KEY
		,Name
			VARCHAR(20)
			NOT NULL)
INSERT tb_Payment
		(No,Name)
		VALUES
		('01','微信'),
		('02','支付宝'),
		('03','现金'),
		('04','银行转账')

DROP TABLE IF EXISTS tb_DetailOrder
CREATE TABLE tb_DetailOrder
		(No
			CHAR(12)
			NOT NULL
			PRIMARY KEY
		,DrugNo
			CHAR(10)
			NOT NULL
		,SupplierNo
			CHAR(5)
			NOT NULL
		,PaymentNo
			CHAR(2)
			NOT NULL)
INSERT tb_DetailOrder
		(No,DrugNo,SupplierNo,PaymentNo)
		VALUES
		('410822200101','1000012345','10002','02')