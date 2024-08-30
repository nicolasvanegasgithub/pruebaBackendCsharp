using pruebaBackend.Domain.ValueObjects.Cars;
using System.ComponentModel.DataAnnotations;

namespace pruebaBackend.Domain.Entities
{
    public class Cars
    {
        public int Id { get; init; }

        [MaxLength(20)]
        public CarModel Model { get; private set; }
        [MaxLength(100)]
        public CarDescription? Description { get; private set; }
        public CarPrice Price { get; private set; }
        public CarKm Km { get; private set; }
        public int BrandId { get; private set; }
        public Brands Brand { get; private set; }
        public Cars(int id)
        {
            Id = id;
        }
        public void SetBrand(Brands brand)
        {
            Brand = brand;
            BrandId = brand.Id;
        }
        public void SetModel(CarModel model)
        {
            Model = model;
        }
        public void SetDescription(CarDescription description)
        {
            Description = description;
        }
        public void SetPrice(CarPrice price)
        {
            Price = price;
        }
        public void SetKm(CarKm km)
        {
            Km = km;
        }
    }
}
