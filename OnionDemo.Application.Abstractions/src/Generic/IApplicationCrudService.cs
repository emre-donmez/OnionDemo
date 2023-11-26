using OnionDemo.Domain.Entities.Common;

namespace OnionDemo.Application.Abstractions.src.Generic
{
    public interface IApplicationCrudService<TEntity, TDto> where TEntity : BaseEntity
    {
        Task<List<TDto>> GetAll();

        Task<TDto> Create(TDto dto);

        Task<TDto> Update(TDto dto);

        Task<TDto> GetById(Guid id);

        Task<TDto> Disable(Guid id);

        Task<TDto> Enable(Guid id);
    }
}