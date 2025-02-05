using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCode_Course_Part_2
{
    /*
     *      Область видимости, или контекст переменной
     *      Конфликты областей переменной.
     */

    /// <summary>
    /// ОБЛАСТЬ ВИДИМОСТИ | КОНТЕКСТ ПЕРЕМЕННОЙ | КОНФЛИКТЫ ОБЛАСТЕЙ ВИДИМОСТИ | C# Уроки | # 37
    /// </summary>
    class Lesson_37
    {
        static int a = 11;
        static int b = 11;


        public Lesson_37()
        {
        }

        public static void Start() 
        {
            Foo_2();
        }

        public static void Start_1() {
            int a = 2;
            for (int i = 0; i < 10; i++)
            {
                i++;
                a++;
            }

            a++;
        }

        public static void Start_2() 
        { 
            Lesson_37 lesson_37  = new Lesson_37();
            a = 0;
        }

        private void Foo()
        {
            a++;
        }

        static void Foo_1() 
        {
            int b = 9;
        }

        static void Foo_2()
        {
            int b = 9;
            Console.WriteLine();
        }
    }
}
