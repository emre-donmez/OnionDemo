namespace OnionDemo.MVC.Models
{
    public class ApiProductGetResponseModel
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}
