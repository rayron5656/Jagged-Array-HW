using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray_HW_24._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            string[] word = new string[5];
            Array.Sort(word); // sort number from the smallest to the biggest by default and strings by alphabetic order
            word.GetLength(0); // set number equal to the length of the array in a specific dimension

            char[,,,] chardim = new char[2, 3, 4, 1]; // Rank return amount of dimensions in an array
            Console.WriteLine(chardim.Rank);

            double[] DBarry = { 1.2, 3.5, 12.4 };

            int index = Array.IndexOf(DBarry, 1.2); // indexof return the location in  the array with the requested value
            int index2 = Array.IndexOf(DBarry, 5); // return -1 if doesnt exist
            #endregion

            #region question 2

            int[] MyIntArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int tries = 0;
            int localtries = 1;
            int x = 0;
            while (x < 10 || tries == 30)
            {
                Console.WriteLine($"guess the {x + 1} number");
                int guess = int.Parse(Console.ReadLine());
                int ind = Array.IndexOf(MyIntArr, guess);

                if (ind == x)
                {
                    Console.WriteLine($"nice guess, you made the {x + 1} number after {localtries} guesses");
                    x++;
                    localtries = 1;

                }
                else
                {
                    Console.WriteLine("wrong!");

                    localtries++;
                }
                tries++;
            }
            if (tries == 30)
            {
                Console.WriteLine("game over!");
            }
            else
            {
                Console.WriteLine($"Good Job, you guessed all numbers after {tries} guesses");
            }
            #endregion

            #region question 3

            int[,] DimArryQST3 = new int[5, 5]
            {
              {1,3,4,4,5 },
              {8,5,6,4,10},
              {5,2,7,9,10},
              {7,8,1,2,4 },
              {9,4,6,1,2 }
            };

            Console.WriteLine("enter a number");
            int number3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (DimArryQST3[j, i] == number3)
                    {
                        Console.WriteLine($"number is in collum: {j + 1} and row: {i + 1}");
                    }
                }
            }
            #endregion

            #region question 4
            int[,] dimarray = new int[10, 10];


            for (int i = 0; i < dimarray.GetLength(0); i++)
            {
                for (int j = 0; j < dimarray.GetLength(1); j++)
                {

                    dimarray[i, j] = ((i + 1) * (j + 1));

                    Console.Write($"\t{dimarray[i, j]}");

                }
                Console.WriteLine();

            }
            #endregion

            #region question 5 

            int[,] subMArray =
                {
                {1,0,1 },
                {1,0,0 },
                {0,1,1 }
            };
             tries = 0;
            int checker = 0;

            for (int i = 0; i < 8; i++) // 8 number of tries
            {
                checker = 0;
                Console.WriteLine("enter a row");
                int row = int.Parse(Console.ReadLine());
                row--;
                Console.WriteLine("enter a collum");
                int collum = int.Parse(Console.ReadLine());
                collum--;

                if (subMArray[row, collum] == 1)
                {
                    Console.WriteLine("BOOM!");
                    subMArray[row, collum] = 0;
                }
                else
                {
                    Console.WriteLine("Miss!");
                }
                tries = i + 1;


                for (int k = 0; k < 3; k++) // check if there any subs left
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (subMArray[j, k] != 1)
                        {
                            checker++;
                        }

                    }

                }
                if (checker == 9)
                {
                    Console.WriteLine($"you did it on {tries} tries");
                    break;
                }


            }
            if (checker != 9)
            {
                Console.WriteLine("game over");
            }


            #endregion

            #region question 6

            int[,,] triDimArry = new int[2, 2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine("enter a number");
                        triDimArry[i, k, j] = int.Parse(Console.ReadLine());
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(triDimArry[i, k, j]);

                    }
                }
            }


            #endregion

            #region question 7

            string[,] dimarry7 = new string[6, 4]
            {
                { "*", "*","*","*",},
                { "*","*","*","*" },
                { "*","*","*","*" },
                { "*","*","*","*" },
                { "*","*","*","*"},
                { "*","*","*","*"},
            };

            for (int i = 0; i < 6; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(dimarry7[i, k]);
                }
                Console.WriteLine();
            }


            #endregion

            #region questiong 8

            #endregion*/

            #region question 9

            Console.WriteLine("enter number of classrooms");
            int classroomslength = int.Parse(Console.ReadLine());

            int[][] biDimArry2 = new int[classroomslength][];

            for (int i = 0; i < classroomslength; i++)
            {
                Console.WriteLine($"enter number of students in class #{i+1}");
                int studentslength = int.Parse(Console.ReadLine());
                biDimArry2[i] = new int[studentslength];
            }

            for (int i = 0; i < biDimArry2.Length; i++ )
            {
                for (int k = 0; k < biDimArry2[i].Length ; k++)
                {
                    Console.WriteLine($"enter the #{k+1} student grade in class #{i+1}");
                    int studentgrade = int.Parse(Console.ReadLine());
                    biDimArry2[i][k] = studentgrade;
                }
            }

            float[] ClassAvgAry = new float[biDimArry2.Length];

            for (int i = 0; i < biDimArry2.Length; i++)
            {
                int Localsum = 0;
                for (int k = 0; k < biDimArry2[i].Length; k++)
                {
                    Localsum += biDimArry2[i][k];
                }
                ClassAvgAry[i] = Localsum / biDimArry2[i].Length;
            }
             x = 0;
            float currenthighest = 0;
            for (int i = 0; i < ClassAvgAry.Length; i++)
            {
                if (i == 0)
                {
                    currenthighest = ClassAvgAry[i];
                    x = 0;
                }
                else if (currenthighest < ClassAvgAry[i])
                {
                    x = i;
                }
                
                
            }

            Console.WriteLine($"the class with the highest avarage is class #{x + 1}");
            


            

            #endregion
        }
    }
}
