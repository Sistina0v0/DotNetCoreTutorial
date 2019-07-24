using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tutorial.Portal.DbContext;
using Tutorial.Portal.EntityModel;

namespace Tutorial.Portal.Service
{
    public class CommonService<T> : ICommonService<T> where T : BaseEntityModel, new()
    {
        private DataContext _context;

        public CommonService(DataContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Edit(T entity)
        {
            _context.Set<T>().Attach(entity);
            return _context.SaveChanges() > 0;
        }

        public bool DeleteById(int id)
        {
            var entity = _context.Set<T>().Attach(new T {Id = id});
            _context.Entry(entity).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
    }
}
