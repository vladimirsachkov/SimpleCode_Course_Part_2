using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    class Lesson_30
    {
        /*
         * инициализация
         * 
         * обращение к элементам двумерного массива
         */

        public Lesson_30()
        {
        }

        public void Start()
        {
            Start_1();
        }

        private void Start_1()
        {
            // Тип данных [,] имя массива
            //int[,] myArray;
            //myArray = new int[3, 5];

            //int[,] myArray = new int[3, 5];

            //myArray[2, 2] = 99;

            //Console.WriteLine(myArray[10, 2]);

            //int[,] myArray = new int[3, 5] {
            //    {2, 45, 12, 51, 51}, 
            //    {6, 7, 8, 3, 1}, 
            //    {1, 5, 65, 78, 13},
            //};


            int[,] myArray = new int[,] {
                {2, 45, 12, 51, 51},
                {6, 7, 8, 3, 1},
                {1, 5, 65, 78, 13},
                {6, 3 , 151, 5, 65 }
            };
        }

        //private void Start_2() 
        //{
            
        //}
    }
}
