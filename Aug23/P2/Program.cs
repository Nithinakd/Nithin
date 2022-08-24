using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    struct Employee
    {
        public int empno;
        public int sal;
        public string empname;
        public int deptno;

        // parameterized constructor
        public Employee(int employeeId, int salary, string employeeName,int departmentno)
        {

            empno = employeeId;
            sal = salary;
            empname = employeeName;
            deptno = departmentno;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // calls constructor of struct
            Employee emp = new Employee(1,25000, "Nithin",2);

            Console.WriteLine("Employee Name: " + emp.empname);
            Console.WriteLine("Employee Id: " + emp.empno);
            Console.WriteLine("Employee Salary: " + emp.sal);
            Console.WriteLine("Employee Department no:" + emp.deptno);
            Console.ReadLine();
        }
    }
}
