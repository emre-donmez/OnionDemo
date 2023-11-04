using OnionDemo.Domain.Entities.Common;

namespace OnionDemo.Domain.Product
{
    public class Product : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
