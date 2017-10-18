using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> List { get; }
        Task<T> Insert(T entity);
        Task<T> Delete(T entity);
        Task<T> Update(T entity);
        Task<bool> SaveAsync();
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
