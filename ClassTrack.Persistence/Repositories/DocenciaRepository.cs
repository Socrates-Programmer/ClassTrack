using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class DocenciaRepository : IGenericRepository<Docencia>
    {
        private readonly DbUniversidadContext _universidadContext;

        public DocenciaRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(Docencia entity)
        {
            _universidadContext.Docencias.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Docencia>> GetAllAsync()
        {
            return await _universidadContext.Docencias.AsNoTracking().ToListAsync();
        }

        public async Task<Docencia?> GetAsync(int id)
        {
            return await _universidadContext.Docencias.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Docencia entity)
        {
            await _universidadContext.Docencias.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Docencia entity)
        {
            _universidadContext.Docencias.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
