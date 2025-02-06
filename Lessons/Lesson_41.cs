using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     *      оператор присваевания объединения со значением Null ??=
     */

    /// <summary>
    /// ОПЕРАТОР ПРИСВАИВАНИЯ ОБЪЕДИНЕНИЯ СО ЗНАЧЕНИЕМ NULL в C# 8 | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 41
    /// </summary>
    class Lesson_41
    {
        public Lesson_41()
        {
        }

        public static void Start()
        {
            Start_3();
        }

        public static void Start_1()
        {
            string str = null;

            string result = str ?? "default string";

            Console.WriteLine("количество символов в строке " + result.Length);
        }

        public static void Start_2()
        {
            //string str = null;

            string str = "test";

            str ??= string.Empty;

            Console.WriteLine("количество символов в строке " + str.Length);
        }

        public static void Start_3()
        {
            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("количество символов в строке " + myArray.Length);
        }

        public static int[] GetArray()
        {
            int [] myArray = new int[11];

            return myArray;
        }
    }
}
