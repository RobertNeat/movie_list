using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        [StringLength(50, ErrorMessage = "Tytuł nie może przekraczać 50 znaków.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Opis jest wymagany.")]
        [UIHint("LongText")]
        public string Description { get; set; }

        [Range(0, 5, ErrorMessage = "Ocena filmu musi być liczbą pomiędzy 1 a 5")]
        [UIHint("Stars")]
        public int Rating { get; set; }
        public string? TrailerLink { get; set; }
        public Genre Genre { get; set; }
    }
}
