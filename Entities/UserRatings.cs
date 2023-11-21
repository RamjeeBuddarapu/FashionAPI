using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FashionHexa.Entities
{
    [Table("UserRatings")]
    public class UserRatings
    {
        [Key]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "char")]
        public string? UserRatingsId { get; set; }

        [Required]
        public int ? Ratings {  get; set; }

        public DateTime RatedAt { get; set; }
    }
}
