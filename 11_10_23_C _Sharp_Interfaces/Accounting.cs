using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_23_C__Sharp_Interfaces
{
    internal class Accounting
    {
        public Accounting() { }
        public float CalculeitIncomTex(ISalary salary) 
        {
            return (salary.CalculateSalary()) * 0.13f;
        }

    }
}
