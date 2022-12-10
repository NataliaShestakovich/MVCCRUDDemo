using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo.Services.Interfaces
{
    public interface IFriendService
    {
        public List<Friend>? GetFriends();

        public Friend Create(Friend friend);

        public void Update(Friend friend);

        public void Delete(Friend friend);

        public Friend? Get(Guid id);
    }

}
