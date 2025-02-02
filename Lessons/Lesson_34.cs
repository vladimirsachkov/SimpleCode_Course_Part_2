using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCode_Course_Part_2
{
    /*
     * трёхмерные и более массивы
     */

    class Lesson_34
    {
        public Lesson_34()
        {
        }

        public void Start()
        {
            //Start_1();
            Start_3();
        }

        private void Start_1()
        {
            Random random = new Random();

            int[,,] myArray = new int[4, 3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(100);
                    }
                }
            }



            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №: " + (i + 1));

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("======================================");
            }

            //Console.WriteLine(myArray[0, 2, 3]);
        }

        private void Start_2() 
        {
            Random random = new Random();

            int[,,,] myArray = new int[3, 2, 3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            myArray[i, j, k, q] = random.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine("== Book №: " + (i + 1) + " ==");

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Page №: " + (j + 1) + " ==");
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int q = 0; q < myArray.GetLength(3); q++)
                        {
                            Console.Write(myArray[i, j, k, q] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }


        private void Start_3()
        {
            Random random = new Random();

            int[][][] myArray = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int [random.Next(2, 6)][];

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(2, 6)];

                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Page №: " + (i + 1) + " ==");

                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
