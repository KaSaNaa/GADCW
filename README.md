# GADCW
GAD coursework project at uni.

## ER of the database we use.

```mermaid
  erDiagram
      Users {
          UserID int
          FirstName varchar
          LastName varchar
          Email varchar
          Password varchar
          UserType varchar
      }

      Courses {
          CourseID int
          CourseName varchar
          Description varchar
          Category varchar
      }

      Lessons {
          LessonID int
          LessonTitle varchar
          Content varchar
          CourseID int
      }

      Quizzes {
          QuizID int
          QuizTitle varchar
          Description varchar
          CourseID int
      }

      Questions {
          QuestionID int
          QuestionText varchar
          CorrectAnswer varchar
          WrongAnswer1 varchar
          WrongAnswer2 varchar
          WrongAnswer3 varchar
          QuizID int
      }

      UserCourses {
          UserID int
          CourseID int
          EnrollmentDate date
      }

      UserLessons {
          UserID int
          LessonID int
          CompletionDate date
      }

      UserQuizzes {
          UserID int
          QuizID int
          CompletionDate date
      }

      Users }|..o{ Courses : enrolls
      Users }|..o{ UserCourses : includes
      Users }|..o{ UserLessons : completes
      Users }|..o{ UserQuizzes : completes
      UserLessons }o..|{ Lessons : consists_of
      UserQuizzes }o..|{ Quizzes : comprises_of
      UserCourses }|..o{ Courses : includes
      Courses }|..|{ Lessons : has
      Courses }|..|{ Quizzes : has
      Quizzes }|..|{ Questions : has
      

```
To set the default properties of the MetroForms, <b> add this code in the constructor of your form or in a method that runs when the form loads.</b>
```cs
// Set the BackColor property
this.BackColor = Color.FromArgb(40, 40, 40);

// Set the ForeColor property
this.ForeColor = Color.White;

// Set the Font property
this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

// Set the Style property
this.Style = MetroFramework.MetroColorStyle.Black;

// Set the Theme property
this.Theme = MetroFramework.MetroThemeStyle.Dark;

```
