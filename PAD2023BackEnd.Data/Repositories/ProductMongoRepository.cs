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
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            // Como se busca por id => ObjectId
            //Product product = _dataBase.GetType<Product>("product");        
            return null;
        }

        public IEnumerable<Product> Get(Expression<Func<Product, bool>> filter)
        {
            // Como se busca con filtro
            // A lo mejor mongo tiene un metodo para buscar con Expression
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            IMongoCollection<Product> products = _dataBase.GetCollection<Product>("product");
            List<Product> result = products.Find(d => true).ToList();
            return result;
        }

        public void Modify(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
