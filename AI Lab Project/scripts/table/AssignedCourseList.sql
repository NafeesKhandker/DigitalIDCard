IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('AssignedCourseList'))
BEGIN
CREATE TABLE AssignedCourseList(
	assigned_course_list_id INT IDENTITY(1,1) NOT NULL,
	student_id INT NULL,
	course_id INT NULL,
	

CONSTRAINT [FK_AssignedCourseList_StudentInfo] FOREIGN KEY (student_id) REFERENCES StudentInfo (student_info_id),
CONSTRAINT [FK_AssignedCourseList_Courses] FOREIGN KEY(course_id) REFERENCES Courses (course_id),
PRIMARY KEY (assigned_course_list_id)
)

END