using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	//Create a class that implements an integer list class, has an add method and uses an internal integer array to store data

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class myList
    {
        // internal representation of this list is an arrayz
        private int[] list;
        private int size;
        private const int INIT_CAP = 8;

        // default constructor: runs only if no parameter is passed
        public myList()
        {
            list = new int[INIT_CAP];
            size = 0;
        }

        // alternate constructor instantiates this list with values from an array input
        public myList(int[] numbers)
        {
            // set the capacity of the list to the length of array
            list = new int[numbers.Length];

            // copy the values in the array into this list
            for (int i = 0; i < numbers.Length; i++)
            {
                list[i] = numbers[i];
            }
        }

        public void Add(int number)
        {
            if (size < INIT_CAP)
            {
                list[size] = number;
                size++;
            }
            else
            {
                // resize the list
                Resize();

                list[size] = number;
                size++;
            }
        }

        private void Resize()
        {
            // save previous values
            int[] temp = list;

            // recreate the list with bigger capacity
            list = new int[size + INIT_CAP];

            // put back original items
            for (int i = 0; i < temp.Length; i++)
            {
                list[i] = temp[i];
            }
        }
    }
}