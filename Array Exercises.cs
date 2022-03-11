using System;
using System.Linq;
using System.Collections.Generic;

namespace EdzelMila
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pass = true;
            int[] numArray = new int[1];
            int first = 0;
            Console.WriteLine("Enter number contents of array");
            do
            {
                try
                {
                    Console.Write("enter number: ");
                    string input = Console.ReadLine();
                    int n = int.Parse(input);
                    int[] newArray = new int[numArray.Length + 1];

                    int i;
                    for (i = 0; i < numArray.Length; i++)
                    {
                        newArray[i] = numArray[i];
                    }
                    newArray[i - 1] = n;
                    numArray = newArray;
                }
                catch (Exception e)
                {
                    pass = false;
                }
            } while (pass);
            int[] finalArray = new int[numArray.Length - 1];

            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = numArray[i];
            }

            Console.WriteLine(" Input 1 to remove element from n index \n Input 2 to count frequency of element in array \n Input 3 to print all unique elements in array \n Input 4 to count total number of duplicate elements in array \n Input 5 to delete all duplicate elements from array");

            Console.Write("Input: ");
            string choice = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


           

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter index to be removed: ");
                    string index = Console.ReadLine();
                    Function1(finalArray, int.Parse(index));
                    break;
                
                case "2":
                    Function2(finalArray);
                    break;

                case "3":
                    Function3(finalArray);
                    break;

                case "4":
                    Function4(finalArray);
                    break;

                case "5":
                    Function5(finalArray);
                    break;

                default:
                    Console.WriteLine("error. please enter only from 1 - 5. restart console program");
                    break;

            }

        }

        private static void Function1(int[] arr, int pos) 
        {
            // detele element from n index
            List<int> nums = new List<int>(arr);
            nums.RemoveAt(pos);
            arr = nums.ToArray();
            Console.Write($"Function 1: deleted at position {pos}  :  ");
            PrintArray(arr);
        }

        private static void Function2(int[] arr) 
        {
            // count frequency of each element in array
            Console.WriteLine("Function 2: the frequency of each element are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                var cnt = arr.Count(e => e == arr[i]);
                Console.WriteLine($"Element {arr[i]}, count {cnt}");
            }
        }

        private static void Function3(int[] arr) 
        {
            //print all unique elements in the array
            Console.Write("Function 3: All unique elements in array ");
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " , ");

                }
            }
            Console.WriteLine(" ");
        }

        private static void Function4(int[] arr) 
        {
            //count total number of duplicate elements in array
            List<int> nums = new List<int>();

            int sameCount = 0;
            for (int i = 0, n = 0; i < arr.Length; i++)
            {
                for (int x = 0; x < arr.Length; x++)
                {
                    if (i != x && arr[i] == arr[x] && !nums.Contains(arr[i]))
                    {
                        sameCount += 1;
                        nums.Add(arr[i]);
                        break;
                    }
                }
            }

            Console.WriteLine("Function 4: The total number of duplicates is " + sameCount);
        }

        private static void Function5(int[] arr) 
        {
            //delete all duplicate elements from array
            int[] dist = arr.Distinct().ToArray();
            Console.Write("Function 5: Duplicates are deleted: ");
            PrintArray(dist);
        }

        private static void PrintArray(int[] arr)
        {
            // for printing contents of array
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x] + " , ");
            }
            Console.WriteLine(" ");
        }
    }
}

// code created by Edzel Mila BSIT-1