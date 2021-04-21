USE DrugManagement
//用户表
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
	,price--价格
		MONEY
		NOT NULL
	,Validity--有效期/月
		INT
		NOT NULL)
INSERT tb_Drug
		(No,Name,RepertoryNo,Specifications,SKU,BatchNumber,ProduceDate,price,Validity)
		VALUES
		('1000012345','5%葡萄糖(500ml)','0427000001','500ml','瓶','40001','2019-2-27',89.2,24),
		('1000012346','亚硝酸钠','0427000002','500g','瓶','40002','2018-7-25',87.2,36),
		('1000012347','安定片','0427000003','7.5mg*10片','片','40003','2019-10-4',45.6,12),
		('1000012348','葡萄糖酸钙口服液','0427000004','10支/盒','盒','40004','2019-11-4',87.2,30)
	
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