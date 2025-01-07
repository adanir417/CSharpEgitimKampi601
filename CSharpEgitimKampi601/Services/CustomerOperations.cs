using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public List<Customer> GetCustomers() {
            var list = new MongoDbConnection().GetCustomerCollectionAsList();
            //Debug.WriteLine("Buralarda listeye başladım.");
            //foreach (var r in list) {
            //    Debug.WriteLine(r.CustomerName);
            //}
            return list;          
        }

        public List<Customer> GetCustomersFromBson() {
            var customerCollection = new MongoDbConnection().GetCustomerCollection();
            var bsonCustomerList = customerCollection.Find(new BsonDocument ()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var bson in bsonCustomerList) {
                customerList.Add(
                    new Customer()
                    {
                        CustomerId = bson["_id"].ToString(),
                        CustomerName = bson["CustomerName"].ToString(),
                        CustomerSurname = bson["CustomerSurname"].ToString(),
                        CustomerCity = bson["CustomerCity"].ToString(),
                        CustomerBalance = decimal.Parse(bson["CustomerBalance"].ToString()),
                        CustomerShoppingCount = int.Parse(bson["CustomerShoppingCount"].ToString())
                    }
                    );
            }
            return customerList;
        }


        public void AddCustomer(Customer customer) {

            // Oluşturduğumuz MongoDbConnection sınıfından tablomuzu çekeceğiz.
            // Yapılandırıcıda bağlantılar yapıldığı için sadece tablo için gerekli metodu çağıracağız.
            var connection = new MongoDbConnection();

            // Tablomuzu değişkenimize alalım.
            var customerCollection = connection.GetCustomerCollection();

            /*
            // Şu şekilde de alınabilir. Tercihe bağlı.
            //var customerCollection = new MongoDbConnection().GetCustomerCollection();
            */

            // Veri kaydı gerçekleştireceğimiz format türünde bir obje oluşturuyoruz.
            var document = new BsonDocument()
            {
                // customer'ın method parametresi olduğunu unutmayalım
                {"CustomerName", customer.CustomerName },
                {"CustomerSurname", customer.CustomerSurname },
                {"CustomerCity", customer.CustomerCity},
                {"CustomerBalance", customer.CustomerBalance },
                {"CustomerShoppingCount" , customer.CustomerShoppingCount},
               
            };

            //Burada bağlantı üzerinden çektiğimiz tabloya sokuyoruz. Yanlış olmasın yarattığımız objemizi listeye katıyoruz :D
            customerCollection.InsertOne(document);
        }

        public void DeleteCustomer(string id) { 
            // Liste - Koleksiyon belleğe alındı
            var collection = new MongoDbConnection().GetCustomerCollection();
            // Silinecek objenin id alanı ile filtreleme yapıldı
            var filter = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
            // Koleksiyon üzerinden silme işlemi gerçekleştirildi.
            collection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer) {
            // Liste - Koleksiyon belleğe alındı
            var collection = new MongoDbConnection().GetCustomerCollection();
            // Güncellenecek obje id ile bulundu.
            var filter = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(customer.CustomerId));
            // Güncellenecek obje BsonDocument olarak hazırlandı.
            var updateValue = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount)                
                ;
            // Update işlemi gerçekleştirildi.
            collection.UpdateOne(filter,updateValue);
        }

        public List<Customer> GetCustomerById(string id) {

            var collection = new MongoDbConnection().GetCustomerCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var bsonObj = collection.Find(filter).FirstOrDefault();
            return new List<Customer>
            {
                new Customer { 
                CustomerId = bsonObj["_id"].ToString(),
                CustomerName = bsonObj["CustomerName"].ToString(),
                CustomerSurname = bsonObj["CustomerSurname"].ToString(),
                CustomerCity = bsonObj["CustomerCity"].ToString(),
                CustomerBalance =decimal.Parse( bsonObj["CustomerBalance"].ToString()),
                CustomerShoppingCount = int.Parse( bsonObj["CustomerShoppingCount"].ToString()),                
                }
            };
        }


    }
}
