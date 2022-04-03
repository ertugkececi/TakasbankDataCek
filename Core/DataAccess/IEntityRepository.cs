using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        string FilePath { get; set; }
        void Add(T entity);
        void AddAll(List<T> entityList);
        void Delete(T entity);
        void DeleteAll(List<T> entityList);
        void Update(T oldEntity, T newEntity);
        void UpdateAll(List<T> oldEntityList, List<T> newEntityList);
        T Get(string containsString);
        List<T> GetAll();

    }
}
