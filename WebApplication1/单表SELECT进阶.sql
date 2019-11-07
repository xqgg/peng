--以Problem中的数据为基础，使用SELECT INTO，新建一个Author和Reward都没有NULL值的新表：NewProblem 
--（把原Problem里Author或Reward为NULL值的数据删掉）
DROP TABLE [NewProblem]
SELECT * INTO [NewProblem] FROM Problem WHERE Author IS NOT NULL AND Reward IS NOT NULL 

--使用INSERT SELECT, 将Problem中Reward为NULL的行再次插入到NewProblem中
INSERT INTO NewProblem
SELECT * FROM Problem WHERE Reward IS NULL

--使用OVER，统计出求助里每个Author悬赏值的平均值、最大值和最小值，然后用新表ProblemStatus存放上述数据
SELECT Author,
MAX(Reward)[RewardMAX],
AVG(Reward)[RewardAVG],
MIN(Reward)[RewardMIN]
FROM Problem 
GROUP BY Author

SELECT 
Author,
MAX(Reward)OVER(PARTITION BY Author)[MAXReward],
AVG(Reward)OVER(PARTITION BY Author)[AVGReward],
MIN(Reward)OVER(PARTITION BY Author)[MINReward]
INTO ProblemStatus
FROM Problem

--使用CASE...WHEN，颠倒Problem中的NeedRemote（以前是1的，现在变成0；以前是0的，现在变成1）
UPDATE Problem
SET NeedRemoteHelp=
(CASE 
	WHEN NeedRemoteHelp=1 THEN 0
	ELSE 1
 END)

 --使用CASE...WHEN，用一条SQL语句，完成SQL入门-7：函数中第4题第3小题
