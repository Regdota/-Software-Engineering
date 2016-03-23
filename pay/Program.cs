using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pay2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 10000, d = 6000, r = 100000, f = 15, g = 300, y = 100, sum = 0, sb = 0, sv = 0 ;
            


            Console.WriteLine("Сколько отработано будних дней: ");
            int sizeb = int.Parse(Console.ReadLine());
            int[] myArr = new int[sizeb];


            Console.WriteLine("Сколько отработано выходных дней: ");
            int sizev = int.Parse(Console.ReadLine());
            int[] myArr2 = new int[sizev];


            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("Введите запрплату за будний день:");
                myArr[i] = int.Parse(Console.ReadLine());

                if (myArr[i] <= d)
                {
                    myArr[i] = g;
                    sb = sb + myArr[i];

                }
                if (myArr[i] <= c && myArr[i] > d)
                {
                    myArr[i] = myArr[i] * a / y;
                    sb = sb + myArr[i];
                }
                if (myArr[i] > c && myArr[i] <= r)
                {
                    myArr[i] = (myArr[i] - c) * b / y + c * a / y;
                    sb = sb + myArr[i];
                }
                if (myArr[i] > r)
                {
                    myArr[i] = myArr[i] * f / y;
                    sb = sb + myArr[i];
                } 
            }



            for (int i = 0; i < myArr2.Length; i++)
            {
                Console.WriteLine("Введите запрплату за выходной день:");
                myArr2[i] = int.Parse(Console.ReadLine());

                if (myArr2[i] <= d)
                {
                    myArr2[i] = g * 2;
                    sv = sv + myArr2[i];

                }
                if (myArr2[i] <= c && myArr2[i] > d)
                {
                    myArr2[i] = (myArr2[i] * a / y) * 2;
                    sv = sv + myArr2[i];
                }
                if (myArr2[i] > c && myArr2[i] <= r)
                {
                    myArr2[i] = ((myArr2[i] - c) * b / y + c * a / y) * 2;
                    sv = sv + myArr2[i];
                }
                if (myArr2[i] > r)
                {
                    myArr2[i] = (myArr2[i] * f / y) * 2;
                    sv = sv + myArr2[i];
                }
                Console.WriteLine(sv);
            }
            sum = sb + sv;
            Console.WriteLine("Зарплата работника: " +sum);


            Console.ReadKey();
        }
    }
}
