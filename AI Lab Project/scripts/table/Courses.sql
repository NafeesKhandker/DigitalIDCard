IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('Courses'))
BEGIN
CREATE TABLE Courses(
	course_id INT IDENTITY(1,1) NOT NULL,
	course_name VARCHAR (256) NULL,
	course_code INT NULL,
	course_type_id INT NULL,
	is_optional BIT DEFAULT 0 NOT NULL,
	is_active BIT DEFAULT 1 NOT NULL

CONSTRAINT [FK_Courses_CourseType] FOREIGN KEY(course_type_id) REFERENCES CourseType (course_type_id),
CONSTRAINT Courses_CourseCode_unique UNIQUE (course_code),
PRIMARY KEY (course_id)
)

END


