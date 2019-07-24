using System.Collections.Generic;
using Tutorial.Portal.EntityModel;

namespace Tutorial.Portal.Service
{
    public interface ICommonService<T> where T : BaseEntityModel, new() 
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        bool Add(T entity);

        bool Edit(T entity);

        bool DeleteById(int id);
    }
}