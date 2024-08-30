using pruebaBackend.Domain.Entities;
using pruebaBackend.Domain.Repositories;
using pruebaBackend.Domain.ValueObjects.Cars;

namespace pruebaBackend.WebApi.Queries
{
    public class CarQueries : ICarQueries
    {
        private readonly ICarRepository _cardRepository;
        public CarQueries(ICarRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<Cars> GetCarsAsync(int id)
        {
            var response = await _cardRepository.GetCarById(
                    CarId.Create(id)
                );
            return response;
        }

        public async Task<IEnumerable<Cars>> GetAllCarsAsync()
        {
            var response = await _cardRepository.GetAllCars();
            return response;
        }
    }
}
