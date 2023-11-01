using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using PAD2023BackEnd.Domain.Entities;
using PAD2023BackEnd.Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Data
{
    public class MongoClientDatabase
    {
        public void ConnectMongo()
        {
            const string connectionUri = "mongodb+srv://Agustin030s:G.N@6K#6R_nCiBS@cluster0.2a0uvlf.mongodb.net/?retryWrites=true&w=majority";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to Stable API version 1
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            var database = client.GetDatabase("techgaming");
            var product = database.GetCollection<Product>("product");


            ProductInfo p1 = new ProductInfo() { Name = "Producto1", Price = 250.75M, Category = ProductCategory.Notebook };

            List<Product> result = product.Find(d => true).ToList();

            //try
            //{
            //    var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            //    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }
    }
}
