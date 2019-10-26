/*
Author: Amina Khan
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4
  Prob 4 - Linked List

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate use of constructor taking an IEnumerable object.
            // Create a string array having the first 5 - 10 words of your 
            // favorite nursery rhyme. Use it as the argument when constructing 
            // the LinkedList object.
            string[] rhyme = {"Happy", "Birthday", "To", "You", "Bill"};
            
            LinkedList<string> llRhyme = new LinkedList<string>(rhyme);


            // Print out the rhyme on a single line.

            foreach (string element in llRhyme)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
            Console.WriteLine();


            // The traditional way to walk a linked list is to start at the 
            // head, process the node, then set the node variable to the next 
            // node in the list. Create a node variable and walk the list to print 
            // out the values. The line printed should be the same as the one above.

            LinkedListNode<string> llNodeRhyme = llRhyme.First;
            while (llNodeRhyme != null)
            {
                Console.Write("   {0}", llNodeRhyme.Value);
                llNodeRhyme = llNodeRhyme.Next;
            }
            Console.WriteLine();

            Console.WriteLine("\nRemoving a word from list.." +
                ".\n");
            // Remove a word from the middle of the list. Print the list on a 
            // single line to demonstrate this
            llRhyme.Remove("To");
            
            // printing list
            foreach (string element in llRhyme)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            // Add the word back in and print the list again to demonstrate.
            Console.WriteLine("\nAdding word back to the list.." +
                ".\n");
            llNodeRhyme = llRhyme.Find("Birthday");
            llRhyme.AddAfter(llNodeRhyme, "To");

            // printing list
            foreach (string element in llRhyme)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

        }
    }
}
