using System.Collections.Generic;

namespace StudentRegistration
{
    public class DepartmentList {
        private List<Department> departments = new List<Department>();
        public void AddDepartment(Department department){
            departments.Add(department);
        }
        public void RemoveDepartment(Department department){
            departments.Add(department);
        }
        
    }
}