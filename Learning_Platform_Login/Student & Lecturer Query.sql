create Database Sign_Up_Details
use Sign_Up_Details

create table Student
(Student_FN varchar(30),
Student_LN varchar(30),
Student_Email varchar(50),
Student_Username varchar(30) Primary Key,
Student_Password varchar(30),
Student_Confirm varchar(30),
Student_DOB date);

insert into Student
(Student_FN, Student_LN, Student_Email, Student_Username, Student_Password, Student_Confirm, Student_DOB)
values
('Pasindu', 'Deshitha', 'pasindu086@gmail.com', 'pasindu086', 'pasindu123', 'pasindu123', '02/08/1999');

select * from Student;


create table Lecturer
(Lecturer_FN varchar(30),
Lecturer_LN varchar(30),
Lecturer_Email varchar(50),
Lecturer_Username varchar(30) Primary Key,
Lecturer_Password varchar(30),
Lecturer_Confirm varchar(30),
Lecturer_DOB date);

insert into Lecturer
(Lecturer_FN, Lecturer_LN, Lecturer_Email, Lecturer_Username, Lecturer_Password, Lecturer_Confirm, Lecturer_DOB)
values
('Kesan', 'Narangoda', 'kesan02@gmail.com', 'kesan02', 'kesan123', 'kesan123', '02/02/1985');

select * from Lecturer