IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('StudentInfo'))
BEGIN
CREATE TABLE StudentInfo(
	student_info_id INT IDENTITY(1,1) NOT NULL,
	student_id VARCHAR(32) NOT NULL, 
	student_RFID VARCHAR(32) NOT NULL,
	first_name VARCHAR(32) NOT NULL,
	last_name VARCHAR(512) NULL,
	gender_id INT NULL,
	contact_mobile VARCHAR(16) NULL,
	email_address VARCHAR(64) NULL,
	is_active BIT DEFAULT 1 NOT NULL


CONSTRAINT StudentInfo_student_id_unique UNIQUE (student_id),
CONSTRAINT StudentInfo_student_RFID_unique UNIQUE (student_RFID),
CONSTRAINT [FK_StudentInfo_Gender] FOREIGN KEY (gender_id) REFERENCES Gender (gender_id),
PRIMARY KEY (student_info_id)
)

END


