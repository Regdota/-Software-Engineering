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
            float a = 0.05f, b = 0.1f, c = 10000, d = 6000, pay;

            Console.WriteLine("Сумму выручки:");
            pay = Convert.ToInt32(Console.ReadLine());

            if (pay <= d)
            {
                Console.WriteLine("Зарплата работника: 300");
            }
            else if (pay <= c)
            {
                Console.WriteLine("Зарплата работника:");
                Console.WriteLine(pay * a );
            }
            else
            {
                Console.WriteLine("Зарплата работника:");
                Console.WriteLine((pay - c) * b + c * a);
            }
            Console.WriteLine("Нажмите ENTER что бы выйти из программы");
            Console.ReadKey();
        }
    }
}
