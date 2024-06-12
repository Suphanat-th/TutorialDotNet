using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core;
using Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class _BaseRepository<TEntity> : _IBaseRepository<TEntity> where TEntity : _BaseEntity
{
    protected readonly BaseContext _context;
    public _BaseRepository(BaseContext baseContext)
    {
        this._context = baseContext;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task<bool> DoesExist(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().AnyAsync(predicate);
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        entity.CreateDateUTC = DateTime.UtcNow;
        entity.UpdateDateUTC = entity.CreateDateUTC;
        entity.isActive = true;

        await _context.Set<TEntity>().AddAsync(entity);

        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdateDateUTC = DateTime.UtcNow;

        return entity;
    }

    public TEntity Remove(TEntity entity)
    {
        entity.UpdateDateUTC = DateTime.UtcNow;
        entity.isActive = false;

        return entity;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}