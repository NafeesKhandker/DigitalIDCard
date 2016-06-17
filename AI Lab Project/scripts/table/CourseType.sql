IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('CourseType'))
BEGIN
CREATE TABLE CourseType(
	course_type_id INT IDENTITY(1,1) NOT NULL,
	course_type_name VARCHAR (256) NULL,

PRIMARY KEY (course_type_id)
)

INSERT INTO CourseType (course_type_name) VALUES ('Theory')
INSERT INTO CourseType (course_type_name) VALUES ('Lab')

END