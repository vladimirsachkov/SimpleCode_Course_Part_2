using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    class Lesson_33
    {
        /*
         * Ступенчатые (зубчатые массивы)
         */

        public Lesson_33()
        {
        }

        public void Start()
        {
            //Start_1();
            Start_2();
        }

        private void Start_1()
        {
            int[][] myArray = new int [3][];
            //int[,] myArray2 = new int [3, 5];

            //int myArrayRank = myArray.Rank;
            //int myArray2Rank = myArray2.Rank;

            //int myArrayLenght = myArray.Length;
            //int myArray2Length = myArray2.Length;

            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[10];

            myArray[0][3] = 55;
            int[] arr = myArray[0];

            Console.WriteLine(myArray[0][3]);
        }

        private void Start_2() 
        {
            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[10];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
