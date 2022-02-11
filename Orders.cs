using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseHomework
{
    public class Orders
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        
        public Authors Author { get; set; }

        [Required, MaxLength(255)]
        public string Name  { get; set; }

        [Required]
        
    }
}
