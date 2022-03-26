using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using wsgclimate.DataContext;

namespace wsgclimate.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Data _db;
        private  DbSet<T> _set;
        public Repository()
        {
            _db = new Data();
            _set = _db.Set<T>();
        }
        public T Add(T model)
        {
            if (model != null)
            {
                _db.Add(model);
                return model;
            }
            return null;
        }

        public void Delete(int id)
        {
            try
            {
                var model = _db.Find<T>(id);
                if (model != null)
                {
                    _db.Remove(model);
                    _db.SaveChangesAsync();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Edit(T model)
        {
            _db.Entry<T>(model).State = EntityState.Modified;
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> where = null)
        {
            return _set;
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<T> Single(int id)
        {
            return await _set.FindAsync(id);
        }
    }
}
