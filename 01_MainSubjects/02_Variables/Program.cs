using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            ////Büyük ondalık ifadeler için kullanılır.
            ////double number;
            ////number = 5.36;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Price List *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Apple unit price: {0}TL", applePrice);
            //Console.WriteLine("----Orange unit price: {0}TL", orangePrice);
            //Console.WriteLine("----Strawberry unit price: {0}TL", strawberryPrice);
            //Console.WriteLine("----Potato unit price: {0}TL",potatoPrice);
            //Console.WriteLine("----Tomato unit price: {0}TL",tomatoPrice);

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.75;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //Console.WriteLine("------------------------------------------");
            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Product to buy = Apple \nUnit Price = {0} \nWeight : {1} \nTotal Price = {2}",applePrice,appleGram,appleTotalPrice);

            //Console.WriteLine("------------------------------------------");           
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Product to buy = Orange \nUnit Price = {0} \nWeight : {1} \nTotal Price = {2}", orangePrice, orangeGram, orangeTotalPrice);

            //Console.WriteLine("------------------------------------------");           
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Product to buy = Strawberry \nUnit Price = {0} \nWeight : {1} \nTotal Price = {2}", strawberryPrice, strawberryGram, strawberryTotalPrice);

            //Console.WriteLine("------------------------------------------");            
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Product to buy = Potato \nUnit Price = {0} \nWeight : {1} \nTotal Price = {2}", potatoPrice, potatoGram, potatoTotalPrice);

            //Console.WriteLine("------------------------------------------");            
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Product to buy = Tomato \nUnit Price = {0} \nWeight : {1} \nTotal Price = {2}", tomatoPrice, tomatoGram, tomatoTotalPrice);
            //Console.WriteLine("------------------------------------------");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Shopping Total Price : {0}",shoppingTotalPrice);
            #endregion

            #region Char Variables

            //char symbol = 'A'; // "A" yazamazsın.
            //Console.WriteLine(symbol);

            #endregion

            #region Data Input | String Variables
            //Console.WriteLine("**** C# Airlines Passenger Information ****");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Passenger Name :");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname :");
            //passengerSurname = Console.ReadLine();

            //Console.Write("District Info :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("City Info:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Passenger Age :");
            //passengerAge = Console.ReadLine();

            //Console.Write("Passenger Identity Number :");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Passenger ID = {0} - Passenger = {1} {2} / {3} / {4} / {5})",passengerIdentityNumber,passengerName,passengerSurname,passengerDistrict, passengerCity, passengerAge);
            //Console.WriteLine("---------------------------");

            #endregion

            #region Data Input | Int Variables

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeAmount, computerAmount, chairAmount, tvAmount;

            //Console.Write("Please enter quantity of shoes you want to buy:");
            //shoeAmount = int.Parse(Console.ReadLine()); // int verisini 32 bit olarak dönüştürür. Bellekte kaplayacak alan açısından önemli.

            //Console.Write("Please enter quantity of computer you want to buy:");
            //computerAmount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter quantity of chair you want to buy:");
            //chairAmount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter quantity of tv you want to buy:");
            //tvAmount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //int totalPrice = shoePrice * shoeAmount + computerPrice * computerAmount + chairPrice * chairAmount + tvPrice * tvAmount;
            //Console.WriteLine("Total amount you have to pay : {0} ",totalPrice);
            #endregion

            #region Data Input | Decimal Variables

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter the 1st exam grade : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Please enter the 2st exam grade : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Please enter the 3st exam grade : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+ exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Exam Avarage: {0}",result);
            #endregion

            #region Data Input | Char Variables
            char gender;
            Console.Write("Please choice gender : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Gender of your choice : {0}",gender);
            #endregion

            Console.Read();
        }
    }
}
