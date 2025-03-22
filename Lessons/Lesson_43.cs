using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{

    /// <summary>
    /// КЛЮЧЕВОЕ СЛОВО REF C# | C# ref что это и для чего нужно | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 43
    /// 
    /// ключевое слово ref
    /// 
    /// передача аргументов по ссылке
    /// </summary>
    class Lesson_43
    {
        struct MyStruct
        {
            public int a;
            public double b;
            public float c;
        }

        class MyClass
        {
            public int a;
            public double b;
            public float c;
        }

        public Lesson_43()
        {
        }

        public static void Start() 
        {
            Start_7();
        }

        public static void Start_1()
        {
            int a = 2;

            Foo(ref a);

            Console.WriteLine(a);
        }

        public static void Start_2()
        {
            MyStruct myStruct = new MyStruct();

            Foo_1(ref myStruct);

            Console.WriteLine(myStruct);
        }

        public static void Start_3()
        {
            MyClass myClass = new MyClass();

            Foo_2(myClass);
        }

        public static void Start_4() 
        {
            int[] myArray = { 1, 4, 6 };

            Bar(ref myArray);
        }

        public static void Start_5()
        {
            int[] myArray = { 1, 4, 6 };

            Bar_1(myArray);
        }

        public static void Start_6()
        {
            int[] myArray = { 1, 4, 6 };

            Bar_2(ref myArray);
        }

        public static void Start_7() 
        {
            int[] arr = { 2, 6, 1 };

            ref int b = ref Foo_3(ref arr);

            b = -5;
        }

        static void Foo(ref int a) 
        {
            a = -5;
        }

        static void Foo_1(ref MyStruct myStruct)
        {
            myStruct.a = -5;
        }

        static void Foo_2(MyClass myClass)
        {
            myClass.a = -5;
        }

        static ref int Foo_3(ref int[] numbers)
        {
            return ref numbers[0];
        }

        static void Bar(ref int[] arr) 
        {
            //myArray[0] = -5;
            arr = null;
        }

        static void Bar_1(int[] arr)
        {
            arr = new int [10];
        }

        static void Bar_2(ref int[] arr)
        {
            arr = new int[10];
        }
    }
}
