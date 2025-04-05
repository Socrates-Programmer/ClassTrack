using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class DepartamentoRepository : IGenericRepository<Departamento>
    {
        private readonly DbUniversidadContext _universidadContext;

        public DepartamentoRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(Departamento entity)
        {
            _universidadContext.Departamentos.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Departamento>> GetAllAsync()
        {
            return await _universidadContext.Departamentos.AsNoTracking().ToListAsync();
        }

        public async Task<Departamento?> GetAsync(int id)
        {
            return await _universidadContext.Departamentos.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(Departamento entity)
        {
            await _universidadContext.Departamentos.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Departamento entity)
        {
            _universidadContext.Departamentos.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
