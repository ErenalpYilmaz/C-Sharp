using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop

            //string[] cities = { "Ankara", "Istanbul", "Bursa","Zonguldak" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 123, 32, 56, 34, 786, 345, 76, 55, 43, 675 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //List<int> numbers = new List<int>();
            //List<int> numbers = new List<int>()
            //{
            //    1,2,5,12,56,345,23
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Example exam

            Console.Write("***** C# BootCamp Exam Application *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //The number of students in the class from the user
            Console.WriteLine("----------------------------------------");
            Console.Write("How many students are in your class? :");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            //Öğrencilerin isimleri ve sınav ortalamaları için oluşturulan diziler.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}.enter the student's name:");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} {i+1}. exam grade: ");
                    double value = double.Parse( Console.ReadLine() );
                    totalExamResult += value;                    
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
            Console.WriteLine("----------------------------------------");
            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalması: {studentExamAvg[i]}");
                // Öğrencilerin geçip kalma durumları.
                if (studentExamAvg[i] >= 50 )
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                }
                Console.WriteLine("----------------------------------------");
            }
            

            
            

            #endregion

            Console.Read();
        }
    }
}
