﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class program
    {
        //array to be searched
        int[] arr = new int[20];
        //number of element in the array
        int n;
        //get the number of elemnts to store in the array
        int i; 

        public void input()
        {
            while (true)
            {
                Console.Write("eneter the number of elements in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 elemnts \n");
            }

            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("Enter array elements");
            Console.WriteLine("===================");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i+1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be serached
                Console.Write("\n Enter elemnt want you want to search: \n");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the indeks of the elemnt in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to serach for the elements of the array
                while ((item != arr[mid]) & (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item > arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " Found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " Not Found in the Array\n");
                Console.WriteLine("\nNumber of comparison : " + ctr);

                Console.Write("\nCantinue search (y/n):");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y')||(ch == 'y'));
        }
       
    }
}











