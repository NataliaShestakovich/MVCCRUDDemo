using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo.Repositories.Interfaces
{
    public interface IFriendRepository
    {
        public Friend Add(Friend friend);

        public void Update(Friend friend);

        public void Delete(Friend friend);

        public Friend? Get(Guid id);

        public List<Friend> GetList ();
    }
}
