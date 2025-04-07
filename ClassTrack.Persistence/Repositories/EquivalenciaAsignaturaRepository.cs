using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class EquivalenciaAsignaturaRepository : IGenericRepository<EquivalenciaAsignatura>
    {
        private readonly DbUniversidadContext _universidadContext;

        public EquivalenciaAsignaturaRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(EquivalenciaAsignatura entity)
        {
            _universidadContext.EquivalenciaAsignaturas.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<EquivalenciaAsignatura>> GetAllAsync()
        {
            return await _universidadContext.EquivalenciaAsignaturas.AsNoTracking().ToListAsync();
        }
        public async Task<IEnumerable<EquivalenciaAsignatura>> GetAllAsyncByAsignatura(int asignaturaID)
        {
            return await _universidadContext.EquivalenciaAsignaturas
                .AsNoTracking()
                .Where(x => x.AsignaturaID1.Equals(asignaturaID))
                .ToListAsync();
        }


        public async Task<EquivalenciaAsignatura?> GetAsync(int id)
        {
            return await _universidadContext.EquivalenciaAsignaturas.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(EquivalenciaAsignatura entity)
        {
            await _universidadContext.EquivalenciaAsignaturas.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(EquivalenciaAsignatura entity)
        {
            _universidadContext.EquivalenciaAsignaturas.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
