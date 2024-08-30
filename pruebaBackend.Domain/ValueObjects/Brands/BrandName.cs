using pruebaBackend.Domain.ValueObjects.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBackend.Domain.ValueObjects.Brands
{
    public class BrandName
    {
        public string Value { get; set; }
        public BrandName(string value)
        {
            Value = value;
        }
        public static BrandName Create(string value)
        {
            return new BrandName(value);
        }
    }
}
