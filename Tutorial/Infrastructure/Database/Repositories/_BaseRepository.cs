using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Interface;
using Domain.Entity;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class _BaseRepository<TEntity> : _IBaseRepository<TEntity> where TEntity : _BaseEntity
{
    protected readonly DataContext _context;
    public _BaseRepository(DataContext baseContext)
    {
        this._context = baseContext;
    }

    public async Task<IEnumerable<TEntity?>> GetAsync() => await Task.FromResult(_context.Set<TEntity>().AsEnumerable());
    public async Task<TEntity?> GetByIdAsync(int id) => await _context.Set<TEntity>().FindAsync(id);


    public async Task<bool> DoesExist(Expression<Func<TEntity, bool>> predicate) => await _context.Set<TEntity>().AnyAsync(predicate);


    public async Task<TEntity?> AddAsync(TEntity entity)
    {
        entity.CreatedDateUTC = DateTime.UtcNow;
        entity.UpdatedDateUTC = entity.CreatedDateUTC;
        entity.IsActive = true;

        await _context.Set<TEntity>().AddAsync(entity);

        return entity;

    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdatedDateUTC = DateTime.UtcNow;
        return entity;
    }

    public TEntity Remove(TEntity entity)
    {
        entity.UpdatedDateUTC = DateTime.UtcNow;
        entity.IsActive = false;
        return entity;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
