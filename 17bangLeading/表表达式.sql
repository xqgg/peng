--分别使用派生表和CET，查询求助表（表中只有一列整体的发布时间，没有年月的列），以获得：

--一起帮每月各发布了求助多少篇
SELECT PT.[month],COUNT(pt.pc)AS pcount FROM( 
	SELECT ROW_NUMBER() 
	OVER(ORDER BY MONTH(PublishDateTime))AS pc,
	MONTH(PublishDateTime)AS [month]
	FROM Problem
	)AS pt
GROUP BY pt.[month]
	
--每月发布的求助中，悬赏最多的3篇
SELECT*FROM(
	SELECT
	ROW_NUMBER()
	OVER (PARTITION BY MONTH(PublishDateTime) ORDER BY Reward DESC)AS pr,
	Reward,
	Id,
	MONTH(PublishDateTime)AS [month]
	FROM Problem)AS po
WHERE po.pr<=3

--每个作者，每月发布的，悬赏最多的3篇
WITH pa
AS( SELECT 
	ROW_NUMBER()
	OVER (PARTITION BY Author,MONTH(PublishDateTime) ORDER BY Reward )AS pr,
	Author,
	Reward,
	MONTH(PublishDateTime)AS m
	FROM Problem)
SELECT * FROM pa
WHERE pa.pr<=3

--分别按发布时间和悬赏数量进行分页查询的结果
WITH pa
AS( SELECT 
	ROW_NUMBER()
	OVER (PARTITION BY Author,MONTH(PublishDateTime) ORDER BY Reward )AS pr,
	Author,
	Reward,
	MONTH(PublishDateTime)AS m
	FROM Problem)
SELECT * FROM pa
WHERE pa.pr BETWEEN 3 AND 5