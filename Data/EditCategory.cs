using System.ComponentModel.DataAnnotations;

namespace WearHouseMiniProject.Data
{
    public class EditCategory
    {
        //public string UserID { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
