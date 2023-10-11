using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_23_C__Sharp_Interfaces
{
     interface ISalary
    {       
           public string FullName { get; set; }
           public int WorkingDays { get;set; }
           public int CalculateSalary();
           public void Print();
    }
}
