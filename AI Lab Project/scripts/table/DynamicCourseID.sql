IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('DynamicCourseID'))
BEGIN
CREATE TABLE DynamicCourseID(
	dynamic_course_id INT IDENTITY(1,1) NOT NULL,
	dynamic_course_code INT NULL,	
	password VARCHAR(64) NOT NULL


PRIMARY KEY (dynamic_course_id)
)

END


