using System.ComponentModel.DataAnnotations;

namespace MVCCRUDDemo.Models.Domain
{
    public class Friend
    {
        [Required]
        [Display(Name = "Id")]
        public Guid FriendID { get; set; }

        [Display(Name ="Name")]
        [Required(ErrorMessage = "Field {0} cannot be empty", AllowEmptyStrings = true)]
        public string FriendName { get; set; }

        [Required(ErrorMessage = "Field {0} cannot be empty")]
        [StringLength(25)]
        public string Place { get; set; }
    }
}
