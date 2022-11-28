using System.ComponentModel.DataAnnotations;

namespace MVCCRUDDemo.Models.Domain
{
    [Serializable]
    public class Friend
    {
        public Guid FriendID { get; set; }
        [Required]
        public string FriendName { get; set;}
        [Required]
        public string Place { get; set;}
    }
}
