using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
    *   Функции и методы в c#
    */

    //  модификаторы тип_возвращаемого_значения название_метода(параметры)
    //  {
    //      тело метода
    //  }
    
    class Lesson_35
    {

        public static void Start()
        {
            //Start_1();
            //Start_2();
            Start_3();
        }

        private static void Start_1()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);
            
            
            Console.WriteLine(c);

            Console.WriteLine("=====================");
        }

        private static void Start_2()
        {
            //PrintLine();
            Random random = new Random();
            Console.WriteLine(random.Next());
        }

        private static void Start_3()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);


            PrintResult(c);

            Console.WriteLine("=====================");
        }

        static void PrintLine()
        {
            Console.WriteLine("Метод PrintLine был вызван!");
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        }

        static int Sum(int value_1, int value_2) 
        {
            return value_1 + value_2;
        }

        
    }
}
