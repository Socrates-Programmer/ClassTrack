using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class AsignaturasRepository : IGenericRepository<Asignatura>
    {

        private readonly DbUniversidadContext _universidadContext;

        public AsignaturasRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(Asignatura entity)
        {
            _universidadContext.Asignaturas.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Asignatura>> GetAllAsync()
        {
            return await _universidadContext.Asignaturas.AsNoTracking().ToListAsync();
        }

        public async Task<Asignatura?> GetAsync(int id)
        {
            return await _universidadContext.Asignaturas.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Asignatura entity)
        {
            await _universidadContext.Asignaturas.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Asignatura entity)
        {
            _universidadContext.Asignaturas.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
