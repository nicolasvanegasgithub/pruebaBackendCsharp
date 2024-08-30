using pruebaBackend.Domain.ValueObjects.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Brands
{
    public class BrandId
    {
        public int Value { get; set; }
        public BrandId(int value)
        {
            Value = value;
        }
        public static BrandId Create(int value)
        {
            return new BrandId(value);
        }

        public static implicit operator int(BrandId id)
        {
            return id.Value;
        }
    }
}
