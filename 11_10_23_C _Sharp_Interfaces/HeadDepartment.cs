using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_23_C__Sharp_Interfaces
{
    internal class HeadDepartment : ISalary
    {
        public string? FullName { get; set; }
        public int WorkingDays { get; set; }
        public int CalculateSalary()
        {
            return WorkingDays * 2500;
        }
        public void Print()
        {                          
                Console.WriteLine($"{CalculateSalary()}");            
        }
    }
}
