using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleCode_Course_Part_2
{

    /// <summary>
    /// Оператор условного null ?.
    /// </summary>
    /// 
    class Lesson_42
    {
        public Lesson_42()
        {
        }

        public static void Start() { 
            Start_2();
        }

        private static void Start_1() {
            int[] myArray = GetArray();

            if (myArray != null) 
            {
                Console.WriteLine("сумма элементов массива 0");
            }
            else
            {
                Console.WriteLine("сумма элементов массива " + myArray.Sum());
            }
        }
        private static void Start_2() 
        {
            int[] myArray = GetArray();

            Console.WriteLine("сумма элементов массива " + (myArray?.Sum() ?? 0));
        }

        static int[] GetArray() {
            //int[] myArray = {1, 2, 3};
            int[] myArray = null;
            return myArray;
        }
    }
}
