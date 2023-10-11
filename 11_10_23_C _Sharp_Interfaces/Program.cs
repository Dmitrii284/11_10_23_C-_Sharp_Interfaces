/*
 IInterface - Пишется с Букывой I 
Интерфейс не может содержать Поля 

interface IInterface
        {
            void Ball(int x);
            int b; - Так не может содержать т.к Это поле.
        }

interface - Может содержать 

Contr - Shift - a


 */


//using System.Runtime.CompilerServices;

//namespace _11_10_23_C__Sharp_Interfaces
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");


//        }

//        interface IInterface
//        {

//            //int b; - так нельзя

//            const int a = 10;
//            static int b;
//            public int  C{ get; set; }
//           public void Ball(int x);


//        }

//        interface IInterface2
//        {
//            static IInterface2 () { } // Это конструктор 
//            void Ball(int x);
//        }

//        class C1 { }
//        class C2 { }

//        class C3 : C1, IInterface2, IInterface
//        {
//            private int abc {get; set;}
//            public int A { get; set; }

//            public int C { get; set; }
//            public void Ball(int x)
//            {
//                this.abc = 0;
//            }
//        }

//    }
//}


using System.Runtime.CompilerServices;

namespace _11_10_23_C__Sharp_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Manager manager = new Manager
            {
                FullName = "John Smith",
                WorkingDays = 20
            };

            float managerSalary = manager.CalculateSalary();
            Console.WriteLine($"Manager's salary: {managerSalary}");

            HeadDepartment departmentHead = new HeadDepartment
            {
                FullName = "Jane Doe",
                WorkingDays = 22
            };


            float departmentHeadSalary = departmentHead.CalculateSalary();
            Console.WriteLine($"Department Head's salary: {departmentHeadSalary}");

            Accounting accounting = new Accounting();

            float incomeTax = accounting.CalculeitIncomTex(manager);
            Console.WriteLine($"Income tax: {incomeTax}");

            incomeTax = accounting.CalculeitIncomTex(departmentHead);
            Console.WriteLine($"Income tax: {incomeTax}");

            manager.Print();
            departmentHead.Print();

        }
    }
}