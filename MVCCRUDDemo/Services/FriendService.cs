using MVCCRUDDemo.Models.Domain;
using MVCCRUDDemo.Repositories.Interfaces;
using MVCCRUDDemo.Services.Interfaces;


namespace MVCCRUDDemo.Services
{
    public class FriendService : IFriendService
    {
        private readonly IFriendRepository _friendRepository;

        public FriendService(IFriendRepository friendRepository)
        {
            _friendRepository = friendRepository;
        }

        public Friend Create(Friend friend)
        {
            return _friendRepository.Add(friend);
        }

        public void Delete(Friend friend)
        {
            _friendRepository.Delete(friend);
        }

        public Friend? Get(Guid id)
        {
            return _friendRepository.Get(id);
        }

        public List<Friend>? GetFriends()
        {
            return _friendRepository.GetList();
        }

        public void Update(Friend friend)
        {
            _friendRepository.Update(friend);
        }
    }
}
