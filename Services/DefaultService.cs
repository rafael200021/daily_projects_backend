using Daily_Project.IRepositories;
using Daily_Project.IServices;

namespace Daily_Project.Services
{
    public class DefaultService<T>:IDefaultService<T> where T : class
    {

        public readonly IDefaultRepository<T> _repository;

        public DefaultService(IDefaultRepository<T> repository) {

            _repository = repository;

        }

        public Task<IEnumerable<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<T> GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Task Create(T entity)
        {
            return _repository.Create(entity);
        }

        public Task Update(T entity, int id)
        {
            return _repository.Update(entity,id);
        }

        public Task Delete(int id) {
            return _repository.Delete(id);
        }

    }
}
