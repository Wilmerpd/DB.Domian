
using DB.Domian.Base;
using DB.Domian.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DB.Domain.Repositorios
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly List<T> _entities = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(T entity)
        {
            entity.Id = _entities.Count + 1;  // Asigna un ID único
            entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            var existingEntity = GetById(entity.Id);
            if (existingEntity != null)
            {
                existingEntity = entity;
                existingEntity.UpdatedDate = DateTime.Now;
            }
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }
    }
}

