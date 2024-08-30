﻿using pruebaBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.Repositories
{
    public interface IBrandRepository
    {
        Task<Brands> GetBrandsAsync(int id);
    }
}
