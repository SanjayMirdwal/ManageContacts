IF NOT EXISTS(SELECT 1 FROM SYS.DATABASES WHERE name = N'EmployeeManagement')
BEGIN
	CREATE DATABASE [EmployeeManagement]
	PRINT 'Database created succesfully.'	
END
ELSE
BEGIN
	PRINT 'Database already exists.'
END