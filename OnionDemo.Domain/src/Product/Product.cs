using OnionDemo.Domain.Category;
using OnionDemo.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionDemo.Domain.Product
{
    public class Product : BaseEntity
    {
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category.Category Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
