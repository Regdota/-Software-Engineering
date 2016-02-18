using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 10000, d = 6000, r=100000, f= 15, g=300, y=100, sum;
            int o, t, th, fo, fi, six, seven;



            Console.WriteLine("Понедельник:");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вторник:");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среда:");
            th = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Четверг:");
            fo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пятница:");
            fi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Суббота:");
            six = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Воскресение:");
            seven = Convert.ToInt32(Console.ReadLine());


            int[] myArr = new int[7];

            // Инициализируем каждый элемент массива вручную 
            myArr[0] = o;
            myArr[1] = t;
            myArr[2] = th;
            myArr[3] = fo;
            myArr[4] = fi;
            myArr[5] = six;
            myArr[6] = seven;








            for (int i = 0; i < 4; i++)
            {

                if (myArr[i] <= d)
                {
                    myArr[i] = g;
                }
                if (myArr[i] <= c)
                {
                    myArr[i] = myArr[i] * a / y;
                }               
                if (myArr[i] > c)
                {
                    myArr[i] = (myArr[i] - c) * b / y + c * a / y;
                }
                if (myArr[i]>r)
                {
                    myArr[i] = myArr[i] * f / y;
                }

            }



            /*-------------------------*/
            for (int i = 5; i < 6; i++)
            {

                if (myArr[i] <= d)
                {
                    myArr[i] = g * 2;
                }
                if (myArr[i] <= c)
                {
                    myArr[i] = myArr[i] * a / y * 2;
                }
                if (myArr[i] > c)
                {
                    myArr[i] = (myArr[i] - c) * b / y * 2 + c * a / y * 2;
                }
                if (myArr[i] > r)
                {
                    myArr[i] = myArr[i] * f / y * 2;
                }

               
            }
            /*-------------*/

            /*Не правильно работает...*/
            Console.WriteLine("Зарплата: " + myArr.Sum());
            
                
  
            
          

            Console.ReadKey();


        }
    }
}
