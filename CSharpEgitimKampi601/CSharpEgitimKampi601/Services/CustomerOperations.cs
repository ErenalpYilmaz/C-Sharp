using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();

            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName },
                {"CustomerSurname", customer.CustomerSurname },
                {"CustomerCity",customer.CustomerCity },
                {"CustomerBalance",customer.CustomerBalance },
                {"CustomerShoppingCount",customer.CustomerShoppingCount }
            };

            customerCollection.InsertOne(document);
        }

        // Tüm müşterileri veritabanından alıp bir List<Customer> olarak döndüren metot
        public List<Customer> GetAllCustomer()
        {
            // MongoDB bağlantısı oluşturuluyor
            var connection = new MongoDbConnection();

            // "Customers" koleksiyonuna erişim sağlanıyor
            var customerCollection = connection.GetCustomersCollection();

            // Koleksiyondaki tüm belgeler çekiliyor (boş BsonDocument => tüm kayıtları getir)
            var customers = customerCollection.Find(new BsonDocument()).ToList();

            // Veritabanından gelen verilerin dönüştürüleceği Customer tipi listesi oluşturuluyor
            List<Customer> customerList = new List<Customer>();

            // Her bir BsonDocument nesnesi Customer nesnesine dönüştürülerek listeye ekleniyor
            foreach (var c in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),                                          // MongoDB'nin otomatik oluşturduğu ID
                    CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),         // Bakiye değeri decimal'e dönüştürülüyor
                    CustomerCity = c["CustomerCity"].ToString(),                              // Şehir bilgisi
                    CustomerName = c["CustomerName"].ToString(),                              // Müşteri adı
                    CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString()), // Alışveriş sayısı int'e dönüştürülüyor
                    CustomerSurname = c["CustomerSurname"].ToString()                         // Müşteri soyadı
                });
            }

            // Customer listesi geri döndürülüyor
            return customerList;
        }

        #region DeleteCustomer
        // Verilen id'ye sahip müşteri kaydını MongoDB'den silen metot
        public void DeleteCustomer(string id)
        {
            // MongoDB bağlantısı oluşturuluyor
            var connection = new MongoDbConnection();

            // "Customers" koleksiyonuna erişim sağlanıyor
            var customerCollection = connection.GetCustomersCollection();

            // Silinecek müşteri için filtre oluşturuluyor (belirtilen ObjectId ile eşleşen kayıt)
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            // Eşleşen ilk belge veritabanından siliniyor
            customerCollection.DeleteOne(filter);
        }
        #endregion

        #region Update Customer
        // Verilen Customer nesnesine göre ilgili müşteri kaydını güncelleyen metot
        public void UpdateCustomer(Customer customer)
        {
            // MongoDB bağlantısı oluşturuluyor
            var connection = new MongoDbConnection();

            // "Customers" koleksiyonuna erişim sağlanıyor
            var customerCollection = connection.GetCustomersCollection();

            // Güncellenecek müşteri için filtre oluşturuluyor (_id alanı kullanılarak)
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));

            // Güncellenmek istenen alanlar belirleniyor ve yeni değerler atanıyor
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)                         // İsim güncellemesi
                .Set("CustomerSurname", customer.CustomerSurname)                   // Soyisim güncellemesi
                .Set("CustomerCity", customer.CustomerCity)                         // Şehir güncellemesi
                .Set("CustomerBalance", customer.CustomerBalance)                   // Bakiye güncellemesi
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);      // Alışveriş sayısı güncellemesi

            // Filtreye uyan belge güncelleniyor
            customerCollection.UpdateOne(filter, updatedValue);
            
        }

        #endregion

        #region ID'ye gore getir.

        // Belirtilen id'ye sahip müşteri kaydını MongoDB'den alan ve Customer nesnesi olarak döndüren metot
        public Customer GetCustomerById(string id)
        {
            // MongoDB bağlantısı oluşturuluyor
            var connection = new MongoDbConnection();

            // "Customers" koleksiyonuna erişim sağlanıyor
            var customerCollection = connection.GetCustomersCollection();

            // Sorgu filtresi oluşturuluyor (verilen id ile _id alanı eşleşen kayıt aranır)
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            // Filtreye uyan ilk belge (varsa) veritabanından çekiliyor
            var result = customerCollection.Find(filter).FirstOrDefault();

            // Elde edilen belge, bir Customer nesnesine dönüştürülerek geriye döndürülüyor
            return new Customer
            {
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),         // Bakiye değeri
                CustomerCity = result["CustomerCity"].ToString(),                              // Şehir bilgisi
                CustomerId = id,                                                               // Müşteri ID (dışarıdan gelen)
                CustomerName = result["CustomerName"].ToString(),                              // İsim bilgisi
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()), // Alışveriş sayısı
                CustomerSurname = result["CustomerSurname"].ToString()                         // Soyisim bilgisi
            };
        }


        #endregion
    }
}
