--利用循环，打印如下所示的等腰三角形：
--   1
--  333
-- 55555
--7777777
DECLARE @tier INT =3,@show INT =1
WHILE(@show<8)
BEGIN
	PRINT SPACE(@tier)+REPLICATE(@show,@show)
	SET @show+=2
	SET @tier-=1
END

--定义一个函数GetBigger(INT a, INT b)，可以取a和b之间的更大的一个值
--GO
--CREATE FUNCTION	GetBigger(@a INT,@b INT)
--RETURNS INT
--AS
--BEGIN
--	DECLARE @temp INT
--	IF	@a>@b SET @temp=@a
--	ELSE SET @temp=@b
--	RETURN @temp
--END
--测试：
--参数为@a=1,@b=2时返回2
--参数为@a=2,@b=8时返回8
--参数为@a=2,@b=2时返回2

PRINT dbo.GetBigger(2,2)

--创建一个单行表值函数GetLatestEnroll(INT n)，返回最近入学的n为同学
GO
CREATE FUNCTION GetLatestEnroll( @n INT)
RETURNS TABLE
RETURN SELECT TOP 3 * FROM Student ORDER BY Enroll

