using System.ComponentModel.DataAnnotations;

namespace WearHouseMiniProject.Data
{
    public class LoginValidate
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
