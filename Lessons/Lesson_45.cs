using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{

    /// <summary>
    /// МОДИФИКАТОР IN C# и бенчмарк | РАЗНИЦА между IN REF и OUT | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 45
    /// 
    /// ключевое слово in
    /// </summary>
    class Lesson_45
    {
        public Lesson_45()
        {
        }

        public static void Start() 
        {
            Start_2();
        }

        public static void Start_1() 
        {
            int a = 5;

            Foo(a);
        }

        public static void Start_2()
        {
            //Point a = new Point();

            MyStruct a = new MyStruct();

            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++) {
                FooP(a);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                BarP(a);
            }

            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }

        static void Foo(in int value)
        {
            Console.WriteLine(value);
            //value = 5;
        }

        struct Point 
        {
            public float x;
            public float y;
            public float z;
        }

        struct MyStruct
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal d;
            public decimal e;
            public decimal f;
            public decimal g;
            public decimal h;
            public decimal i;
        }

        static void FooP(MyStruct value)
        {

        }

        static void BarP(in MyStruct value) 
        { 
            
        }

    }
}
