using System.ComponentModel.DataAnnotations;

namespace WearHouseMiniProject.Models
{
    public class UserData
    {
        [Key]
        [StringLength(5)]
        public string UserID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Password { get; set; }

        /*public ICollection<UserData> UserDatas { get; set; }

        public Category Category { get; set; }*/
    }
}
