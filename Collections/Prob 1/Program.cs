/*
Author: Amina Khan
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4
  Prob 1 - Arrays and Lists

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming Assignment 4 - Prob 1 \n");
            #region 1 - Simple array
            //create an array of int of size 5
            int[] intArray = new int[5];

            //using a for loop to initializing to the numbers 11 - 15
            for (int i = 0; i < 5; i++)
            {
                intArray[i] = 11 + i;
            }

            Console.WriteLine("Region 1 : Simple Array");
            //using a foreach loop to print out the values in array
            foreach (int element in intArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            #endregion

            #region 2 - List<T>
            //create a list of int
            List<int> intList = new List<int>();

            //use a for loop to initialize the list to the numbers 21 - 25
            for (int i = 0; i < 5; i++)
            {
                intList.Add(21 + i);
            }

            Console.WriteLine("Region 2 : List<T>");

            //use a foreach loop to print out the values in the list
            foreach (int element in intList)
            {
                Console.WriteLine(element);
            }

            //update the values in the list to 31 - 35 using indexing
            Console.WriteLine("Updating List items...");
            for (int i = 0; i < intList.Count; i++)
            {
                intList[i] = intList[i] + 10;
            }
            Console.WriteLine();

            //repeat the print using a for loop and indexing
            Console.WriteLine("Updated List items");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            Console.WriteLine();
            #endregion

        }
    }
}
