using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__04
{
    public class Department
    {
        public int DeptID { get; set; }
        public string? DeptName { get; set; }
        static List<Employee> Staff = new();


        public void AddStaff(Employee E)
        {
            if (Staff?.Contains(E) == false)
                Staff.Add(E);
            else
                Console.WriteLine($"Employee already exists at department {DeptName}");
        }
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (Staff?.Contains(emp) == true))
            {
                Staff.Remove(emp);
                Console.WriteLine($"This is employee department --{DeptName}--");
                Console.WriteLine($"employee {emp.EmployeeID} has been removed from the department staff\n\n");
            }

        }
    }
 }
