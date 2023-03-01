using System.ComponentModel.DataAnnotations;

namespace UniversalMusic.Management.Entity
{
    public class Disc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Artist { get; set; }
        [Required]
        [StringLength(50)]
        public string GenreType { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int TotalSales {get; set; }
        [Required]
        public bool IsTopTen { get; set; }

    }
}
