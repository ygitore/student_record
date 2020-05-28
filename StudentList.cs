using System.Collections.Generic;

namespace StudentRegistration
{
    public class StudentList {
        private List<Student> students = new List<Student>();
        public void AddStudent(Student student) {
            students.Add(student);
        }
        public void RemoveStudent(int index) {
            students.RemoveAt(index);
        }
        public void PrintStudent() {
            for (int i = 0; i < students.Count; i++)
            {
                System.Console.WriteLine("------------");
                System.Console.WriteLine("Student Name: {0}",students[i].Name);
                System.Console.WriteLine("Department: {0}",students[i].Department.DepartmentName);
                System.Console.WriteLine("Taking: {0}",students[i].CourseName.CourseName);
                System.Console.WriteLine("Earned: {0}",students[i].Grade);
                System.Console.WriteLine("------------");
            }
        }        
    }
}