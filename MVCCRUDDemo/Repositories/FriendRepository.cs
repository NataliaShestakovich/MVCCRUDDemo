using MVCCRUDDemo.DBContext;
using MVCCRUDDemo.Models.Domain;
using MVCCRUDDemo.Repositories.Interfaces;

namespace MVCCRUDDemo.Repositories
{
    public class FriendRepository : IRepository<Friend>
    {
        private readonly MVCDbContext _friendDBContext;

        public FriendRepository(MVCDbContext friendDB)
        {
            _friendDBContext = friendDB;
        }

        public Friend Add (Friend friend)
        {
            friend.FriendID = Guid.NewGuid();

            _friendDBContext.Friends.Add(friend);

            _friendDBContext?.SaveChanges();
            
            return friend;
        }

        public void Delete(Friend friend)
        {
            var _friend = _friendDBContext.Friends.Find(friend.FriendID);

            if (_friend!= null)
            {
                _friendDBContext.Friends.Remove(_friend);

                _friendDBContext.SaveChanges();
            }            
        }

        public Friend? Get(Guid id)
        {
            if (id != default)
            {
                return _friendDBContext.Friends.Find(id);
            }

            return null;
        }

        public List<Friend> GetList()
        {
            return _friendDBContext.Friends.ToList();
        }

        public void Update(Friend friend)
        {
             _friendDBContext.Update(friend);

             _friendDBContext.SaveChanges();
        }
    }
}
