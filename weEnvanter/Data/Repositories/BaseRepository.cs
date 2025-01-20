using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using weEnvanter.Data.Repositories.Interfaces;
using weEnvanter.Domain.Common;

namespace weEnvanter.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly WeEnvanterDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(WeEnvanterDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.Where(x => !x.IsDeleted).ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.IsDeleted = false;
            
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var existingEntity = await GetByIdAsync(entity.Id);
            if (existingEntity == null)
                throw new ArgumentException($"ID'si {entity.Id} olan kayıt bulunamadı.");

            entity.ModifiedDate = DateTime.Now;
            entity.CreatedDate = existingEntity.CreatedDate; // Oluşturulma tarihini koru
            entity.IsDeleted = existingEntity.IsDeleted; // Silinme durumunu koru

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
                return false;

            entity.IsDeleted = true;
            entity.ModifiedDate = DateTime.Now;
            
            await _context.SaveChangesAsync();
            return true;
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            return await _dbSet.AnyAsync(x => x.Id == id && !x.IsDeleted);
        }
    }
} 