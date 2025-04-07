using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class IncompatibilidadAsignaturaRepository : IGenericRepository<IncompatibilidadAsignatura>
    {
        private readonly DbUniversidadContext _universidadContext;

        public IncompatibilidadAsignaturaRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(IncompatibilidadAsignatura entity)
        {
            _universidadContext.IncompatibilidadAsignaturas.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<IncompatibilidadAsignatura>> GetAllAsync()
        {
            return await _universidadContext.IncompatibilidadAsignaturas.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<IncompatibilidadAsignatura>> GetAllAsyncByAsignatura(int asignaturaID)
        {
            return await _universidadContext.IncompatibilidadAsignaturas
                .Include(x => x.Asignatura)
                .AsNoTracking()
                .Where( x => x.AsignaturaID1.Equals(asignaturaID))
                .ToListAsync();
        }

        public async Task<IncompatibilidadAsignatura?> GetAsync(int id)
        {
            return await _universidadContext.IncompatibilidadAsignaturas.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(IncompatibilidadAsignatura entity)
        {
            await _universidadContext.IncompatibilidadAsignaturas.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(IncompatibilidadAsignatura entity)
        {
            _universidadContext.IncompatibilidadAsignaturas.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
