using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class GruposRepository : IGenericRepository<Grupos>
    {
        private readonly DbUniversidadContext _universidadContext;

        public GruposRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(Grupos entity)
        {
            _universidadContext.Grupos.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Grupos>> GetAllAsync()
        {
            return await _universidadContext.Grupos.AsNoTracking().ToListAsync();
        }

        public async Task<Grupos?> GetAsync(int id)
        {
            return await _universidadContext.Grupos.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Grupos entity)
        {
            await _universidadContext.Grupos.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Grupos entity)
        {
            _universidadContext.Grupos.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
