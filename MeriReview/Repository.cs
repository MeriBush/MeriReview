using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeriReview
{
    class Repository
    {
        List<Employee> EmployeeList = new List<Employee>();

        public void AddEmployeeToList(Employee emp)
        {
            EmployeeList.Add(emp);
        }

        public int CountEmployees()
        {
            return EmployeeList.Count();
        }

        public bool DisplayList()
        {
            foreach (Employee emp in EmployeeList)
            {
                Console.WriteLine("NAME: " + emp.EmpFirstName + " " + emp.EmpLastName + "    " + "DEPARTMENT: " + emp.Department);
            }
            return true;
        }

        public void DeleteEmployee(string name)
        {
            int theIndex = EmployeeList.FindIndex(Employee => Employee.EmpFirstName == name);
            EmployeeList.RemoveAt(theIndex);
        }
    }
}
