                   +-----------------+
                   |     Courses     |
                   +-----------------+
                   | CourseID        |
                   | CourseName      |
                   | Description     |
                   | Category        |
                   +-----------------+

                   +-----------------+
                   |     Lessons     |
                   +-----------------+
                   | LessonID        |
                   | LessonTitle     |
                   | Content         |
                   | CourseID        |
                   +-----------------+

                   +-----------------+
                   |     Quizzes     |
                   +-----------------+
                   | QuizID          |
                   | QuizTitle       |
                   | Description     |
                   | CourseID        |
                   +-----------------+

                   +-----------------+
                   |   Questions     |
                   +-----------------+
                   | QuestionID      |
                   | QuestionText    |
                   | CorrectAnswer  <<--+
                   | WrongAnswer1    |  |
                   | WrongAnswer2    |  |
                   | WrongAnswer3    |  |
                   | QuizID        -----+
                   +-----------------+

                   +-----------------+
                   |      Users      |
                   +-----------------+
                   | UserID          |
                   | FirstName       |
                   | LastName        |
                   | Email           |
                   | Password        |
                   | UserType        |
                   +-----------------+

                        ^                    ^
                        |                    |
                        |                    |
                        +                    +

          +---------------------------+
          |                           |
          |                           |
    +-----------+            +-----------+
    | UserCourses |            | UserLessons |
    +-----------+            +-----------+
    | UserID    -----+       | UserID    -----+
    | CourseID  -----+       | LessonID  -----+
    | EnrollmentDate |       | CompletionDate |
    +-----------+            +-----------+

                        |
                        |
                        +

                   +-----------------+
                   |   UserQuizzes   |
                   +-----------------+
                   | UserID          |
                   | QuizID          |
                   | CompletionDate  |
                   +-----------------+
