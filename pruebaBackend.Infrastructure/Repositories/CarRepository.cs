using Microsoft.EntityFrameworkCore;
using pruebaBackend.Domain.Entities;
using pruebaBackend.Domain.Repositories;
using pruebaBackend.Domain.ValueObjects.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly DatabaseContext _dbContext;
        public CarRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddCar(Cars car)
        {
            await _dbContext.Cars.AddAsync(car);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cars>> GetAllCars()
        {
            return await _dbContext.Cars.ToListAsync();
        }

        public async Task<Cars> GetCarById(CarId id)
        {
            return await _dbContext.Cars.FindAsync((int)id);
        }
    }
}
