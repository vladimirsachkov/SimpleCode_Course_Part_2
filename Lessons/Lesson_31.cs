using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     * вывод двумерного массива
     */

    class Lesson_31
    {
        public Lesson_31()
        {
        }

        public void Start()
        {
            Start_2();
        }

        private void Start_1()
        {
            int[,] myArray = new int[,]
            {
                { 2,45,12,51, 51},
                { 6,7,8,3, 1},
                { 1,5, 65, 78,13},
                { 6,3,151,5,65}
            };

            foreach (var item in myArray) 
            { 
                Console.Write(item + " ");
            }
        }

        private void Start_2() 
        {
            int[,] myArray = new int[,]
            {
                { 2,45,12,51, 51},
                { 6,7,8,3, 1},
                { 1,5, 65, 78,13},
                { 6,3,151,5,65},
                { 6,3,11,1,3}
            };

            //int[,,] myArray_1 = new int[2,5,65];

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);

            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++) {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
