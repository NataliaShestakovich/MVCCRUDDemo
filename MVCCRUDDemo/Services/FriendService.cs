using MVCCRUDDemo.Models.Domain;
using MVCCRUDDemo.Repositories.Interfaces;
using MVCCRUDDemo.Services.Interfaces;


namespace MVCCRUDDemo.Services
{
    public class FriendService : IFriendService
    {
        private readonly IRepository<Friend> _repository;

        public FriendService(IRepository<Friend> repository)
        {
            _repository = repository;
        }

        public Friend Create(Friend friend)
        {
            return _repository.Add(friend);
        }

        public void Delete(Friend friend)
        {
            _repository.Delete(friend);
        }

        public Friend? Get(Guid id)
        {
            return _repository.Get(id);
        }

        public List<Friend>? GetFriends()
        {
            return _repository.GetList();
        }

        public void Update(Friend friend)
        {
            _repository.Update(friend);
        }
    }
}
