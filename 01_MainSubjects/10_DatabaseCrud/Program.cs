using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Connection Settings
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = builder.Build();

            string connStr = configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(connStr);
            //Crud --> Create-Read-Update-Delete

            #region Insert
            //Insert Ornek
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");


            //string categoryName = Console.ReadLine();
            //Insert(categoryName, connection); --> INSERT ISLEMLERI ICIN KULLANILABILIR
            #endregion

            #region Ürün Ekleme İşlemleri

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı:");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı:");
            //productPrice = decimal.Parse(Console.ReadLine());
            //Create(productName,productPrice,connection);
            #endregion

            #region Read | Listeleme
            ////tabloadi , sqlconnection istiyor.
            //Read("TblProduct", connection);
            //Console.WriteLine("------------------------------");
            //Read("TblCategory", connection);

            #endregion

            #region Delete | Silme İşlemleri
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Delete(productId,connection);
            #endregion

            #region Update | Güncelleme İşlemleri
            //Console.Write("Güncellenecek Ürün Id :");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı :");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı :");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //Update(productId,productName,productPrice,connection);
            #endregion
            Console.Read();
        }
        #region Crud -> Insert | Kategori Tablosu icin gecerlidir.
        public static void Insert(string categoryName, SqlConnection con) // -> Kod tekrarı olmaması için bir Insert Methodu oluşturuldu.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", con);
                cmd.Parameters.AddWithValue("p1", categoryName);

                cmd.ExecuteNonQuery(); //-> Sorguyu çalıştırır.
                Console.WriteLine("Kategori başarılı bir şekilde eklenmiştir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Crud -> Create | Ürün tablosu için geçerlidir.
        public static void Create(string productName,decimal productPrice,SqlConnection con)
        {
            try
            {
                con.Open(); // con.Open() yerine using'i kullanmayi öğren.
                SqlCommand cmd = new SqlCommand("Insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", con);
                cmd.Parameters.AddWithValue("@productName",productName);
                cmd.Parameters.AddWithValue("@productPrice",productPrice);
                cmd.Parameters.AddWithValue("@productStatus",true);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Ürün eklemesi başarılı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                
            }
            finally
            {
                con.Close() ;
            }
        }
        #endregion
        #region Crud -> Read | Ürün Listeleme
        public static void Read(string tableName,SqlConnection con) // -> Kod tekrarı olmaması için oluşturuldu.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"Select * From {tableName}",con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); 

                DataTable dataTable = new DataTable();
                
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        Console.Write(item+"   ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Crud -> Delete | Silme İşlemleri (Product tablosu için geçerlidir.)
        public static void Delete(int productId, SqlConnection con) // -> Kod tekrarı olmaması için oluşturuldu.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TblProduct Where ProductId = @productId",con);
                cmd.Parameters.AddWithValue("productId",productId);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Verilen ürün id si ile eşleşen ürün silinmiştir.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Crud -> Update | Ürün Güncelleme İşlemleri
        public static void Update(int productId,string productName,decimal productPrice, SqlConnection con)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName = @productName,ProductPrice=@productPrice where ProductId=@productId",con);
                cmd.Parameters.AddWithValue("@productName",productName);
                cmd.Parameters.AddWithValue("@productPrice",productPrice);
                cmd.Parameters.AddWithValue("@productId",productId);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Güncelleme başarılı!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion


    }
}
