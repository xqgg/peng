 --删除每个作者悬赏最低的求助

SELECT * FROM Problem pr
WHERE Reward = (
SELECT MIN(Reward) FROM Problem PrMin
WHERE pr.Author=PrMin.Author
)

DELETE Problem WHERE 
Reward = (
SELECT MIN(Reward) FROM Problem PrMin
WHERE Problem.Author=PrMin.Author
)

--找到从未成为邀请人的用户


SELECT * FROM [User]