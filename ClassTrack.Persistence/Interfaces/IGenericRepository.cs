namespace ClassTrack.Persistence.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        #region Metodos Asincronos
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T?> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        #endregion
    }
}
