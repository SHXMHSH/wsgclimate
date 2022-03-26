using System.Linq.Expressions;

namespace wsgclimate.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> where = null);
        Task<T> Single(int id);
        void Edit(T model);
        T Add(T model);
        void Delete(int id);
        void SaveChanges();
        Task SaveChangesAsync();


    }
}
