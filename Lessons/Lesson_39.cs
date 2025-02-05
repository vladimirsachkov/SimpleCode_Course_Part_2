using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     *    что такое null
     */

    /// <summary>
    /// ЧТО ТАКОЕ NULL | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 39
    /// </summary>
    class Lesson_39
    {
        public Lesson_39()
        {
        }

        public static void Start()
        {
            Start_5();
        }

        private static void Start_1() 
        {
            bool b;

            int a;

            double d;

            Random random;

            int[] arr;

            MyClass myClass;

            MyStruct myStruct;
        }

        private static void Start_2()
        {
            int[] a;
        }

        private static void Start_3()
        {
            int[] a;

            a = new int[10];
        }

        private static void Start_4()
        {
            int[] a;

            a = new int[10];

            a = null;
        }

        private static void Start_5()
        {
            int[] a = new int[10];
            
            a = null;

            Console.WriteLine(a[0]);
        }

        private static void Foo()
        {
            int[] a = new int[10];
        }
    }


    class MyClass
    {

    }

    struct MyStruct
    {

    }
}
