using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSystemCodeFirstEF.Entities
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        [Required]
        public string MovieName { get; set; }
        public string? Language { get; set; }
        public int? ReleaseYear { get; set; }
        public string? Actor { get; set; }
        public string? Director { get; set; }
    }
}
