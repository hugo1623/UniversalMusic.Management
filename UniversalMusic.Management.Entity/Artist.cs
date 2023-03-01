using System.ComponentModel.DataAnnotations;

namespace UniversalMusic.Management.Entity
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nickname { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Nationality { get; set; }
        [Required]
        public string Sex { get; set; }

    }
}
