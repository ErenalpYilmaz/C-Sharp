using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // Geriye değer döndürmeyen methodlar.
            // Customer --> Listele, Ekle, Sil, Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Erenalp YILMAZ");
            //    Console.WriteLine("Ayşe YILDIZ");
            //    Console.WriteLine("Hakan ÖZTÜRK");
            //    Console.WriteLine("Merve ÇINAR");
            //}
            //CustomerList();
            //

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();





            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldız");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine($"Müşteri {name} {surname}");
            //}
            //CustomerCard("Erenalp","Yılmaz");
            //CustomerCard("Mehmet","Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1, int num2,int num3)
            // {
            //     int result = num1 + num2 + num3;
            //     Console.WriteLine(result);
            // }
            // Sum(5,2,67);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse YILDIZ";
            //}

            //string name = CustomerName();
            //Console.WriteLine(name);

            //string StudentCard() 
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke :" + countryName + "\nBaşkent: " + capital + "\nBayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz :");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz :");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz :");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Italya","Roma","Kirmizi"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,34));
            //Console.WriteLine(Sum(37,87));
            //Console.WriteLine(Sum(56,56));
            //Console.WriteLine(Sum(67,98));
            #endregion

            #region Örnek Uygulama
            //string examResult(string student, int exam1, int exam2, int exam3)
            //{

            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti." + "Ortalama :" + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi " + "Ortalama:" + result;
            //    }
            //}

            //Console.WriteLine(examResult("Ali", 45, 34, 76));
            //Console.WriteLine(examResult("Veli", 32, 23, 12));
            #endregion


            Console.Read();
        }
    }
}
