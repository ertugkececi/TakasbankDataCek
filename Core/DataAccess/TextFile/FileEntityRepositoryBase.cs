using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.TextFile
{
    public class FileEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public string FilePath { get; set; }

        public void Add(TEntity entity)
        {
            File.AppendAllText(FilePath, entity.StringQuery + "\n");
        }

        public void AddAll(List<TEntity> entityList)
        {
            foreach (var entity in entityList)
            {
                File.AppendAllText(FilePath, entity.StringQuery + "\n");
            }
        }

        public void Delete(TEntity entity)
        {
            var contentList = File.ReadAllLines(FilePath).ToList();
            contentList.Remove(entity.StringQuery);
            File.WriteAllText(FilePath, string.Empty);
            File.WriteAllLines(FilePath, contentList);
        }

        public void DeleteAll(List<TEntity> entityList)
        {
            var contentList = File.ReadAllLines(FilePath).ToList();
            foreach (var entity in entityList)
            {
                contentList.Remove(entity.StringQuery);
            }
            File.WriteAllText(FilePath, string.Empty);
            File.WriteAllLines(FilePath, contentList);
        }

        public TEntity Get(string containsString)
        {
            var content = File.ReadAllLines(FilePath).ToList().SingleOrDefault(o => o.Contains(containsString));
            TEntity entity = new TEntity();
            entity.StringQuery = content;
            return entity;
        }

        public List<TEntity> GetAll()
        {
            List<TEntity> entities = new List<TEntity>();

            foreach (var item in File.ReadAllLines(FilePath).ToList())
            {
                TEntity entity = new TEntity();
                entity.StringQuery = item;
                entities.Add(entity);
            }

            return entities;
        }

        public void Update(TEntity oldEntity, TEntity newEntity)
        {
            var contentList = File.ReadAllLines(FilePath).ToList();
            contentList.Remove(oldEntity.StringQuery);
            contentList.Add(newEntity.StringQuery);
            File.WriteAllText(FilePath, string.Empty);
            File.WriteAllLines(FilePath, contentList);
        }

        public void UpdateAll(List<TEntity> oldEntityList, List<TEntity> newEntityList)
        {
            DeleteAll(oldEntityList);
            var contentList = File.ReadAllLines(FilePath).ToList();
            foreach (var entity in newEntityList)
            {
                contentList.Add(entity.StringQuery);
            }
            File.WriteAllText(FilePath, string.Empty);
            File.WriteAllLines(FilePath, contentList);
        }
    }
}
