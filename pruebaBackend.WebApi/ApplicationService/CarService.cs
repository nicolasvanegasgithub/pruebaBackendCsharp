using pruebaBackend.Domain.Entities;
using pruebaBackend.Domain.Repositories;
using pruebaBackend.Domain.ValueObjects.Cars;
using pruebaBackend.WebApi.Command;
using pruebaBackend.WebApi.Queries;

namespace pruebaBackend.WebApi.ApplicationService
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _cardRepository;
        private readonly ICarQueries _carQueries;
        private readonly IBrandRepository _brandRepository;


        public CarService(ICarRepository cardRepository, ICarQueries carQueries, IBrandRepository brandRepository)
        {
            _cardRepository = cardRepository;
            _carQueries = carQueries;
            _brandRepository = brandRepository;
        }

        public async Task CommandHandler(CreateCarCommand createCarCommand)
        {
            var car = new Cars(createCarCommand.id);
            car.SetModel(CarModel.Create(createCarCommand.model));
            car.SetDescription(CarDescription.Create(createCarCommand.description));
            car.SetKm(CarKm.Create(createCarCommand.km));
            car.SetPrice(CarPrice.Create(createCarCommand.price));

            Brands brand = await _brandRepository.GetBrandsAsync(createCarCommand.brandId);

            if (brand != null) {
                car.SetBrand(brand);
            }

            await _cardRepository.AddCar(car);
        }

        public async Task<Cars> GetCarsAsync(int id)
        {
            return await _carQueries.GetCarsAsync(id);
        }
        public async Task<IEnumerable<Cars>> GetAllCarsAsync()
        {
            return await _carQueries.GetAllCarsAsync();
        }
    }
}
