using pruebaBackend.Domain.Entities;
using pruebaBackend.Domain.ValueObjects.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.Repositories
{
    public interface ICarRepository
    {
        Task AddCar(Cars car);
        Task<IEnumerable<Cars>> GetAllCars();
        Task<Cars> GetCarById(CarId id);
    }
}
