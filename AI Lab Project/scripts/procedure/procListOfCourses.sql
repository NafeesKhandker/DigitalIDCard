IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('procListOfCourses'))
DROP PROCEDURE procListOfCourses
GO

-- EXEC procListOfCourses

CREATE PROCEDURE  procListOfCourses
AS

DECLARE @pStartIndex INT = 1;
DECLARE @pPageSize INT = 10000;
DECLARE @pOrderBy VARCHAR(256) = 'course_name ASC';

SELECT *  FROM
	(SELECT ROW_NUMBER() OVER (ORDER BY
		CASE WHEN @pOrderBy='course_name ASC' THEN course_name END ASC,  
		CASE WHEN @pOrderBy='course_name DESC' THEN course_name END DESC,
		CASE WHEN @pOrderBy='course_code ASC' THEN course_code END ASC,  
		CASE WHEN @pOrderBy='course_code DESC' THEN course_code END DESC) AS Row,
		COUNT(*) Over() TOTALROWS, c.* ,course_type_name
	FROM Courses AS c
	INNER JOIN CourseType as ct ON ct.course_type_id = c.course_type_id) AS RECORDS
	WHERE RECORDS.Row>= @pStartIndex AND RECORDS.Row <= @pStartIndex + @pPageSize
	ORDER BY Row


GO


