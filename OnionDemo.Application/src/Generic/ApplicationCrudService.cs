using AutoMapper;
using OnionDemo.Application.Abstractions.src.Generic;
using OnionDemo.Domain.Entities.Common;
using OnionDemo.Persistence.src.Context.Main;
using System.Linq.Expressions;

namespace OnionDemo.Application.Generic
{
    public class ApplicationCrudService<TEntity, TDto> : IApplicationCrudService<TEntity, TDto>
     where TEntity : BaseEntity
    {
        private readonly MainDbContext _context;
        private readonly IMapper _mapper;

        public ApplicationCrudService(MainDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<TDto>> GetAll(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity,bool>> orderBy = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = predicate != null ? query.Where(predicate) : query;
            query = orderBy != null ? query.OrderBy(orderBy) : query;

            var entities = query.ToList();
            var dtos = _mapper.Map<List<TDto>>(entities.AsQueryable());

            return Task.FromResult(dtos);
        }

        public Task<TDto> GetById(Guid id)
        {
            var entity = _context.Find<TEntity>(id);
            var dto = _mapper.Map<TDto>(entity);

            return Task.FromResult(dto);
        }

        public Task<TDto> Create(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            if (entity.Id == Guid.Empty)
                entity.Id = Guid.NewGuid();

            entity.Created = DateTime.Now;
            entity.IsDel = false;

            _context.Add<TEntity>(entity);
            _context.SaveChanges();

            var result = _mapper.Map<TDto>(entity);

            return Task.FromResult(result);
        }

        public Task<TDto> Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            _context.Update(entity);
            _context.SaveChanges();

            return Task.FromResult(dto);
        }

        public Task<TDto> Disable(Guid id)
        {
            var entity = _context.Find<TEntity>(id);
            entity.IsDel = true;

            _context.Update(entity);
            _context.SaveChanges();

            var dto = _mapper.Map<TDto>(entity);

            return Task.FromResult(dto);
        }

        public Task<TDto> Enable(Guid id)
        {
            var entity = _context.Find<TEntity>(id);
            entity.IsDel = false;

            _context.Update(entity);
            _context.SaveChanges();

            var dto = _mapper.Map<TDto>(entity);

            return Task.FromResult(dto);
        }
    }
}