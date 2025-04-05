using ClassTrack.Domain.Entities;
using ClassTrack.Persistence.Contexts;
using ClassTrack.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Repositories
{
    public class HorarioConsultaRepository : IGenericRepository<HorarioConsulta>
    {
        private readonly DbUniversidadContext _universidadContext;

        public HorarioConsultaRepository()
        {
            _universidadContext = new DbUniversidadContext();
        }
        public async Task<bool> DeleteAsync(HorarioConsulta entity)
        {
            _universidadContext.HorarioConsultas.Remove(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<HorarioConsulta>> GetAllAsync()
        {
            return await _universidadContext.HorarioConsultas.AsNoTracking().ToListAsync();
        }

        public async Task<HorarioConsulta?> GetAsync(int id)
        {
            return await _universidadContext.HorarioConsultas.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> InsertAsync(HorarioConsulta entity)
        {
            await _universidadContext.HorarioConsultas.AddAsync(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(HorarioConsulta entity)
        {
            _universidadContext.HorarioConsultas.Update(entity);
            return await _universidadContext.SaveChangesAsync() > 0;
        }
    }
}
