--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
ALTER TABLE Problem
ADD [Author] NVARCHAR(128)
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title],Author)
VALUES(2,N'项目里的控件绑定属性都会出现这个问题',0,30,'2018/04/20',N'Winform里控件绑定数据源就会报错',N'飞哥')
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title],Author)
VALUES(3,N'项目里的控件绑定属性都会出现这个问题',0,20,'2018/04/20',N'Winform里控件绑定数据源就会报错',N'飞哥')
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title],Author)
VALUES(4,N'项目里的控件绑定属性都会出现这个问题',0,81,'2018/04/20',N'Winform里控件绑定数据源就会报错',N'飞哥')
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title],Author)
VALUES(5,N'项目里的控件绑定属性都会出现这个问题',0,35,'2018/04/20',N'Winform里控件绑定数据源就会报错',N'GGG')
INSERT [Problem]([Id],[Content],[NeedRemoteHelp],[Reward],[PublishDateTime],[title],Author)
VALUES(6,N'项目里的控件绑定属性都会出现这个问题',0,34,'2018/04/20',N'Winform里控件绑定数据源就会报错',N'飞哥')

--查找出Author为“飞哥”的、Reward最多的3条求助
SELECT TOP 3 * FROM  Problem WHERE Author=N'飞哥' ORDER BY Reward DESC

--查找Title中第5个起，字符不为“数据库”的求助
SELECT * FROM Problem WHERE NOT title= N'_____数据库%'