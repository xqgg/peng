INSERT [User](Id,Username,[Password]) VALUES(1,N'彭志强',1234)
INSERT [User](Id,Username,[Password]) VALUES(2,N'于维谦',12345)
ALTER TABLE [dbo].[User]
ALTER COLUMN [Password] NVARCHAR (15) NULL
INSERT [User](Id,Username) VALUES(3,N'幸龙泰')
--查找没有录入密码的用户
SELECT [Username],[Password] FROM [User]
WHERE [Password] IS NULL
--删除用户名（UserName）中包含“管理员”或者“17bang”字样的用户
INSERT [User](Id,Username,[Password]) VALUES(4,N'管理员',12345)
INSERT [User](Id,Username,[Password]) VALUES(5,N'17bang',12345)
DELETE [User] WHERE [Username] LIKE N'%管理员%' OR [Username] LIKE N'%17bang%' 
--CREATE TABLE [Keyword](
--[Id] INT IDENTITY(10,5) NOT NULL CONSTRAINT [PK_Id] PRIMARY KEY ,
--[Name] NVARCHAR(10) NOT NULL,
--[Used] INT NOT NULL
--)

--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title])
VALUES(1,N'在服务器上把原先的asp网站整体迁移出来，在新的服务器上重新布置',0,10,'2018/07/02',N'ASP 网站迁移')
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title])
VALUES(2,N'项目里的控件绑定属性都会出现这个问题',0,30,'2018/04/20',N'Winform里控件绑定数据源就会报错')
UPDATE [Problem] SET title=N'【推荐】'+title WHERE Reward>10

--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title])
VALUES(3,N'项目里的控件绑定属性都会出现这个问题',0,25,'2019/10/12',N'Winform里控件绑定数据源就会报错')
UPDATE [Problem] SET title=N'【加急】'+title WHERE Reward>20 AND [PublishDateTime]>'2019/10/10'

--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
DELETE [Problem] WHERE title LIKE N'【%】%'

--在Keyword表中：
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
INSERT [Keyword]([Name],[Used])VALUES (N'编程开发语言',240)
INSERT [Keyword]([Name],[Used])VALUES (N'C#',95)
INSERT [Keyword]([Name],[Used])VALUES (N'JIAVA',70)
INSERT [Keyword]([Name],[Used])VALUES (N'工具软件',68)
INSERT [Keyword]([Name],[Used])VALUES (N'HTML',32)
SELECT [Used],[Name] FROM [Keyword] WHERE [Used]>10 AND [Used]<50

--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
UPDATE [Keyword] SET [Used]=1 WHERE [Used] IS NULL OR [Used]<=0

--删除所有使用次数为奇数的Keyword
DELETE Keyword WHERE Used%2=1


