using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacao_TOTP_2FA.Domain.Entities;
using Validacao_TOTP_2FA.Infra.Context;
using Validacao_TOTP_2FA.Infra.Interfaces;

namespace Validacao_TOTP_2FA.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {

        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> CreateAsync(T obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<T> UpdateAsync(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task RemoveAsync(long id)
        {
            var obj = await GetAsync(id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }

        public virtual async Task<T> GetAsync(long id)
        {
            var obj = await _context.Set<T>()
                                    .AsNoTracking()
                                    .Where(x => x.Id == id)
                                    .ToListAsync();

            return obj.FirstOrDefault();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }


    }
}
