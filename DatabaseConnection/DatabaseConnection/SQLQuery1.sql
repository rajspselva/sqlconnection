CREATE TABLE EMPLOYEE(
ID INT,
FIRSTNAME VARCHAR(50),
LASTNAME VARCHAR(50),
ADDRESS VARCHAR(300),
MOBILENUMBER VARCHAR(10),
EMAIL VARCHAR(50),
DOB DATE);

SELECT * FROM EMPLOYEE;

ALTER TABLE EMPLOYEE
ADD ID IDENTITY(1,1); 

Alter Table EMPLOYEE
Add ID Int Identity(1, 1);

ALTER TABLE EMPLOYEE 
ADD PRIMARY KEY(ID);

ALTER TABLE EMPLOYEE
DROP COLUMN ID;

ALTER TABLE EMPLOYEE
DROP CONSTRAINT PK__EMPLOYEE__3214EC27A3062CF1;


SELECT * FROM EMPLOYEE;

INSERT INTO EMPLOYEE VALUES('NAGALAKSHMI','PADMANABHAN','G02 KEILOR ROAD', '0469959345','RAJSPSELVA@GMAIL.COM','07/03/1983');
