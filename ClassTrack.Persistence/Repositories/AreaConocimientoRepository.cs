using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class AreaConocimientoRepository : IGenericRepository<AreaConocimiento>
    {

        private readonly DbUniversidadContext _universidadContext;

        public AreaConocimientoRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(AreaConocimiento entity)
        {
            _universidadContext.AreaConocimientos.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<AreaConocimiento>> GetAllAsync()
        {
            return await _universidadContext.AreaConocimientos.AsNoTracking().ToListAsync();
        }

        public async Task<AreaConocimiento?> GetAsync(int id)
        {
            return await _universidadContext.AreaConocimientos.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(AreaConocimiento entity)
        {
            await _universidadContext.AreaConocimientos.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(AreaConocimiento entity)
        {
            _universidadContext.AreaConocimientos.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
