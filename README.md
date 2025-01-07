# CSharpEgitimKampi601

---

Murat YÜCEDAĞ [C# Eğitim Kampı](https://www.youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr)     
Check original repository => [C# Eğitim Kampı Original Repository](https://github.com/MuratYucedag/CSharpEgitimKampi)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 2](https://github.com/MuratYucedag/CSharpEgitimKampi301)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 3](https://github.com/MuratYucedag/CSharpEgitimKampi501)    
Check original repository => [C# Eğitim Kampı Original Repository - Part 4](https://github.com/MuratYucedag/CSharpEgitimKampi601)    

---


## Dersler
### Module 601 - Continue    
---    

### :green_circle: Ders 24 - C# ile MongoDb Kullanımı 1
MongoDB'i indirmek için izlenecek adımlar.
1- [MongoDB](https://www.mongodb.com/) sayfasına girilir. Products üzerine tıklanarak en sağ altta bulunan "Try Community Edition
Explore the latest version of MongoDB" kısmına girilir.
veya [Try MongoDB Community Edition](https://www.mongodb.com/try/download/community) link değişmediyse bu kısım aynı sayfayı açar.     
2- Kurulum(setup) dosyası indirilerek kurulum yapılır. MongoDB Compass üzerinden Add New Connection'a basarak local çalışan bir veritabanı oluşturabiliyoruz.
MongoDB sunucu bazlı denememiz için 500mb'a kadar bir denemelik veritabanı sağlayabiliyor. Onun adımları için [Rehber](https://www.mongodb.com/docs/guides/atlas/account/)'i takip etmemiz gerekiyor.      
Ücretsiz sürüm 500mb olduğu için aşmamak adına özen göstermek ve github'a yüklenecek dosyalar için connectionString'i barındırmamak önemli.     

Kurulum tamamlandıktan ve MongoDB Compass çalışır hale geldikten sonra default olarak şöyle bir bağlantı adresi ile işleme başlıyoruz.      
```
mongodb://localhost:27017/
```     

Visual Studio tarafında CSharpEgitimKampi601 adlı Windows Form projemize iki adet paketi Nuget üzerinden yüklüyoruz.      
1- MongoDB.Bson      
2- MongoDB.Driver    

Entities Klasörü oluşturduktan sonra içerisine Customer adında bir class oluşturuyoruz. Burada tek fark MongoDB için bazı data annotationlar ekliyoruz.     
1- [BsonId]     
2- [BsonRepresentation(BsonType.ObjectId)]    


son görüntü şu şekilde oluyor.      

```csharp
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerCity { get; set; }
        public decimal CustomerBalance { get; set; }
        public int CustomerShoppingCount { get; set; }
    }
}

```     

Services adlı bir klasör oluşturuyoruz. İçerisine MongoDbConnection isimli bir class oluşturuyoruz. Bu sınıf bizim veritabanına erişim sınıfımız olacak
DBContext gibi. IMongoDatabase türünde private ile bir değişken tanımlıyoruz. 
```csharp
private IMongoDatabase _mongoDatabase;
```    

### :green_circle: Ders 25 - C# ile MongoDb Kullanımı 2    

Bu arkadaş T tipinde bir veri alıyor. Yani eğer BsonDocument istersek BsonDocument olarak veritabanından getiriyor. Eğer Sınıfı istersek
Sınıfı AutoMapping(Otomatik eşleşme) yaparak eşlenmiş şekilde getiriyor.

```csharp
        public IMongoCollection<BsonDocument> GetCustomerCollection() {
            return _mongoDatabase.GetCollection<BsonDocument>("Customers");
        }

        public List<Customer> GetCustomerCollectionAsList() {           
            return _mongoDatabase.GetCollection<Customer>("Customers").Find(Builders<Customer>.Filter.Empty).ToList();
        }
```

Automapping özelliğini kullanırsak Linq kullanışlı hale geliyor. İşlemler basitleşiyor.
BsonDocument türünde ise Mapping işlemini manuel olarak yaptığımız için istediğimiz alanı modifiye şansımız var.

```csharp
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
```    

Burada dönüşümün nasıl uygulandığını görebiliriz. BsonDocument objesini ["TabloADI"] ile eşleştirip o şekilde dönüşüm sağlıyoruz.
Bu şekilde tüm CRUD işlemlerimizi MongoDB üzerinde gerçekleştirdik.       

### :green_circle: Ders 26 - C# ile PostgreSQL Kullanımı 1     
PostgreSQL üzerinde pgAdmin ile CustomerDb adında bir veritabanı oluşturduk. Bu veritabanı içerisinde Customers adında bir tablo oluşturduk.
Bu tablo içerisinde CustomerId, CustomerName, CustomerSurname, CustomerCity adında sütunlar oluşturduk.
Bu sütunlar içerisine veri ekledik.

EntityFramework6.Npgsql adlı paketi yükledik.


FrmCustomer adlı form oluşturduk. Bu form üzerinde PostgreSQL veritabanına bağlanarak verileri çektik.    
readMe dosyası işlerken copilot öneride bulundu :)
```csharp
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=CustomerDb;User Id=postgres;Password=1234;");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from Customers", connection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["CustomerId"].ToString());
                item.SubItems.Add(reader["CustomerName"].ToString());
                item.SubItems.Add(reader["CustomerSurname"].ToString());
                item.SubItems.Add(reader["CustomerCity"].ToString());
                listView1.Items.Add(item);
            }
            connection.Close();
        }
```

Ekle butonumuz için query ve işlenişimiz bu şekilde.

```csharp
 private void button_CustomerAdd_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text;
            string customerSurname = textBox_CustomerSurname.Text;
            string customerCity = textBox_CustomerCity.Text;

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers(CustomerName,CustomerSurname,CustomerCity) values (@customerName,@customerSurname,@customerCity)";
            var command = new NpgsqlCommand(@query,connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme işlemi başarılı");
            RefreshList();
        }
```