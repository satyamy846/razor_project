using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rajor_Project_mvc.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Catagory Name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0,100, ErrorMessage ="DisplayOrder must be between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
