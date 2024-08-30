using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Cars
{
    public class CarKm
    {
        public int Value { get; set; }
        public CarKm(int value)
        {
            Value = value;
        }
        public static CarKm Create(int value)
        {
            return new CarKm(value);
        }
    }
}
