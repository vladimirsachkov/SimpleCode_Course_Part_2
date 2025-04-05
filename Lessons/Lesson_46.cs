using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{

    /// <summary>
    /// Ключевое слово params
    /// </summary>
    class Lesson_46
    {
        public Lesson_46()
        {
        }

        public static void Start() 
        {
            Start_2();
        }

        public static void Start_1() 
        {
            int result = Sum("test", 1, 2, 4, 5);

            Console.WriteLine(result);
        }

        private static void Start_2() 
        {
            Foo("test", 5, 'q', 5.89f, true);
        }

        //private static int Sum(int a, int b) 
        //{ 
        //    return a + b;
        //}

        //private static int Sum(int a, int b, int c, int d)
        //{
        //    return a + b + c;
        //}

        //private static int Sum(int[] parameters) 
        //{
        //    int result = 0;

        //    for (int i = 0; i < parameters.Length; i++)
        //    {
        //        result += parameters[i];
        //    }

        //    return result;
        //}

        private static int Sum(string messege, params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        private static void Foo(params object[] parameters)
        {
            string message = "Тип данных {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
    }
}
