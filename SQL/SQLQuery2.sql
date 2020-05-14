--创建表User
--CREATE TABLE [User]
--(
--[Id] INT NOT NULL PRIMARY KEY,
--[UserName] NVARCHAR(20) NOT NULL,
--[Password] NVARCHAR(20) NOT NULL
--);

--创建表Problem
--CREATE TABLE Problem
--(
--Id INT IDENTITY PRIMARY KEY,
--Title NVARCHAR NOT NULL,
--Content NTEXT NOT NULL,
--NeedRemoteHelp BIT DEFAULT(1),
--Reward TINYINT ,
--PublishDateTime DATETIME NOT NULL
--)

--删除列，添加列
--ALTER TABLE Problem
--DROP COLUMN Title
--ALTER TABLE Problem
--ADD Title NVARCHAR NOT NULL

--Content的类型更改为NTEXT或NVARCHAR(MAX)
--ALTER TABLE Problem
--ALTER COLUMN Content NVARCHAR(100)

--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
--ALTER TABLE Problem
--ALTER COLUMN NeedRemoteHelp BIT NOT NULL
--ALTER TABLE Problem
--ALTER COLUMN NeedRemoteHelp BIT NULL

--添加自定义约束，让Reward不能小于10
--ALTER TABLE Problem
--ADD CONSTRAINT CK_Reward CHECK(Reward<10)

--备份TProblem表，再用两种方式删除/恢复TProblem中所有数据
--下面这个方法没有办法复制约束
--SELECT * INTO TProblem FROM Problem
--BEGIN TRANSACTION  
--DELETE TProblem;
--ROLLBACK;
 
 --删除TProblem表本身（含表结构和行数据）
--BEGIN TRANSACTION  
--drop TABLE TProblem;
--ROLLBACK;

--User表上的基础上
--INSERT [User] VALUES(1,N'赵淼',1234);
--INSERT [User] VALUES(2,N'赵森',2345);
--INSERT [User] VALUES(3,N'赵磊',3456);
--INSERT [User] VALUES(4,N'赵鑫',4567);
--DELETE FROM [User] WHERE Id=1
--添加Id列，让Id成为主键
--添加约束，让UserName不能重复
--ALTER TABLE [User]
--ADD CONSTRAINT UQ_UserName UNIQUE(UserName)
--将所有User的Password改为：'1234'
--UPDATE [User] SET Password='1234'

--观察一起帮的关键字功能，新建Keyword表，要求带一个自增的主键Id，起始值为10，步长为5
CREATE TABLE Keyword
(
Id INT IDENTITY(10,5) PRIMARY KEY,
--关键字名字
Name NVARCHAR NOT NULL UNIQUE,
--关键字内容
Content NVARCHAR(20) NOT NULL UNIQUE,
--关键字使用次数
Times INT CHECK(Times>=0)
)
