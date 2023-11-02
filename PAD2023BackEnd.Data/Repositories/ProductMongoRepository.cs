using MongoDB.Driver;
using PAD2023BackEnd.Domain.Contracts.Repositories;
using PAD2023BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PAD2023BackEnd.Data.Repositories
{
    public class ProductMongoRepository : IRepository<Product>
    {
        private readonly string _mongoConnectionString;
        private MongoClient _mongoClient;
        private IMongoDatabase _dataBase;
        private IMongoCollection<Product> _products;

        public ProductMongoRepository(string connection)
        {
            _mongoConnectionString = connection;
            ConnectToMongo();
        }

        private void ConnectToMongo()
        {
            MongoClientSettings settings =
                            MongoClientSettings.FromConnectionString(_mongoConnectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            _mongoClient = new MongoClient(settings);
            _dataBase = _mongoClient.GetDatabase("techgaming");
            _products = _dataBase.GetCollection<Product>("product");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            Product product = _products.AsQueryable().Where(x => x.ObjectId == id).FirstOrDefault();        
            return product;
        }

        public IEnumerable<Product> Get(Expression<Func<Product, bool>> filter)
        {
            var filteredProducts = _products.Find(filter).ToEnumerable();
            return filteredProducts;
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> result = _products.Find(d => true).ToList();
            return result;
        }

        public void Modify(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
