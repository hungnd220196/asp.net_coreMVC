using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }    
        public int DisplayOrder {  get; set; }
        public DateTime CreatedDateTime { get; set; }= DateTime.Now;    
    }
}
