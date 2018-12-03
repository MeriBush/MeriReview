using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class ListsProgram
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Sally");
            names.Add("Kvothe");
            names.Add("Samson");
            names.Add("Phelba");



            //--1--
            //PRINT SINGLE ITEM ON LIST
            #region
            //This syntax is the same as for arrays! If I know the items placement in the List, I can call it by its place number

            /*
            Console.WriteLine(names[1]);   
            Console.ReadLine();
            */
            #endregion



            //--2--   
            //PRINT LIST
            #region
            //NOTE:::  Arrays use arrayName.Length  BUT  Lists use listName.Count

            //Even though my list is of type string, I use the same int syntax here that I did for my array of type int. That's because this int refers to the string item's placement in the list, NOT the string item itself!

            /*
            for (int i = 0; i < names.Count; i++)  
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            #endregion



            //--3--
            //REMOVE SINGLE ITEM ON LIST BY WHERE IT IS LOCATED IN THE LIST
            #region

            /*
            names.RemoveAt(0);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */
            #endregion



            //--4--
            //REMOVE A SINGLE ITEM ON LIST BY VALUE
            #region

            /*
            names.Remove("Sally");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */
            #endregion
        }
    }
}
