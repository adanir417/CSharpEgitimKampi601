using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CSharpEgitimKampi601.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _mongoDatabase;
        
        public MongoDbConnection()
        {
            //var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            //ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);

            //var ignoreConvention = new ConventionPack { new IgnoreExtraElementsConvention(true) };
            //ConventionRegistry.Register("GormezdenGel", ignoreConvention, type => true);



            // Unutmayalım. Veri tabanı bağlantı sıralaması. Sunucu --> Veritabanı --> Tablo(MondoDB için Collections)

            // Eğer ConfigurationManager gelmezse Projemiz üzerinde References kısmına sağ tıklıyoruz ve 
            // Açılan pencereden Add Reference...'i seçiyoruz. Solda Assemblies'i seçtikten sonra
            // System.Configuration olanı referans olarak ekliyoruz. Ekledikten sonra otomatik tamamlamayabilir.
            // namespace olarak using System.Configuration; en tepeye ekliyoruz ve alttaki görüntüyü oluşturuyoruz. 
            var connectionString = ConfigurationManager.ConnectionStrings["mongoDBLearning"].ConnectionString;

            // MongoClient türünde bir değişken SUNUCUMUZA bağlantımızı sağladık.
            var client = new MongoClient(connectionString);

            // Sağladığımız bağlantı ile VERİTABANINA ulaşıyoruz.Eğer böyle bir veritabanı yoksa mongodb otomatik oluşturuyor. 
            _mongoDatabase = client.GetDatabase("Db601Customer");
            
        }

        public IMongoCollection<BsonDocument> GetCustomerCollection() {
            return _mongoDatabase.GetCollection<BsonDocument>("Customers");
        }

        public List<Customer> GetCustomerCollectionAsList() {           
            return _mongoDatabase.GetCollection<Customer>("Customers").Find(Builders<Customer>.Filter.Empty).ToList();
        }

       

    }
}
