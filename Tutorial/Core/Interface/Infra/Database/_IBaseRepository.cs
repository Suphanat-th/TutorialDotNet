using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entitys;

namespace Core;
public interface _IBaseRepository<TEntity> where TEntity : _BaseEntity
{
    Task<TEntity> GetByIdAsync(int id);
    Task<bool> DoesExist(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> AddAsync(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Remove(TEntity entity);
    Task SaveChangesAsync();
}
