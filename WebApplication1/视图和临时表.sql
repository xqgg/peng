--创建求助的应答表 Response(Id, Content, AuthorId, ProblemId, CreateTime)
CREATE TABLE Response(
Id INT NOT NULL PRIMARY KEY IDENTITY,
Content TEXT NOT NULL,
AuthorId INT NOT NULL,
ProblemId INT NOT NULL,
CreateTime DATETIME NOT NULL
)
ALTER TABLE Response
ADD CONSTRAINT FK_Author_Id
FOREIGN KEY (AuthorId)
REFERENCES [User](Id)

ALTER TABLE Response
ADD CONSTRAINT FA_Problem_Id
FOREIGN KEY (ProblemId)
REFERENCES Problem(Id)



--SELECT * FROM Response

--然后生成一个视图 VResponse(ResponseId, Content, ResponseAuthorId，ReponseAuthorName,
--ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)，要求该视图：
--1.能展示应答作者的用户名、应答对应求助的标题和作者用户名 （JOIN）
--2.只显示求助悬赏值大于5的数据 （JOIN）
--3.已被加密
--4.保证其使用的基表结构无法更改
SELECT * FROM Response
INSERT Response VALUES (N'示例',1,1,'2019-11-7')
ALTER TABLE Response
ALTER COLUMN Content NTEXT NOT NULL


--SELECT p.Id ResponseId, p.Content, p.AuthorId ResponseAuthorId, u.Username ReponseAuthorName,
-- ProblemId

--FROM
--Response p JOIN [User] u 
--ON p.AuthorId=u.Id

SELECT * FROM Response
SELECT * FROM Problem
SELECT * FROM [User]




--SELECT t.ResponseId,t.Content,t.ResponseAuthorId,t.ReponseAuthorName,t.ProblemId,p.AuthorId AS ProblemAuthorName,
--p.title AS ProblemTitle,p.PublishDateTime AS CreateTime
--FROM Problem p 
--JOIN
--(SELECT
--rp.Id ResponseId, rp.Content, rp.AuthorId ResponseAuthorId, u.Username ReponseAuthorName,
--rp.ProblemId
--FROM
--Response rp JOIN [User] u 
--ON rp.AuthorId=u.Id) AS t
--ON t.ProblemId = p.Id
--SELECT * FROM [User]

--然后生成一个视图 VResponse(ResponseId, Content, ResponseAuthorId，ReponseAuthorName,
--ProblemId, ProblemAuthorName, ProblemTitle, CreateTime)，要求该视图：

SELECT 
r.Id ResponseId,
r.Content Content,
r.AuthorId ResponseAuthorId,
ru.Username ReponseAuthorName,
p.Id ProblemId,
pu.Username ProblemAuthorName,
p.title ProblemTitle,
p.PublishDateTime CreateTime
FROM 
Response r JOIN Problem p ON R.ProblemId=p.Id
JOIN [User] pu ON r.AuthorId = pu.Id
JOIN [User] ru ON p.AuthorId = ru.Id
WHERE p.Reward>5
