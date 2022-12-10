using System.ComponentModel.DataAnnotations;

namespace MVCCRUDDemo.Models.Domain
{
    public class Friend
    {
        [Key]
        public Guid FriendID { get; set; }

        [Required]
        public string FriendName { get; set; }

        [Required]
        public string Place { get; set; }
    }
}
