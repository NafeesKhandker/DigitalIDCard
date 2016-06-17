IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('Attendance'))
BEGIN
CREATE TABLE Attendance(
	attendance_id INT IDENTITY(1,1) NOT NULL,
	student_id VARCHAR(32) NOT NULL, 
	course_id INT NULL,
	attendence_date DATETIME NULL,
	is_present BIT DEFAULT 0 NOT NULL


CONSTRAINT [FK_AttendenceInfo_Courses] FOREIGN KEY(course_id) REFERENCES Courses (course_id),
PRIMARY KEY (attendance_id)
)

END


