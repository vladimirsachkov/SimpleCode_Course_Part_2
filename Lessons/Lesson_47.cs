using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{

    /// <summary>
    /// C# НЕОБЯЗАТЕЛЬНЫЕ ПАРАМЕТРЫ МЕТОДА (параметры по умолчанию) | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 47
    /// </summary>
    class Lesson_47
    {
        public Lesson_47()
        {
        }

        public static void Start()
        {
            Start_1();
        }

        public static void Start_1() 
        {
            int result = Sum(2, 5, true);
        }

        public static int Sum(int a, int b, bool enableLogging = false, int c = 42) 
        {
            int result = a + b;

            if (enableLogging)
            {
                Console.WriteLine("Значение переменной a = " + a);
                Console.WriteLine("Значение переменной b = " + b);
                Console.WriteLine("Результат сложения b = " + result);
            }

            return result;
        }
    }
}
