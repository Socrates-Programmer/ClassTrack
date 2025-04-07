using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class ProfesoresRepository : IGenericRepository<Profesor>
    {
        private readonly DbUniversidadContext _universidadContext;

        public ProfesoresRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }

        public async Task<bool> DeleteAsync(Profesor entity)
        {
            _universidadContext.Profesores.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Profesor>> GetAllAsync()
        {
            return await _universidadContext.Profesores.AsNoTracking().ToListAsync();
        }

        public async Task<Profesor?> GetAsync(int id)
        {
            return await _universidadContext.Profesores
                .Include(x => x.AreaConocimiento)
                .ThenInclude(x => x.Departamento)
                .Include(x => x.HorarioConsultas)
                .Include(x => x.Docencias)
                .ThenInclude(x => x.Asignatura)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Profesor entity)
        {
            await _universidadContext.Profesores.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Profesor entity)
        {
            _universidadContext.Profesores.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
