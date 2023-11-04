namespace OnionDemo.WebApi.Model.Product.Request
{
    public class ProductCreateRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
}
