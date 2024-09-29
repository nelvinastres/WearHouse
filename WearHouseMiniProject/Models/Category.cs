using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WearHouseMiniProject.Models
{
    public class Category
    {
        [ForeignKey("UserData")]
        [MaxLength(5)]
        public string UserID { get; set; }

        [MaxLength(50)]
        public string CategoryName { get; set; }

        [Key]
        public int Id { get; set; }
    }
}
