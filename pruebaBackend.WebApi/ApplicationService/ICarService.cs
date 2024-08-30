using pruebaBackend.Domain.Entities;
using pruebaBackend.WebApi.Command;

namespace pruebaBackend.WebApi.ApplicationService
{
    public interface ICarService
    {
        Task CommandHandler(CreateCarCommand createCarCommand);
        Task<Cars> GetCarsAsync(int id);
        Task<IEnumerable<Cars>> GetAllCarsAsync();
    }
}
