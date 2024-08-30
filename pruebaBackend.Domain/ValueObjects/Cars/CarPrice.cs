using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Cars
{
    public class CarPrice
    {
        public int Value { get; set; }
        public CarPrice(int value)
        {
            Value = value;
        }
        public static CarPrice Create(int value)
        {
            return new CarPrice(value);
        }
    }
}
