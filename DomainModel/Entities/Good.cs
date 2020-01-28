using System;

namespace DomainModel.Entities
{
    public class Good
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }
        public Sex Sex { get; set; }
        public string Type { get; set; }

        public int Count { get; set; }

        public double Rating { get; set; }

        public string ImgName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public int? BrandId { get; set; }
        public Brand Brand { get; set; }
    }

    public enum Sex
    {
        Girl = 1,
        Boy = 2
    }
}
