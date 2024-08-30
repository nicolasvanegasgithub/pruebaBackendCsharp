using pruebaBackend.Domain.Entities;
using pruebaBackend.Domain.Repositories;
using pruebaBackend.Domain.ValueObjects.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DatabaseContext _dbContext;
        public BrandRepository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }

        public async Task<Brands> GetBrandsAsync(int id)
        {
            return await _dbContext.Brands.FindAsync(id);
        }
    }
}
