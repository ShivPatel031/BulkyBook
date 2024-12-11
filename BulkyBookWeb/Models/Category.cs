using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,10,ErrorMessage ="Display Order must be between 1 to 10")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDataTime { get; set; } = DateTime.Now; // to give default date 

    }
}
