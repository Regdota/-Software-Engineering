using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pay
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 10000, d=6000, pay;

            Console.WriteLine("Сумму выручки:");
            pay = Convert.ToInt32(Console.ReadLine());
            
            if(pay<=d && c)
            {
                Console.WriteLine("Зарплата работника: 300");
            }
            else if (pay <= c)
            {
                Console.WriteLine("Зарплата работника:");
                Console.WriteLine(pay * a/100);
            }
            else
            {
                Console.WriteLine("Зарплата работника:");
                Console.WriteLine((pay-c)*b/100 + c*a/100);
            }
            Console.WriteLine("Нажмите ENTER что бы выйти из программы");
            Console.ReadKey();
        }
    }
}
