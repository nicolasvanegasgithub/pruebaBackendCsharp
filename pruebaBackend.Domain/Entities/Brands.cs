using pruebaBackend.Domain.ValueObjects.Brands;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.Entities
{
    public class Brands
    {
        public int Id { get; init; }
        [MaxLength(20)]
        public BrandName Name { get; private set; }
        public Brands(int id)
        {
            Id = id;
        }
    }
}
