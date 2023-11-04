namespace OnionDemo.Application.Abstractions.Product
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public Category.CategoryDto Category { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}
