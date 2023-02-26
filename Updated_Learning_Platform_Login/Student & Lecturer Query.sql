create Database Sign_Up_Details
use Sign_Up_Details

CREATE TABLE Student (
    Table_ID int IDENTITY(1,1) PRIMARY KEY,
    Student_FN varchar(30),
    Student_LN varchar(30),
    Student_Email varchar(50),
	Student_Course varchar(40),
    Student_Username varchar(30),
    Student_Password varchar(30),
    Student_Confirm varchar(30),
    Student_DOB date,
    Student_ID AS 'S' + RIGHT('00' + CAST(Table_ID AS varchar(3)), 2) PERSISTED UNIQUE
);


insert into Student
(Student_FN, Student_LN, Student_Email, Student_Course, Student_Username, Student_Password, Student_Confirm, Student_DOB)
values
('Pasindu', 'Deshitha', 'pasindu086@gmail.com', 'Diploma in Computer Science' , 'pasindu086', 'pasindu123', 'pasindu123', '02/08/1999');

select * from Student;

Drop table Student;


CREATE TABLE Lecturer (
  Table_ID INT IDENTITY(1,1) PRIMARY KEY,
  Lecturer_FN VARCHAR(30),
  Lecturer_LN VARCHAR(30),
  Lecturer_Email VARCHAR(50),
  Lecturer_Username VARCHAR(30),
  Lecturer_Password VARCHAR(30),
  Lecturer_Confirm VARCHAR(30),
  Lecturer_DOB DATE,
  Lecturer_ID AS 'L' + RIGHT('00' + CAST(Table_ID AS VARCHAR(2)), 2)
);


insert into Lecturer
(Lecturer_FN, Lecturer_LN, Lecturer_Email, Lecturer_Username, Lecturer_Password, Lecturer_Confirm, Lecturer_DOB)
values
('Kesan', 'Narangoda', 'kesan02@gmail.com', 'kesan02', 'kesan123', 'kesan123', '02/02/1985');

select * from Lecturer