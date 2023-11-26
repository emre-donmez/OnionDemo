namespace OnionDemo.WebApi.Model.Category.Response
{
    public class CategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}