using OnionDemo.Application.Abstractions.Category;

namespace OnionDemo.WebApi.Model.Product.Response
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}