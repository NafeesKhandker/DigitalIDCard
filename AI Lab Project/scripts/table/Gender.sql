IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('Gender'))
BEGIN
CREATE TABLE Gender(
	gender_id INT IDENTITY(1,1) NOT NULL,
	gender VARCHAR (256) NULL,

PRIMARY KEY (gender_id)
)

INSERT INTO Gender (gender) VALUES ('Male')
INSERT INTO Gender (gender) VALUES ('Female')

END