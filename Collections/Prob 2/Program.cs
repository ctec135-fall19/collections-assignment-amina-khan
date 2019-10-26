/*
Author: Amina Khan
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#
Module 5, Programming Assignment 4
  Prob 2 - Stacks and Queues
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Region 1: Stack");
            #region 1 - Stack
            //declare and initialize a stack with the numbers
            //1 - 5 using initialization syntax.
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);

            Console.WriteLine("\nPrinting Stack elements");
            //demonstrate use of the enumerator to print out the 
            //members in the stack, i.e.write a foreach loop
            foreach (int element in intStack)
            {
                Console.WriteLine(element);
            }

            //print a peek at the top member in the stack
            Console.WriteLine("Peek item in Stack: {0}", intStack.Peek());

            //write a loop that pops the elements off of the 
            //stack and prints each
            int stackSize = intStack.Count();
            for (int i=0; i < stackSize; i++)
            {
                Console.WriteLine("Popping off: {0}", intStack.Pop());
            }
            #endregion

            #region 2 - Queue
            Console.WriteLine("\nRegion 2: Queue\n");
            //declare a queue
            Queue<int> myQueue = new Queue<int>();


            //initialize the queue with the numbers 1 - 5 
            //using a for loop.
            for (int i = 0; i < 5; i++)
            {
                myQueue.Enqueue(i + 1);
            }

            //demonstrate use of the enumerator to print out the 
            //members in the queue, i.e.write a foreach loop
            Console.WriteLine("Printing elements of Queue");
            foreach (int element in myQueue)
            {
                Console.WriteLine(element);
            }

            //print a peek at the top member in the queue
            Console.WriteLine("Peek of Queue: {0}", myQueue.Peek());


            //write a loop that dequeues the elements from the 
            //queue and prints each
            int queueSize = myQueue.Count();
            for (int i = 0; i < queueSize; i++)
            {
                Console.WriteLine("Removing/Dequeue item: {0}", myQueue.Dequeue());
            }

            #endregion
        }
    }
}
