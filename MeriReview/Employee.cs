using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeriReview
{
    //internal enum DepartmentEnum { Sales, Reception, Accounting, Management, Corporate};

    internal class Employee
    {
        public Employee(int empID, string empFirstName, string empLastname, string department)
        {
            EmpID = empID;
            EmpFirstName = empFirstName;
            EmpLastName = empLastname;
            Department = department;
        }

        public int EmpID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string Department { get; set; }
        //public DepartmentEnum Department { get; set; }
    }
}
