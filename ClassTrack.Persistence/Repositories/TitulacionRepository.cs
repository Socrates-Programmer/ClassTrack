using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class TitulacionRepository : IGenericRepository<Titulacion>
    {
        private readonly DbUniversidadContext _universidadContext;

        public TitulacionRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(Titulacion entity)
        {
            _universidadContext.Titulaciones.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Titulacion>> GetAllAsync()
        {
            return await _universidadContext.Titulaciones.AsNoTracking().ToListAsync();
        }

        public async Task<Titulacion?> GetAsync(int id)
        {
            return await _universidadContext.Titulaciones.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Titulacion entity)
        {
            await _universidadContext.Titulaciones.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Titulacion entity)
        {
            _universidadContext.Titulaciones.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
