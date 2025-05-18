using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic array example

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lyon";
            //cities[3] = "Bulgaria";
            //cities[4] = "Kahire";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[7]);

            //string[] cities = {"Prague", "Rome", "Athens", "Ankara", "Bursa"};

            //Console.WriteLine(cities[2]);
            #endregion

            #region List all elements in the array

            //string[] colors = { "Yellow","Red","White","Blue","Green","Orange","Pink" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4,85,96,354,234,1235,435,234,4443,43,23,654,345 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0) { Console.WriteLine(numbers[i]); }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNum = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}
            //Console.WriteLine("Max number {0}",maxNum);

            //string[] persons = {"Erenalp","Ali","ayse","buse","cem"};
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 5,123,32,5667,34,122,63,86 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 5, 123, 32, 5667, 34, 122, 63, 86 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Array Methods

            //string[] customers = {"Ali","Veli","Mehmet","Merve" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 123, 32, 65, 34, 856, 34, 76 };
            //Console.WriteLine("The largest element of the array = {0}\n" +
            //    "Smallest element of the array: {1}", numbers.Max(), numbers.Min());



            #endregion

            #region Receiving data from the user

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Please {i+1}.Enter the cities:");
            //    cities[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,123,54,76,9,567,345,342,3345,342 };
            Console.WriteLine("Even numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}
