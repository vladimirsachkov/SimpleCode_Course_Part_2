using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     * индексы и диапазоны в С#8
     */

    class Lesson_28
    {
        public Lesson_28()
        {
        }

        public void Start() 
        {
            Start_3();
        }

        private void Start_1()
        {
            //int a = 2;
            int[] myArray = { 2, 10, 3, 6, 77, 89, 11414 };
            //int[] myArray2 = myArray[1..4];
            //int[] myArray2 = myArray[..4];
            //int[] myArray2 = myArray[..a];
            //int[] myArray2 = myArray[5..];

            //Index myIndex = ^2;

            //Console.WriteLine(myArray[myIndex]);

            //Index myIndex = ^1;
            //Index myIndex = 3;
            Index myIndex = new Index(3, true);

            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine();
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
        }

        private void Start_2()
        {
            //int a = 2;
            int[] myArray = { 2, 10, 3, 6, 77, 89, 11414 };

            //Range myRange = 1..4;
            //Range myRange = new Range(1, 4); // 1..4
            //Range myRange = ^4..^1;

            int[] myArray_2 = myArray[^4..^1];
        }


        private void Start_3()
        {
            string str = "Hello World !!! =)";

            Console.WriteLine(str[6..11]);
        }
    }
}