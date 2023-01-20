using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo.Repositories.Interfaces
{
    public interface IRepository <T> where T : class
    {
        T Add( T objectT);

        void Update(T objectT);

        void Delete(T objectT);

        T? Get(Guid id);

        List<T> GetList ();
    }
}
