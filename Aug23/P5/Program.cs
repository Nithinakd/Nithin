using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5

        {public struct Employee
        {

            // Declare three variables
            // id, name and age
            public int Id;
            public string Name;
            public int Salary;
        public int Department;

            // Set the employee details
            public void SetEmployee(int id, string name, int salary,int dept)
            {
                Id = id;
                Name = name;
                Salary = salary;
            Department = dept;
            }

            // Display employee details
            public void DisplayEmployee()
            {
                Console.WriteLine("Employee:");
                Console.WriteLine("\tId    : " + Id);
                Console.WriteLine("\tName   : " + Name);
                Console.WriteLine("\tSalary   : " + Salary);
                Console.WriteLine("\tDepartment   : " + Department);

            Console.WriteLine("\n");
            }
        }

        class GFG
        {

            // Driver code
            static void Main(string[] args)
            {

                // Create array of structure
                Employee[] emp = { new Employee(),
                       new Employee(),
                       new Employee() };

                // Pass the array indexes with values as structures
                emp[0].SetEmployee(1, "Nithin", 200000,10);
                emp[1].SetEmployee(2, "Rohit", 3000000,15);
                emp[2].SetEmployee(3, "Mohit", 2300000,20);

                // Call the display method
                emp[0].DisplayEmployee();
                emp[1].DisplayEmployee();
                emp[2].DisplayEmployee();
            }
        }
    }
    
