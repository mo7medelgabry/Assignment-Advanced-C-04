using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__04
{
    public class Club
    {
        public int ClubID { get; set; }
        public String? ClubName { get; set; }
        static List<Employee> Members = new();
        public void AddMember(Employee E)
        {
            if (Members?.Contains(E) == false)
                Members.Add(E);
            else
                Console.WriteLine($"Employee already exists at club {ClubName}");
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee emp) && (Members?.Contains(emp) == true) &&
                (e.Cause == LayOffCause.NoVacationStock || e.Cause == LayOffCause.DidntAchieveTarget))
            {
                Members.Remove(emp);
                Console.WriteLine($"This is Club -{ClubName}-");
                Console.WriteLine($"employee {emp.EmployeeID} has been removed from the club\n\n");
            }
        }
    }
}
