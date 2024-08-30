using pruebaBackend.Domain.Entities;

namespace pruebaBackend.WebApi.Queries
{
    public interface ICarQueries
    {
        Task<Cars> GetCarsAsync(int id);
        Task<IEnumerable<Cars>> GetAllCarsAsync();
    }
}
