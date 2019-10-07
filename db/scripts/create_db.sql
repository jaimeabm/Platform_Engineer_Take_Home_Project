/*Create database*/
USE master;  
GO
IF DB_ID ( N'micasa' ) IS NOT NULL
DROP DATABASE micasa;
GO
CREATE DATABASE micasa;  
GO
/*Create login & user for database*/
CREATE LOGIN micasa_login WITH PASSWORD = 'Password1234',
    CHECK_POLICY=OFF,
    CHECK_EXPIRATION = OFF;
GO
Use micasa;
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'micasa_web')
BEGIN
    CREATE USER micasa_web FOR LOGIN micasa_login
    EXEC sp_addrolemember 'db_owner', 'micasa_web'
END;
GO
EXEC sp_addrolemember 'db_owner', micasa_web
GO