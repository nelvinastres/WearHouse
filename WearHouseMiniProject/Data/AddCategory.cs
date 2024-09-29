using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WearHouseMiniProject.Data
{
    public class AddCategory
    {
        [ForeignKey("UserData")]
        [MaxLength(5)]
        public string UserID { get; set; }

        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }
    }
}
