using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeriReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            List<Employee> EmployeeList = new List<Employee>();

            Employee jim = new Employee(1, "Jim", "Halpert", "Sales");
            Employee pam = new Employee(2, "Pam", "Halpert", "Reception");
            Employee dwight = new Employee(3, "Dwight", "Schrute", "Sales");
            Employee michael = new Employee(4, "Michael", "Scott", "Management");
            Employee stanley = new Employee(5, "Stanley", "Hudson", "Sales");

            repo.AddEmployeeToList(jim);
            repo.AddEmployeeToList(pam);
            repo.AddEmployeeToList(dwight);
            repo.AddEmployeeToList(michael);
            repo.AddEmployeeToList(stanley);

            int numberOfEmployees = repo.CountEmployees();
            Console.WriteLine(numberOfEmployees);
            Console.ReadLine();

            //foreach (Employee emp in EmployeeList)
            //{
            //    Console.WriteLine("NAME: " + emp.EmpFirstName + " " + emp.EmpLastName + "    " + "DEPARTMENT" + emp.Department);
            //}
            //Console.ReadLine();

            repo.DisplayList();
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type the first name of the employee you wish do delete:");
            string emp = Console.ReadLine();

            repo.DeleteEmployee(emp);

            Console.WriteLine("Employee deleted. Your new list is:");
            repo.DisplayList();
            Console.ReadLine();

        }
    }
}
