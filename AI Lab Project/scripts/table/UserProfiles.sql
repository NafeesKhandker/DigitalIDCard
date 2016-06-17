IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID('UserProfile'))
BEGIN
CREATE TABLE UserProfile(
	user_profile_id INT IDENTITY(1,1) NOT NULL,
	first_name VARCHAR(32) NOT NULL, 
	last_name VARCHAR(32) NOT NULL,
	user_name VARCHAR(32) NOT NULL,
	user_details VARCHAR(512) NULL,
	contact_phone VARCHAR(16) NULL,
	contact_mobile VARCHAR(16) NULL,
	email_address VARCHAR(64) NULL,
	is_active BIT DEFAULT 1 NOT NULL,
	password VARCHAR(64) NOT NULL

CONSTRAINT UserProfile_Name_unique UNIQUE (user_name),
PRIMARY KEY (user_profile_id)
)

INSERT INTO UserProfile (first_name,last_name,user_name, contact_mobile ,email_address,is_active,password)
VALUES('Shahjahan','Shahed','Admin', '01910944844', 'shahjahan.cseku11@hotmail.com',1,'12345678')
END


