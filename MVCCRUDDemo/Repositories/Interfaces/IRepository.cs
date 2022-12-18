using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo.Repositories.Interfaces
{
    public interface IRepository <T> where T : class
    {
        public T Add( T objectT);

        public void Update(T objectT);

        public void Delete(T objectT);

        public T? Get(Guid id);

        public List<T> GetList ();
    }
}
