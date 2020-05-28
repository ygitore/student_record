using System;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department(){
                DepartmentName = "Computer science"
            };
            Department department2 = new Department(){
                DepartmentName = "Data science"
            };
            Course course1 = new Course(){
                CourseName = "html"
            };
            Course course2 = new Course(){
                CourseName = "javascript"
            };
            Course course3 = new Course(){
                CourseName = "SQL"
            };
            Course course4 = new Course(){
                CourseName = "C#"
            };
            Student student1 = new Student(){
                Name = "John Smith",
                CourseName = course1,
                Grade = "A",
                Department = department1
            };
            Student student2 = new Student(){
                Name = "David Lyn",
                CourseName = course4,
                Grade = "A",
                Department = department2
            };
            Student student3 = new Student(){
                Name = "Helen Simon",
                CourseName = course3,
                Grade = "C",
                Department = department1
            };
            Student student4 = new Student(){
                Name = "Mathew Jackson",
                CourseName = course2,
                Grade = "B",
                Department = department2
            };
            
            StudentList studentList = new StudentList();
            studentList.AddStudent(student1);
            studentList.AddStudent(student2);
            studentList.AddStudent(student3);
            studentList.AddStudent(student4);
            
            studentList.PrintStudent();
            
            try{
                studentList.RemoveStudent(-1);
                studentList.PrintStudent();
            }catch(ArgumentOutOfRangeException){
                System.Console.WriteLine("invalid index. index must be 0 or greater");
            }
        }
    }
}
