using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     *     Ссылочные (reference types) и значимые (value types) типы
     * 
     *     Стек (stack) и куча (heap)
     */

    /// <summary>
    /// ССЫЛОЧНЫЕ И ЗНАЧИМЫЕ ТИПЫ C# | СТЕК И КУЧА C# | REFERENCE AND VALUE TYPES C# | C# Уроки | # 38
    /// </summary>
    class Lesson_38
    {
        public Lesson_38()
        {
        }

        public static void Start()
        {
            Start_8();
        }

        private static void Start_1()
        {
            int a = 5;
        }

        private static void Start_2()
        {
            Random random = new Random();
            Random random1 = random;
            Random random2 = new Random();
            Console.WriteLine((random == random1)); 
            Console.WriteLine((random1 == random2));
        }

        private static void Start_3() 
        {
            string st = "asdas";
            string st1 = "asdas";
            Console.WriteLine(st == st1);
        }

        private static void Start_4()
        {
            {
                int[] a = new int[10];
            }

        }

        private static void Start_5()
        {
            int[] a = new int[10];

            int[] b;

            b = a; 
        }

        private static void Start_6()
        {
            int[] a = new int[10];

            int[] b;

            b = a;
        }

        private static void Start_7()
        {
            int a = 1;

            Foo(a);

            Console.WriteLine(a);
        }

        private static void Start_8()
        {
            int [] a = new int[1];

            a[0] = 1;

            Bar(a);

            Console.WriteLine(a[0]);
        }

        private static void Foo(int value)
        {
            value = 5;
        }

        private static void Bar(int[] arr)
        {
            arr[0] = 5;
        }
    }
}
