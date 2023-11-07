namespace OnionDemo.WebApi.Model.Category.Request
{
    public class CategoryUpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created {  get; set; }
    }
}
