using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            

            //Ado .net

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            int tableNumber;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1-Kategoriler\n2-Ürünler\n3-Siparişler\n4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");

            // Amaci güvenliktir. Veri tabanı bilgilerini .json dosyasında tutuyoruz ve istediğimizde uygulamanın içine çekiyoruz.
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder() //Config verilerini okuyacak yapilandirma metodu
                .SetBasePath(Directory.GetCurrentDirectory())//Aktif calistirilan uygulamanin bulundugu klasoru verir.
                .AddJsonFile("appsettings.json");//-> appsetting.json dosyasini konfigurasyon kaynagi olarak ekler.

            IConfiguration configuration = builder.Build(); // Yukarıda tanımladığın yapılandırma kaynaklarını birleştirir ve configuration adında kullanılabilir hale getirir.

            string connStr = configuration.GetConnectionString("MyConnectionString");

            SqlConnection connection = new SqlConnection(connStr);


            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TblCategory",connection);
                
                // C# tarafindaki kodlarim ile sql sunucu arasinda bir kopru gorevi goruyor.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                
                // dataTable verileri gecici bellege almayi saglamak icin alan olusturur.
                DataTable dataTable = new DataTable();
                
                //  dataTable in olusturdugu alani adapter ile doldurur.
                // adapter icinde command var ve command icinde de sorgum var .
                adapter.Fill(dataTable);

                
                foreach (DataRow row in dataTable.Rows) //--> dataTable.Row : DataTable içindeki tüm satırları temsil eder.
                {                                           //-->Her satır 1 DataRow nesnesidir.
                    foreach (var item in row.ItemArray) //--> Bu satırda kaç tane sütun varsa o kadar eleman döner
                    {
                        Console.Write(item.ToString()); //--> Veriyi string formatina cevirir.
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gerçek hata mesajı:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stack trace:");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }

            Console.Read();
        } 
    }
}
