using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArraysProgram
    {
        public static void Main(string[] args)
        {
            #region //--> SINGLE DIMENSIONAL ARRAYS <--\\


            //-- INSTANTIATE --
            #region
            /*
            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;
            */
            #endregion



            //--1--
            //PRINT SINGLE ITEM IN ARRAY
            #region
            //Console.WriteLine(numbers[1]);
            #endregion



            //--2--
            //PRINT ARRAY with FOREACH loop
            #region
            /*
            foreach (int i in numbers)
            {
                Console.Write(i + ", ");
            }
            Console.ReadLine();
            */
            #endregion



            //--3--
            //PRINT ARRAY with FOR loop
            #region
            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.ReadLine();
            */
            #endregion

            #endregion

            #region //--> TWO DIMENTIONAL ARRAYS <--\\                                  


            //Create two objects of type int. We will use these in step two to define the height and width parameters of our grid.
            #region  //-- STEP ONE --
            /*
            int width = 5;
            int height = 5;
            */
            #endregion


            //-- STEP TWO --
            //Create grid! Use the int objects we created to define height and width parameters of your grid.
            #region
            /*
            int[,] grid = new int[width, height];
            grid[2, 3] = 5;          //Here we place the value 5 in the grid at row 2 and column 3. (NOTE: Grids start counting at 0)
            */                         //Think of it like hiding treasure in a video game map. This is the foundation for such games!
            #endregion


            //-- STEP THREE --
            //Double FOR LOOPS!
            #region STEP THREE: Double FOR LOOPS
            //These will loop through the x axis (width) first, followed by the y axis (height)
            /*
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Console.Write(grid[x,y] + " ");       //Important to have Console.Write here and Console.WriteLine below in order to print a grid format
                }
            Console.WriteLine();
            }
            Console.ReadLine();
            */
            #endregion

            #endregion

            #region //--> JAGGED ARRAYS <--\\
            /*
            int[][] parties = new int[3][];
            parties[0] = new[] { 25, 28, 30, 32, 3 };
            parties[1] = new[] { 13, 45, 78, 84, 7, 11, 10 };
            parties[2] = new[] { 1, 30, 30 };
            */
            #endregion
        }
    }
}
