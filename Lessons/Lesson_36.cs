using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     *      Перегрузка методов
     */

    /// <summary>
    /// Тест
    /// </summary>
    class Lesson_36
    {


        public static void Start()
        {
            Start_1();
        }

        public static void Start_1() 
        {
            //int result = Sum(2, 3);
            //int result = Sum(2, 3, 3);
            double result = Sum(2.4, 5.7);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Возвращает сумму целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>

        static int Sum(int a, int b) 
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
