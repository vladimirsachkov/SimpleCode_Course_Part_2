using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     *     оператор null-объединения   ??
     */

    /// <summary>
    ///   ОПЕРАТОР ОБЪЕДИНЕНИЯ С NULL С# | C# ?? | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 40
    /// </summary>
    class Lesson_40
    {
        public Lesson_40()
        {
        }

        public static void Start()
        {
            Start_3();
        }

        public static void Start_1()
        {
            string str = null;

            string result;

            if (str == null)
            {
                result = "нет данных";
            } 
            else
            {
                result = str;
            }

            Console.WriteLine(result);
        }

        public static void Start_2()
        {
            string str = null;

            string result = str ?? "нет данных";

            Console.WriteLine(result);
        }

        public static void Start_3()
        {
            string str = null;

            string result = str ?? "";

            Console.WriteLine("колличество символов в строке " + str.Length);
        }
    }
}
