using pruebaBackend.Domain.ValueObjects.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Cars
{
    public class CarId
    {
        public int Value { get; set; }
        public CarId(int value)
        {
            Value = value;
        }
        public static CarId Create(int value)
        {
            return new CarId(value);
        }
        public static implicit operator int(CarId id)
        {
            return id.Value;
        }
    }
}
