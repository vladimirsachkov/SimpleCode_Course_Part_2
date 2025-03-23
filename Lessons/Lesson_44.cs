using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /// <summary>
    /// КЛЮЧЕВОЕ СЛОВО OUT C# | РАЗНИЦА между REF и OUT C# | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 44
    /// 
    /// Ключевое слово ref и out
    /// </summary>
    class Lesson_44
    {
        public Lesson_44()
        {
        }

        public static void Start()
        {
            Start_3();
        }

        public static void Start_1() 
        {
            int a = 10;
            Foo(ref a);
        }

        public static void Start_2() 
        {
            Bar(out int a);
            Console.WriteLine(a);
        }

        public static void Start_3() 
        {
            string str = Console.ReadLine();
            
            int.TryParse(str, out int result);

            Console.WriteLine(result);
        }

        public static void Foo(ref int value) 
        { 
            value++;
            Console.WriteLine(value);
        }

        public static void Bar(out int value)
        {
            value = 10;
        } 
    }
}
