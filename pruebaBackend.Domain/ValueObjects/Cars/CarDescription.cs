using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Cars
{
    public class CarDescription
    {
        public string Value { get; set; }
        public CarDescription(string value)
        {
            Value = value;
        }
        public static CarDescription Create(string value)
        {
            return new CarDescription(value);
        }
    }
}
