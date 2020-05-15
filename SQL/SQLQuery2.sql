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
--CREATE TABLE Keyword
--(
--Id INT IDENTITY(10,5) PRIMARY KEY,
----关键字名字
--Name NVARCHAR NOT NULL UNIQUE,
----关键字内容
--Content NVARCHAR(20) NOT NULL UNIQUE,
----关键字使用次数
--Times INT CHECK(Times>=0)
--)
--在User表中：查找没有录入密码的用户
SELECT * FROM [User]
ALTER TABLE [User]
ALTER COLUMN Password NVARCHAR(20) NULL
INSERT [User](Id,UserName) VALUES(5,N'大飞哥')
INSERT [User](Id,UserName) VALUES(6,N'大彪哥')
INSERT [User](Id,UserName) VALUES(7,N'大龙哥')
SELECT * FROM [User] 
WHERE Password IS NULL
--在User表中：删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
INSERT [User](Id,UserName,Password) VALUES(8,N'大管理员',56744)
INSERT [User](Id,UserName,Password) VALUES(9,N'管理员54545',56744)
INSERT [User](Id,UserName,Password) VALUES(10,N'17bang454',56744)
INSERT [User](Id,UserName,Password) VALUES(11,N'gag17bang',56744)
INSERT [User](Id,UserName,Password) VALUES(12,N'赵焱',56744)
DELETE [User] WHERE UserName LIKE N'%管理员%' OR UserName LIKE N'%17bang%'
--在Problem表中：给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
SELECT * FROM Problem
ALTER TABLE Problem
ALTER COLUMN Title NVARCHAR(20) NOT NULL
DELETE Problem
ALTER TABLE Problem
DROP CONSTRAINT CK_Reward
INSERT Problem(Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'什么是生',1,null,'2020/1/6',N'色即是空')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'什么是死',0,5,'2020/2/6',N'空即是色')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'什么是成功',1,1,'2020/3/6',N'我就是你')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'什么是失败',0,2,'2020/4/6',N'你就是我')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'什么是你',1,3,'2020/5/6',N'哈哈哈')
INSERT Problem(Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'我又是什么',0,11,'2020/6/6',N'哦哦哦')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'我杀了谁',1,12,'2020/7/6',N'嘎嘎嘎嘎嘎')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'谁杀了我',0,18,'2020/8/6',N'摸摸摸')

UPDATE Problem SET Title=N'【推荐】'+Title WHERE Reward>10

--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'谁又是谁',0,30,'2020/8/6',N'呱呱呱')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'愿得一人心',0,31,'2018/8/6',N'摸摸摸')
UPDATE Problem SET Title=N'【加急】'+Title WHERE Reward>20 and PublishDateTime>'2019/10/10'

--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
DELETE Problem WHERE Title LIKE N'【%】%'

--查找Title中第5个起，字符不为“数据库”且包含了百分号（%）的求助
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'不离不弃',0,31,'2018/8/6',N'数据库a')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'知足常乐',0,31,'2018/8/6',N'我是%')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'穷开心',0,31,'2018/8/6',N'第五个是数据库a')
INSERT Problem (Content,NeedRemoteHelp,Reward,PublishDateTime,Title)
VALUES(N'穷游',0,31,'2018/8/6',N'第五个是数据库%')
SELECT * FROM Problem WHERE Title NOT LIKE N'____数据库%' AND Title LIKE N'%#%%' ESCAPE'#'

--在Keyword表中：找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
SELECT * FROM Keyword
ALTER TABLE Keyword
DROP CONSTRAINT UQ__Keyword__CD856C003AFCA492
ALTER TABLE Keyword
DROP COLUMN Content
ALTER TABLE Keyword
DROP COLUMN Times
ALTER TABLE Keyword
DROP CONSTRAINT CK__Keyword__Times__6754599E;
ALTER TABLE Keyword
ADD [Used] INT CHECK(Used>-1)
ALTER TABLE Keyword
ALTER COLUMN Name NVARCHAR(20) NOT NULL
INSERT Keyword(Name,Used) VALUES(N'JAVA',0)
INSERT Keyword(Name,Used) VALUES(N'C#',10)
INSERT Keyword(Name,Used) VALUES(N'VB',20)
INSERT Keyword(Name,Used) VALUES(N'ASP.NET',30)
INSERT Keyword(Name,Used) VALUES(N'SQL',40)
INSERT Keyword(Name,Used) VALUES(N'HTML',60)
SELECT Name FROM Keyword 
--WHERE Used>10 AND Used<50
WHERE Used BETWEEN 10 AND 50
--如果使用between是包含边界条件的
--在Keyword表中：如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
INSERT Keyword(Name,Used) VALUES(N'人人都是程序员',101)
INSERT Keyword(Name,Used) VALUES(N'你值得拥有',0)
UPDATE [Keyword] SET Used=1 WHERE Used<=0 OR Used >100
--删除所有使用次数为奇数的Keyword
DELETE Keyword WHERE Used%2=1