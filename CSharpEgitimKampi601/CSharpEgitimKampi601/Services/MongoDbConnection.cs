using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnection
    {
        // MongoDB ile bağlantı ve veritabanı işlemlerini yöneten sınıf
        private IMongoDatabase _database;

        // Sınıfın kurucu metodu - MongoDB istemcisi ile bağlantı kurar ve veritabanını seçer
        public MongoDbConnection()
        {
            // MongoDB sunucusuna localhost (127.0.0.1) üzerinden bağlantı kuruluyor
            var client = new MongoClient("mongodb://localhost:27017");

            // "Db601Customer" isimli veritabanına erişim sağlanıyor
            _database = client.GetDatabase("Db601Customer");
        }

        // "Customers" adlı koleksiyona erişimi sağlayan metot
        public IMongoCollection<BsonDocument> GetCustomersCollection()
        {
            // "Customers" koleksiyonunu alır ve geri döner
            return _database.GetCollection<BsonDocument>("Customers");
        }

    }
}
