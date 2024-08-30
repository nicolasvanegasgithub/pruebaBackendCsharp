using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Cars
{
    public class CarModel
    {
        public string Value { get; set; }
        public CarModel(string value)
        {
            Value = value;
        }

        public static CarModel Create(string value)
        {
            return new CarModel(value);
        }
    }
}
