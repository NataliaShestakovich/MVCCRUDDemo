using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo
{
    public static class ListOfFriends
    {
        private static int count = 0;
        
        public static List <Friend> friends;

        static ListOfFriends()
        {
            count++;
            friends = new List<Friend>();
        }
    }
}
