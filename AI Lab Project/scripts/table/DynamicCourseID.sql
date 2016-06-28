IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('DynamicCourseID'))
BEGIN
CREATE TABLE DynamicCourseID(
	dynamic_course_id INT IDENTITY(1,1) NOT NULL,
	dynamic_course_code VARCHAR(64) NULL,	


PRIMARY KEY (dynamic_course_id)
)

END


