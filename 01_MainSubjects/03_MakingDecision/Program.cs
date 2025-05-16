using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else Block

            //Console.Write("Please enter password:");
            //string password; 
            //password = Console.ReadLine();

            //if (password == "abc123"){
            //    Console.WriteLine("Correct Password !");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Password !");
            //}

            //string capital, country;
            //Console.Write("Capital :");
            //capital = Console.ReadLine();

            //Console.Write("County :");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Correct Data");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Information");
            //}

            //int number;
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Correct Number !");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number !");
            //}
            //int number;
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Correct Number !");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number !");
            //}

            //int exam1, exam2, exam3, avarage;
            //string result;

            //Console.Write("Exam1 : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Exam2 : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Exam3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Exam Avarage: {0}",avarage);

            //if (avarage > 0 & avarage <= 50) {
            //    result = "F";
            //}
            //else if (avarage > 50 & avarage < 70)
            //{
            //    result = "C";
            //}
            //else if (avarage > 70 & avarage < 84)
            //{
            //    result = "B";
            //}
            //else if(avarage >= 84 & avarage <= 100)
            //{
            //    result = "A";
            //}
            //else
            //{
            //    result = "Wrong Information";
            //}
            //Console.WriteLine(result);




            #endregion

            #region mod

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.Write("Number 1 :");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Number 2 :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("The remainder of the 1st number divided by the 2nd number : {0}",result);

            //Console.Write("Number :");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0) {                
            //    Console.WriteLine("Even Number");
            //} 
            //else
            //{
            //    Console.WriteLine("Odd Number");

            //}





            #endregion

            #region Char Decision structures 
            //char team;
            //Console.Write("Please enter your team symbol :");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'G' & team == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}else if (team == 'F' & team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong team symbol !!!");
            //}
            #endregion


            #region Example Project
            //Console.WriteLine("**** C# Boot Camp Restaurant ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Main Dish");
            //Console.WriteLine("2-Soups");
            //Console.WriteLine("3-Pizza");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Dessert");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Select the menu you want to see the details of :");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") {
            //    Console.WriteLine();
            //    Console.WriteLine("----------Main Dish----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Chicken with curry sauce");
            //    Console.WriteLine("2-Adana Kebab");
            //    Console.WriteLine("3-Doner over rice");
            //    Console.WriteLine("4-Baked salmon");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Main Dish----------");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Soup Dish----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kelle Paça");
            //    Console.WriteLine("2-Tarhana");
            //    Console.WriteLine("3-İşkembe");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Soup Dish----------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizza Dish----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("3-Akdeniz Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizza Dish----------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Drinks Dish----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Water");
            //    Console.WriteLine("3-Lemonada");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Drinks Dish----------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Dessert Dish----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Fıstıklı Baklava");
            //    Console.WriteLine("2-Fıstık Sarma");
            //    Console.WriteLine("3-Fıstıklı Kadayıf");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Dessert Dish----------");
            //}
            #endregion

            #region Swtich Case

            //Console.Write("Please enter the month :");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("JANUARY"); break;
            //    case 2: Console.WriteLine("FEBRUARY"); break;
            //    case 3: Console.WriteLine("MARCH"); break;
            //    case 4: Console.WriteLine("APRIL"); break;
            //    case 5: Console.WriteLine("MAY "); break;
            //    case 6: Console.WriteLine("JUNE"); break;
            //    case 7: Console.WriteLine("JULY"); break;
            //    case 8: Console.WriteLine("AUGUST"); break;
            //    case 9: Console.WriteLine("SEPTEMBER"); break;
            //    case 10: Console.WriteLine("OCTOBER "); break;
            //    case 11: Console.WriteLine("NOVEMBER"); break;
            //    case 12: Console.WriteLine("DECEMBER"); break;
            //    default:
            //        Console.WriteLine("Incorrect data entr ");
            //        break;
            //}
            #endregion

            #region Switch | Calculator
            int number1, number2, result;
            char symbol;
            Console.Write("Number1 :");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Number2 :");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Please enter te operation you want to perform :");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Result = {0}", result);
                    break;
                case '-':
                    result = (number1 - number2) ;
                    Console.WriteLine("Result = {0}", result);
                    break;
                case '*':
                    result = (number1 * number2);
                    Console.WriteLine("Result = {0}", result);
                    break;
                case '/':
                    result = (number1 / number2);
                    Console.WriteLine("Result = {0}", result);
                    break;
                default:
                    break;
            }






            #endregion

            Console.Read();
        }
    }
}
