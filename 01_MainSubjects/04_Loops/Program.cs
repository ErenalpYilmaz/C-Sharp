using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loops

            //int i, result = 0;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("C# BootCamp - {0}",i);

            //}

            //for (int i = 0; i <= 20; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Please enter the number of numbers you want to be written on the screen:");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++) 
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet.");
            //}




            #endregion

            #region For Loop with Decision structure

            //for (int i = 1; i <= 100; i++) 
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(totalValue);

            //int totalCount = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        totalCount++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------------------");
            //Console.WriteLine(totalCount);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine("At the end of {0} hour : {1}",i,bacterium);
            //}


            #endregion

            #region While Loops

            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine("Hello Loops");
            //    i++;
            //}

            //int i = 1;
            //while (i < 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10) {
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Example Exam Question
            ////Write the code that calculates the sum of the digits of the 3-digit number entered from the keyboard

            //// 456

            //int number,sum,newNum;

            //Console.Write("Please enter your number :");
            //number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //hundreds = number / 100; //4.56 ---> 4
            //tens = (number % 100)/10; 
            //ones = number % 10;
            //Console.WriteLine("{0}{1}{2}",hundreds,tens,ones);
            #endregion


            Console.Read();
        }
    }
}
