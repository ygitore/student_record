using System.Collections.Generic;

namespace StudentRegistration
{
    public class CourseList {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course){
            courses.Add(course);
        }
        public void RemoveCourse(Course course){
            courses.Add(course);
        }
        
    }
}