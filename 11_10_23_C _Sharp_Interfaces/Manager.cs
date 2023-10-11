using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_23_C__Sharp_Interfaces
{
    internal class Manager : ISalary
    {
        
            public string? FullName { get; set; }
            public int WorkingDays { get; set; }
            public int CalculateSalary()=>WorkingDays * 100;
            public void Print()
            {
                Console.WriteLine($"{FullName}");
                Console.WriteLine($"{WorkingDays}");
            }
    }
    
}    
    

