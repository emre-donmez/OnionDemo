namespace OnionDemo.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsDel { get; set; }
    }
}