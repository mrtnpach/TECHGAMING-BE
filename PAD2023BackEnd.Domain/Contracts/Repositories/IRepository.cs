using PAD2023BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAD2023BackEnd.Domain.Contracts.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<Product> Get(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Delete(int id);
        void Modify(T entity);
    }
}
