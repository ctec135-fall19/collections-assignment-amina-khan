/*
Author: Amina Khan
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4
  Prob 3 - Dictionary

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a dictionary and initialization it to create
            // 3 entries: (1, "one"), (2, "two"), and(3, "three").
            // Use a combination of initialization syntax, Add() 
            // and[] in your initialization code.

            Dictionary<int, string> myDictionary = new Dictionary<int, string> { [1] = "one" };
            myDictionary[2] = "two";
            myDictionary.Add(3, "three");

            // add an additional entry: (99, "ninety-nine")
            myDictionary.Add(99, "ninety-nine");


            // show use of enumerator to see all entries. Print both the key and value
            Console.WriteLine("\nPrinting Key and Values of Dictionary");
            foreach (int key in myDictionary.Keys)
            {
                Console.WriteLine("the key is : {0} and value is: {1}", 
                    key, myDictionary[key]);
            }
            Console.WriteLine();


            // reassign the value of 99 to "99" using indexing notation
            myDictionary[99] = "99";
            Console.WriteLine();

            // print the new value using indexing notation
            Console.WriteLine("Value of 99 after changing: {0}\n", myDictionary[99]);

            // remove the 2 item and enumerate over the whole dictionary to show it's gone
            myDictionary.Remove(2);

            Console.WriteLine("Values after removing 2");
            foreach (int key in myDictionary.Keys)
            {
                Console.WriteLine("the key is : {0} and value is: {1}",
                    key, myDictionary[key]);
            }
            Console.WriteLine();

        }
    }
}
