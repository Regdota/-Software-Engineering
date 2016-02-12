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
        
        int  a = 5, b = 10, f = 300, d = 6000, c= 10000, one, two, three, four, five, six, seven, rezone, reztwo, rezthree, rezfour, rezfive, rezsix, rezseven, rez;
            
            Console.WriteLine("Сумма выручки в понедельник:");
            one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки во вторник:");
            two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки в среду:");
            three = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки в четверг:");
            four = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки в пятницу:");
            five = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки в субботу:");
            six = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма выручки в воскресение:");
            seven = Convert.ToInt32(Console.ReadLine());

           
             if(one<=d)
            {
                rezone = f;
            }
            else if (one <= c)
            {
                rezone = one * a/100;
            }
            else
            {
                rezone = (one - c) * b / 100 + c * a / 100;
            }


         if( two <=d )
            {
                reztwo = f;
            }
            else if (two <= c)
            {
                reztwo = two * a / 100;
            }
            else
            {
                reztwo = (two - c) * b / 100 + c * a / 100;
            }
          


 if(three<=d)
            {
                rezthree = f;
            }
            else if (three <= c)
            {
                rezthree = three * a / 100;
            }
            else
           {
               rezthree = (three - c) * b / 100 + c * a / 100;
           }

 if(four<=d)
            {
                rezfour = f;
            }
            else if (four <= c)
            {
                rezfour = four * a / 100;
            }
            else
            {
                rezfour = (four - c) * b / 100 + c * a / 100;
            }

 if(five<=d)
            {
                rezfive = f;
            }
            else if (five <= c)
            {
                rezfive = five * a / 100;
            }
            else
            {
                rezfive = (five - c) * b + c * a / 100;
            }
          

 if(six<=d)
            {
                rezsix = f;
            }
            else if (six <= c)
            {
                rezsix = six * a / 100;
            }
            else
            {
                rezsix = (six - c) * b + c * a / 100;
            }
          

 if(seven<=d)
            {
                rezseven = f;
            }
            else if (seven <= c)
            {
                rezseven = seven * a / 100;
            }
            else
            {
                rezseven = (seven - c) * b / 100 + c * a / 100;
            }

            rez = rezone + reztwo + rezthree + rezfour + rezfive + rezsix + rezseven;
            Console.WriteLine("Зарплата работника: " + rez);
    }                         
    }
}
